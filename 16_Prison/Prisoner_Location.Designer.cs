namespace _16_Prison
{
    partial class Prisoner_Location
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_locateEnd = new System.Windows.Forms.Button();
            this.btn_locateStart = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_criminalID = new System.Windows.Forms.TextBox();
            this.btn_inquire = new System.Windows.Forms.Button();
            this.loc_Icon = new System.Windows.Forms.PictureBox();
            this.map = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_imprisonLength = new System.Windows.Forms.TextBox();
            this.tb_imprisonTime = new System.Windows.Forms.TextBox();
            this.tb_criminalName = new System.Windows.Forms.TextBox();
            this.tb_applianceID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RfID_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_locateEnd
            // 
            this.btn_locateEnd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_locateEnd.Location = new System.Drawing.Point(731, 42);
            this.btn_locateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_locateEnd.Name = "btn_locateEnd";
            this.btn_locateEnd.Size = new System.Drawing.Size(108, 29);
            this.btn_locateEnd.TabIndex = 1;
            this.btn_locateEnd.Text = "结束定位";
            this.btn_locateEnd.UseVisualStyleBackColor = true;
            // 
            // btn_locateStart
            // 
            this.btn_locateStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_locateStart.Location = new System.Drawing.Point(593, 42);
            this.btn_locateStart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_locateStart.Name = "btn_locateStart";
            this.btn_locateStart.Size = new System.Drawing.Size(108, 29);
            this.btn_locateStart.TabIndex = 20;
            this.btn_locateStart.Text = "开始定位";
            this.btn_locateStart.UseVisualStyleBackColor = true;
            this.btn_locateStart.Click += new System.EventHandler(this.Btn_locateStart_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(13, 46);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(82, 15);
            this.lbl_ID.TabIndex = 22;
            this.lbl_ID.Text = "犯人编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_criminalID);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Location = new System.Drawing.Point(452, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(387, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "犯人定位查询";
            // 
            // tb_criminalID
            // 
            this.tb_criminalID.Location = new System.Drawing.Point(93, 39);
            this.tb_criminalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_criminalID.Name = "tb_criminalID";
            this.tb_criminalID.Size = new System.Drawing.Size(213, 25);
            this.tb_criminalID.TabIndex = 22;
            // 
            // btn_inquire
            // 
            this.btn_inquire.Location = new System.Drawing.Point(452, 200);
            this.btn_inquire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inquire.Name = "btn_inquire";
            this.btn_inquire.Size = new System.Drawing.Size(108, 29);
            this.btn_inquire.TabIndex = 25;
            this.btn_inquire.Text = "开始查询";
            this.btn_inquire.UseVisualStyleBackColor = true;
            // 
            // loc_Icon
            // 
            this.loc_Icon.BackColor = System.Drawing.Color.Transparent;
            this.loc_Icon.Location = new System.Drawing.Point(2, 9);
            this.loc_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loc_Icon.Name = "loc_Icon";
            this.loc_Icon.Size = new System.Drawing.Size(31, 29);
            this.loc_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loc_Icon.TabIndex = 26;
            this.loc_Icon.TabStop = false;
            // 
            // map
            // 
            this.map.Location = new System.Drawing.Point(13, 45);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(333, 424);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map.TabIndex = 21;
            this.map.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_imprisonLength);
            this.groupBox3.Controls.Add(this.tb_imprisonTime);
            this.groupBox3.Controls.Add(this.tb_criminalName);
            this.groupBox3.Controls.Add(this.tb_applianceID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(452, 265);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(387, 194);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "犯人基本信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(303, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "年";
            // 
            // tb_imprisonLength
            // 
            this.tb_imprisonLength.Location = new System.Drawing.Point(119, 149);
            this.tb_imprisonLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_imprisonLength.Name = "tb_imprisonLength";
            this.tb_imprisonLength.Size = new System.Drawing.Size(177, 25);
            this.tb_imprisonLength.TabIndex = 22;
            // 
            // tb_imprisonTime
            // 
            this.tb_imprisonTime.Location = new System.Drawing.Point(119, 112);
            this.tb_imprisonTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_imprisonTime.Name = "tb_imprisonTime";
            this.tb_imprisonTime.Size = new System.Drawing.Size(213, 25);
            this.tb_imprisonTime.TabIndex = 21;
            // 
            // tb_criminalName
            // 
            this.tb_criminalName.Location = new System.Drawing.Point(119, 34);
            this.tb_criminalName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_criminalName.Name = "tb_criminalName";
            this.tb_criminalName.Size = new System.Drawing.Size(213, 25);
            this.tb_criminalName.TabIndex = 20;
            // 
            // tb_applianceID
            // 
            this.tb_applianceID.Location = new System.Drawing.Point(119, 70);
            this.tb_applianceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_applianceID.Name = "tb_applianceID";
            this.tb_applianceID.Size = new System.Drawing.Size(213, 25);
            this.tb_applianceID.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(36, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "入狱时间：";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(36, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "刑期：";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(36, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "犯人姓名：";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(36, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 38);
            this.label10.TabIndex = 6;
            this.label10.Text = "设备编号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "停止查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // RfID_ID
            // 
            this.RfID_ID.FormattingEnabled = true;
            this.RfID_ID.Location = new System.Drawing.Point(452, 42);
            this.RfID_ID.Name = "RfID_ID";
            this.RfID_ID.Size = new System.Drawing.Size(121, 23);
            this.RfID_ID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "RFID标签";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 457);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Prisoner_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RfID_ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loc_Icon);
            this.Controls.Add(this.btn_inquire);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.btn_locateStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_locateEnd);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prisoner_Location";
            this.Text = "人员定位";
            this.Load += new System.EventHandler(this.Prisoner_Location_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_locateEnd;
        private System.Windows.Forms.Button btn_locateStart;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_criminalID;
        private System.Windows.Forms.Button btn_inquire;
        private System.Windows.Forms.PictureBox loc_Icon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_imprisonLength;
        private System.Windows.Forms.TextBox tb_imprisonTime;
        private System.Windows.Forms.TextBox tb_criminalName;
        private System.Windows.Forms.TextBox tb_applianceID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox RfID_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

