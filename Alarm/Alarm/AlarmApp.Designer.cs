
namespace Alarm
{
    partial class AlarmApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.DateSelecet = new System.Windows.Forms.DateTimePicker();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.HoursBox = new System.Windows.Forms.ComboBox();
            this.MinuteBox = new System.Windows.Forms.ComboBox();
            this.AmPMBox = new System.Windows.Forms.ComboBox();
            this.AlarmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exmp = new System.Windows.Forms.Label();
            this.alarmap = new System.Windows.Forms.Label();
            this.AlarmGroup = new System.Windows.Forms.GroupBox();
            this.Alarmdaylabel = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.TimeGroup = new System.Windows.Forms.GroupBox();
            this.Color3 = new System.Windows.Forms.Button();
            this.Color1 = new System.Windows.Forms.Button();
            this.Color2 = new System.Windows.Forms.Button();
            this.AlarmGroup.SuspendLayout();
            this.TimeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateSelecet
            // 
            this.DateSelecet.Location = new System.Drawing.Point(11, 58);
            this.DateSelecet.Name = "DateSelecet";
            this.DateSelecet.Size = new System.Drawing.Size(200, 22);
            this.DateSelecet.TabIndex = 1;
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Interval = 1000;
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Start.Location = new System.Drawing.Point(11, 128);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 32);
            this.Start.TabIndex = 2;
            this.Start.Text = "Set Alarm";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Stop.Location = new System.Drawing.Point(122, 129);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(95, 31);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop Alrm";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // HoursBox
            // 
            this.HoursBox.FormattingEnabled = true;
            this.HoursBox.Location = new System.Drawing.Point(243, 56);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(71, 24);
            this.HoursBox.TabIndex = 4;
            this.HoursBox.SelectedIndexChanged += new System.EventHandler(this.HoursBox_SelectedIndexChanged);
            // 
            // MinuteBox
            // 
            this.MinuteBox.FormattingEnabled = true;
            this.MinuteBox.Location = new System.Drawing.Point(320, 56);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(71, 24);
            this.MinuteBox.TabIndex = 5;
            this.MinuteBox.SelectedIndexChanged += new System.EventHandler(this.MinuteBox_SelectedIndexChanged);
            // 
            // AmPMBox
            // 
            this.AmPMBox.FormattingEnabled = true;
            this.AmPMBox.Location = new System.Drawing.Point(397, 56);
            this.AmPMBox.Name = "AmPMBox";
            this.AmPMBox.Size = new System.Drawing.Size(71, 24);
            this.AmPMBox.TabIndex = 6;
            this.AmPMBox.SelectedIndexChanged += new System.EventHandler(this.AmPMBox_SelectedIndexChanged);
            // 
            // AlarmTextBox
            // 
            this.AlarmTextBox.Location = new System.Drawing.Point(243, 129);
            this.AlarmTextBox.Name = "AlarmTextBox";
            this.AlarmTextBox.Size = new System.Drawing.Size(225, 22);
            this.AlarmTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(284, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alarm Saatını Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(241, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alarm Saatını Əllə Daxil Et";
            // 
            // Exmp
            // 
            this.Exmp.AutoSize = true;
            this.Exmp.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Italic);
            this.Exmp.ForeColor = System.Drawing.Color.Red;
            this.Exmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exmp.Location = new System.Drawing.Point(241, 154);
            this.Exmp.Name = "Exmp";
            this.Exmp.Size = new System.Drawing.Size(148, 22);
            this.Exmp.TabIndex = 10;
            this.Exmp.Text = "Misal: 12:12:00 PM";
            // 
            // alarmap
            // 
            this.alarmap.AutoSize = true;
            this.alarmap.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.alarmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.alarmap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.alarmap.Location = new System.Drawing.Point(12, 9);
            this.alarmap.Name = "alarmap";
            this.alarmap.Size = new System.Drawing.Size(217, 31);
            this.alarmap.TabIndex = 12;
            this.alarmap.Text = "Sirac Alarm App";
            // 
            // AlarmGroup
            // 
            this.AlarmGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AlarmGroup.Controls.Add(this.Alarmdaylabel);
            this.AlarmGroup.Controls.Add(this.DateSelecet);
            this.AlarmGroup.Controls.Add(this.MinuteBox);
            this.AlarmGroup.Controls.Add(this.HoursBox);
            this.AlarmGroup.Controls.Add(this.Stop);
            this.AlarmGroup.Controls.Add(this.Exmp);
            this.AlarmGroup.Controls.Add(this.Start);
            this.AlarmGroup.Controls.Add(this.AmPMBox);
            this.AlarmGroup.Controls.Add(this.label2);
            this.AlarmGroup.Controls.Add(this.AlarmTextBox);
            this.AlarmGroup.Controls.Add(this.label1);
            this.AlarmGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlarmGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlarmGroup.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.AlarmGroup.Location = new System.Drawing.Point(12, 197);
            this.AlarmGroup.Name = "AlarmGroup";
            this.AlarmGroup.Size = new System.Drawing.Size(512, 262);
            this.AlarmGroup.TabIndex = 13;
            this.AlarmGroup.TabStop = false;
            this.AlarmGroup.Text = "Alarm Vaxtı";
            // 
            // Alarmdaylabel
            // 
            this.Alarmdaylabel.AutoSize = true;
            this.Alarmdaylabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.Alarmdaylabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Alarmdaylabel.Location = new System.Drawing.Point(37, 31);
            this.Alarmdaylabel.Name = "Alarmdaylabel";
            this.Alarmdaylabel.Size = new System.Drawing.Size(158, 22);
            this.Alarmdaylabel.TabIndex = 11;
            this.Alarmdaylabel.Text = "Alarm Gününü Seç";
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.ClockLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClockLabel.Location = new System.Drawing.Point(6, 78);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(41, 30);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "00";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.DayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DayLabel.Location = new System.Drawing.Point(6, 28);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(41, 30);
            this.DayLabel.TabIndex = 11;
            this.DayLabel.Text = "00";
            // 
            // TimeGroup
            // 
            this.TimeGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeGroup.Controls.Add(this.DayLabel);
            this.TimeGroup.Controls.Add(this.ClockLabel);
            this.TimeGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeGroup.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.TimeGroup.Location = new System.Drawing.Point(18, 47);
            this.TimeGroup.Name = "TimeGroup";
            this.TimeGroup.Size = new System.Drawing.Size(506, 128);
            this.TimeGroup.TabIndex = 14;
            this.TimeGroup.TabStop = false;
            this.TimeGroup.Text = "İndiki zaman";
            // 
            // Color3
            // 
            this.Color3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Color3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Color3.Location = new System.Drawing.Point(494, 16);
            this.Color3.Name = "Color3";
            this.Color3.Size = new System.Drawing.Size(24, 25);
            this.Color3.TabIndex = 15;
            this.Color3.UseVisualStyleBackColor = false;
            this.Color3.Click += new System.EventHandler(this.Color3_Click);
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Color1.Location = new System.Drawing.Point(434, 16);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(24, 25);
            this.Color1.TabIndex = 16;
            this.Color1.UseVisualStyleBackColor = false;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.DarkGray;
            this.Color2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Color2.Location = new System.Drawing.Point(464, 16);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(24, 25);
            this.Color2.TabIndex = 17;
            this.Color2.UseVisualStyleBackColor = false;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // AlarmApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(530, 481);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.Color3);
            this.Controls.Add(this.TimeGroup);
            this.Controls.Add(this.AlarmGroup);
            this.Controls.Add(this.alarmap);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "AlarmApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.AlarmApp_Load);
            this.AlarmGroup.ResumeLayout(false);
            this.AlarmGroup.PerformLayout();
            this.TimeGroup.ResumeLayout(false);
            this.TimeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.DateTimePicker DateSelecet;
        private System.Windows.Forms.Timer AlarmTimer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ComboBox HoursBox;
        private System.Windows.Forms.ComboBox MinuteBox;
        private System.Windows.Forms.ComboBox AmPMBox;
        private System.Windows.Forms.TextBox AlarmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exmp;
        private System.Windows.Forms.Label alarmap;
        private System.Windows.Forms.GroupBox AlarmGroup;
        private System.Windows.Forms.Label Alarmdaylabel;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.GroupBox TimeGroup;
        private System.Windows.Forms.Button Color3;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Button Color2;
    }
}

