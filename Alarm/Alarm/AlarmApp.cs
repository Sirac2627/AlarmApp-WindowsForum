using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Alarm
{
    public partial class AlarmApp : Form
    {
        public AlarmApp()
        {
            InitializeComponent();
        }
        int x=0;
        private void AlarmApp_Load(object sender, EventArgs e)
        {
           
            int i = 1;
            for (i = 1; i < 13; i++) { 
                HoursBox.Items.Add(i); }
       
            for (i = 1; i < 60; i++)
            {
                MinuteBox.Items.Add(i);
            }
            MinuteBox.Items.Add("00");
            AmPMBox.Items.Add("AM");
            AmPMBox.Items.Add("PM");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToLongTimeString();
            DayLabel.Text = DateTime.Now.ToLongDateString();
        }

      

        private void Start_Click(object sender, EventArgs e)
        {
            AlarmTimer.Enabled = true;
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if (AlarmTextBox.Text==ClockLabel.Text&& DateTime.Now.ToShortDateString()==DateSelecet.Value.ToShortDateString()) {
                System.Media.SoundPlayer music = new SoundPlayer();
                music.SoundLocation = "alarm.wav";
                music.Play();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            

            System.Media.SoundPlayer music = new SoundPlayer();
            music.SoundLocation = "alarm.wav";
            music.Stop();
        }

        private void HoursBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                AlarmTextBox.Text = "";
                AlarmTextBox.Text = HoursBox.Text;
                x = 1;
            
        }

        private void MinuteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x == 1)
            {
                AlarmTextBox.Text += ":";
                AlarmTextBox.Text += MinuteBox.Text;
                
            }
        }

        private void AmPMBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x == 1)
            {
                AlarmTextBox.Text += ":00 ";
                AlarmTextBox.Text += AmPMBox.Text;
               
            }
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            TimeGroup.BackColor= Color.Black;
            AlarmGroup.BackColor = Color.Black;
        }

        private void Color2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            TimeGroup.BackColor = Color.DarkGray;
            AlarmGroup.BackColor = Color.DarkGray;
        }

        private void Color3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
            TimeGroup.BackColor = Color.DodgerBlue;
            AlarmGroup.BackColor = Color.DodgerBlue;
        }
    }
}
