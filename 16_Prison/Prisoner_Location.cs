using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WebSocketSharp;

namespace _16_Prison
{
    public partial class Prisoner_Location : Form
    {
        private System.Threading.Thread _th = null; // 开启搜索线程
        private bool isStart = false;//是否开始搜索
        private static readonly string IP_Adr = "ws://192.168.0.151:9001/";//localsense 定位地址
        private static readonly int readSize = 60;
        private static readonly int singRSize = 29;
        private static readonly int picWid = 579;
        private static readonly int picHei = 613;
        private Mutex socMutex = new Mutex();
        private byte[] data = new byte[readSize];//接收数据存放处
        private int RFIDID = 0;
        private int CpLen = 21;
        //绘制得到的用户点
        MyPoint prePoint = new MyPoint(0, 0);
        MyPoint curPoint = new MyPoint(0.00, 0.00);
        Bitmap traceB = new Bitmap(picWid, picHei);

        double X = 0;
        double Y = 0;
        WebSocket socket = null;
        MyPoint curUsr = null;
        bool isChecked = false;

        private class MyPoint
        {
            //public int x { get; set; }
            //public int y { get; set; }
            //public int z { get; set; }
            public double dx { get; set; }
            public double dy { get; set; }
            //public MyPoint(int x, int y, int z)
            //{
            //    this.x = x;
            //    this.y = y;
            //    this.z = z;
            //}
            public MyPoint(double x, double y)
            {
                this.dx = x;
                this.dy = y;
            }
        }

        private void actionSet(Control e, string temp)
        {
            if (e.InvokeRequired)
            {
                Action<string> print = (x) =>
                {
                    e.Text = x.ToString();
                };
                e.Invoke(print, temp);
            }
            else
            {
                e.Text = temp;
            }
        }

        private void setLoc(MyPoint loc)
        {
            Point temp = new Point(Convert.ToInt32(loc.dx + 53), Convert.ToInt32(loc.dy + 45));
            if (this.loc_Icon.InvokeRequired)
            {
                Action<Point> draw = (x) =>
                {
                    this.loc_Icon.Location = x;
                };
                this.loc_Icon.Invoke(draw, temp);
            }
            else
            {
                this.loc_Icon.Location = temp;
            }
        }

        private string[] copyStrArWithLen(string[] preStr, int start)
        {
            string[] retunAr = new string[CpLen];
            for (int i = start; i < start + CpLen; i++)
            {
                retunAr[i - start] = preStr[i];
            }
            return retunAr;
        }

        private void asyFun(int id)
        {
            if (socket == null)
            {
                socket = new WebSocket(IP_Adr, "localSensePush-protocol");
            }
            socket.OnMessage += (sender, e) =>
            {
                try
                {
                    socMutex.WaitOne();
                }
                catch { };
                string[] temp = e.Data.Split('-');
                foreach (string i in temp)
                {
                    Console.WriteLine(i);
                }
                if (temp[0] == "CC" && temp[1] == "5F" && temp[2] == "01")
                {
                    int num = Convert.ToInt32(temp[3], 16);
                    for (int i = 0; i < num; i++)
                    {
                        string[] subTemp = copyStrArWithLen(temp, 4 + i * CpLen);
                        int tempID = Convert.ToInt32(subTemp[0] + subTemp[1], 16);
                        if (tempID == id)
                        {
                            curUsr = new MyPoint(Convert.ToInt32(subTemp[2] + subTemp[3] + subTemp[4] + subTemp[5], 16),
                                               Convert.ToInt32(subTemp[6] + subTemp[7] + subTemp[8] + subTemp[9], 16)
                                /*Convert.ToInt32(subTemp[10] + subTemp[11] + subTemp[12] + subTemp[13], 16)*/);
                        }
                    }
                }
                socMutex.ReleaseMutex();
            };
            socket.Connect();

        }

        private void drawPos()
        {
            while (true)
            {
                try
                {
                    socMutex.WaitOne();

                }
                catch
                {

                }
                if (curUsr != null)
                {
                    if (!isChecked)
                    {
                        MessageBox.Show("查询成功");
                        if (loc_Icon.InvokeRequired)
                        {
                            Action VisAc = () =>
                            {
                                this.loc_Icon.Visible = true;
                            };
                            loc_Icon.Invoke(VisAc);
                        }
                        else
                        {
                            loc_Icon.Visible = true;
                        }
                    }
                    isChecked = true;
                    if (prePoint.dx == 0 && prePoint.dy == 0)
                    {
                        curPoint = new MyPoint(325 * (935.5 - curUsr.dx - 28) / 935.5 + 189.5, 0.34601 * (curUsr.dy - 35) - 65);
                        prePoint = new MyPoint(curPoint.dx, curPoint.dy);
                        X = curPoint.dx;
                        Y = curPoint.dy;
                        drawCurPos();

                        setLoc(curPoint);
                        prePoint = curPoint;
                    }
                    else
                    {
                        curPoint = new MyPoint(325 * (935.5 - curUsr.dx - 28) / 935.5 + 189.5, 0.34601 * (curUsr.dy - 35) - 65);
                        drawCurPos();

                        setLoc(curPoint);
                        prePoint = curPoint;
                    }
                }
                socMutex.ReleaseMutex();
            }
        }

        private void drawCurPos()
        {
            //MessageBox.Show("isdrawing!");
            Point temp1 = new Point((int)prePoint.dx + 157 - 87, (int)prePoint.dy + 135 - 51);
            Point temp2 = new Point((int)curPoint.dx + 157 - 87, (int)curPoint.dy + 135 - 51);
            if (traceGraph.InvokeRequired)
            {
                Action aciton = () =>
                {
                    Graphics g = Graphics.FromImage(traceB);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//消除锯齿
                    g.DrawLine(new Pen(Color.Red, 5), temp1, temp2);
                    this.traceGraph.Image = traceB;
                };
                this.traceGraph.Invoke(aciton);
            }
            else
            {
                Graphics g = Graphics.FromImage(traceB);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//消除锯齿
                g.DrawLine(new Pen(Color.Red), temp1, temp2);
                this.traceGraph.Image = traceB;
            }
        }


        public Prisoner_Location()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Prisoner_Location_Load(object sender, EventArgs e)
        {
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormServer_FormClosed);

            string temp = Application.StartupPath;
            //MessageBox.Show(Application.StartupPath);
            Bitmap b = new Bitmap(Application.StartupPath + @"\Resources\map2.png");
            this.map.Image = b;
            this.loc_Icon.BackColor = Color.Transparent;
            this.loc_Icon.Parent = this.traceGraph;
            this.traceGraph.Parent = this.map;
            this.loc_Icon.Visible = false;
            this.traceGraph.Image = traceB;
        }

        private void Btn_locateStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (!isStart)
            {
                string RFIDID;
                if (RfID_ID.Text.Trim() == "")
                {
                    RFIDID = "15071";
                }
                else
                {
                    RFIDID = RfID_ID.Text.Trim();
                }
                asyFun(int.Parse(RFIDID));
                _th = new System.Threading.Thread(drawPos);
                _th.Start();
                isStart = true;
            }
            else
            {
                isStart = false;
                if (socket != null)
                {
                    socket.Close();
                }
                isChecked = false;
                _th.Abort();
            }
        }

        private void FormServer_FormClosed(object sender, EventArgs e)
        {
            //_th.Abort();
            //((IDisposable)this).Dispose();
            //close = true;
            //this.Close();
            isStart = false;
            if (socket != null)
            {
                socket.Close();
            }
            isChecked = false;
            _th.Abort();
            // Application.Exit();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //label3.Text = "X:" + X.ToString();
            //label2.Text = "Y:" + Y.ToString();
        }
    }
}
