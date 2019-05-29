using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Prison
{
    public partial class Main : Form
    {
        Prisoner_Location location;
        Prisoner_Track track;
        AlarmSystem alarm;
        RewardAndPunishment rap;
        MeetingManagement meeting;
        PersonalInformation personalinfo;
        ScoreManagement ScoreManagement;

        public Main()
        {
            InitializeComponent();
        }

        private void 人员定位_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            location = new Prisoner_Location();
            location.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
        }

        private void 人员轨迹_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            track = new Prisoner_Track();
            this.Hide();
            track.Show();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alarm = new AlarmSystem();
            this.Hide();
            alarm.Show();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rap = new RewardAndPunishment();
            this.Hide();
            rap.Show();
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            meeting = new MeetingManagement();
            this.Hide();
            meeting.Show();
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personalinfo = new PersonalInformation();
            this.Hide();
            personalinfo.Show();
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScoreManagement = new ScoreManagement();
            this.Hide();
            ScoreManagement.Show();
        }

        private void Main_FormClosed(Object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            personalinfo = new PersonalInformation();
            this.Hide();
            personalinfo.Show();
        }
    }
}
