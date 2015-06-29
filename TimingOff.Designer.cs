namespace TimingOff
{
    partial class TimingOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimingOff));
            this.HoursTXT = new System.Windows.Forms.TextBox();
            this.Hours = new System.Windows.Forms.ListBox();
            this.MinutsTXT = new System.Windows.Forms.TextBox();
            this.Minuts = new System.Windows.Forms.ListBox();
            this.SecondsTXT = new System.Windows.Forms.TextBox();
            this.Seconds = new System.Windows.Forms.ListBox();
            this.Off = new System.Windows.Forms.RadioButton();
            this.Sleep = new System.Windows.Forms.RadioButton();
            this.Restart = new System.Windows.Forms.RadioButton();
            this.ExecuteBTN = new System.Windows.Forms.Button();
            this.LogOff = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.TextBox();
            this.Minuts5 = new System.Windows.Forms.RadioButton();
            this.Minuts10 = new System.Windows.Forms.RadioButton();
            this.Minuts15 = new System.Windows.Forms.RadioButton();
            this.Minuts30 = new System.Windows.Forms.RadioButton();
            this.Minuts45 = new System.Windows.Forms.RadioButton();
            this.Minuts60 = new System.Windows.Forms.RadioButton();
            this.Minuts0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoursTXT
            // 
            this.HoursTXT.Location = new System.Drawing.Point(13, 13);
            this.HoursTXT.Name = "HoursTXT";
            this.HoursTXT.ReadOnly = true;
            this.HoursTXT.Size = new System.Drawing.Size(100, 20);
            this.HoursTXT.TabIndex = 0;
            this.HoursTXT.Text = "Hours";
            this.HoursTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hours
            // 
            this.Hours.FormattingEnabled = true;
            this.Hours.Location = new System.Drawing.Point(13, 40);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(100, 459);
            this.Hours.TabIndex = 1;
            // 
            // MinutsTXT
            // 
            this.MinutsTXT.Location = new System.Drawing.Point(120, 12);
            this.MinutsTXT.Name = "MinutsTXT";
            this.MinutsTXT.ReadOnly = true;
            this.MinutsTXT.Size = new System.Drawing.Size(100, 20);
            this.MinutsTXT.TabIndex = 2;
            this.MinutsTXT.Text = "Minuts";
            this.MinutsTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minuts
            // 
            this.Minuts.FormattingEnabled = true;
            this.Minuts.Location = new System.Drawing.Point(120, 40);
            this.Minuts.Name = "Minuts";
            this.Minuts.Size = new System.Drawing.Size(100, 459);
            this.Minuts.TabIndex = 3;
            // 
            // SecondsTXT
            // 
            this.SecondsTXT.Location = new System.Drawing.Point(227, 12);
            this.SecondsTXT.Name = "SecondsTXT";
            this.SecondsTXT.ReadOnly = true;
            this.SecondsTXT.Size = new System.Drawing.Size(100, 20);
            this.SecondsTXT.TabIndex = 4;
            this.SecondsTXT.Text = "Seconds";
            this.SecondsTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Seconds
            // 
            this.Seconds.FormattingEnabled = true;
            this.Seconds.Location = new System.Drawing.Point(227, 40);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(100, 459);
            this.Seconds.TabIndex = 5;
            // 
            // Off
            // 
            this.Off.AutoSize = true;
            this.Off.Location = new System.Drawing.Point(433, 15);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(62, 17);
            this.Off.TabIndex = 6;
            this.Off.Text = "Turn off";
            this.Off.UseVisualStyleBackColor = true;
            // 
            // Sleep
            // 
            this.Sleep.AutoSize = true;
            this.Sleep.Location = new System.Drawing.Point(433, 40);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(53, 17);
            this.Sleep.TabIndex = 7;
            this.Sleep.Text = "Steep";
            this.Sleep.UseVisualStyleBackColor = true;
            this.Sleep.CheckedChanged += new System.EventHandler(this.Sleep_CheckedChanged);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Location = new System.Drawing.Point(433, 64);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(59, 17);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            // 
            // ExecuteBTN
            // 
            this.ExecuteBTN.Location = new System.Drawing.Point(433, 111);
            this.ExecuteBTN.Name = "ExecuteBTN";
            this.ExecuteBTN.Size = new System.Drawing.Size(75, 23);
            this.ExecuteBTN.TabIndex = 9;
            this.ExecuteBTN.Text = "Do it";
            this.ExecuteBTN.UseVisualStyleBackColor = true;
            this.ExecuteBTN.Click += new System.EventHandler(this.ExecuteBTN_Click);
            // 
            // LogOff
            // 
            this.LogOff.AutoSize = true;
            this.LogOff.Location = new System.Drawing.Point(433, 88);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(58, 17);
            this.LogOff.TabIndex = 10;
            this.LogOff.Text = "Log off";
            this.LogOff.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(433, 141);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(333, 12);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Size = new System.Drawing.Size(90, 122);
            this.Notes.TabIndex = 13;
            // 
            // Minuts5
            // 
            this.Minuts5.AutoSize = true;
            this.Minuts5.Location = new System.Drawing.Point(6, 42);
            this.Minuts5.Name = "Minuts5";
            this.Minuts5.Size = new System.Drawing.Size(65, 17);
            this.Minuts5.TabIndex = 14;
            this.Minuts5.Text = "5 Minuts";
            this.Minuts5.UseVisualStyleBackColor = true;
            // 
            // Minuts10
            // 
            this.Minuts10.AutoSize = true;
            this.Minuts10.Location = new System.Drawing.Point(6, 67);
            this.Minuts10.Name = "Minuts10";
            this.Minuts10.Size = new System.Drawing.Size(71, 17);
            this.Minuts10.TabIndex = 15;
            this.Minuts10.Text = "10 Minuts";
            this.Minuts10.UseVisualStyleBackColor = true;
            // 
            // Minuts15
            // 
            this.Minuts15.AutoSize = true;
            this.Minuts15.Location = new System.Drawing.Point(6, 91);
            this.Minuts15.Name = "Minuts15";
            this.Minuts15.Size = new System.Drawing.Size(71, 17);
            this.Minuts15.TabIndex = 16;
            this.Minuts15.Text = "15 Minuts";
            this.Minuts15.UseVisualStyleBackColor = true;
            // 
            // Minuts30
            // 
            this.Minuts30.AutoSize = true;
            this.Minuts30.Location = new System.Drawing.Point(6, 115);
            this.Minuts30.Name = "Minuts30";
            this.Minuts30.Size = new System.Drawing.Size(71, 17);
            this.Minuts30.TabIndex = 17;
            this.Minuts30.Text = "30 Minuts";
            this.Minuts30.UseVisualStyleBackColor = true;
            // 
            // Minuts45
            // 
            this.Minuts45.AutoSize = true;
            this.Minuts45.Location = new System.Drawing.Point(6, 139);
            this.Minuts45.Name = "Minuts45";
            this.Minuts45.Size = new System.Drawing.Size(71, 17);
            this.Minuts45.TabIndex = 18;
            this.Minuts45.Text = "45 Minuts";
            this.Minuts45.UseVisualStyleBackColor = true;
            // 
            // Minuts60
            // 
            this.Minuts60.AutoSize = true;
            this.Minuts60.Location = new System.Drawing.Point(6, 163);
            this.Minuts60.Name = "Minuts60";
            this.Minuts60.Size = new System.Drawing.Size(71, 17);
            this.Minuts60.TabIndex = 19;
            this.Minuts60.Text = "60 Minuts";
            this.Minuts60.UseVisualStyleBackColor = true;
            // 
            // Minuts0
            // 
            this.Minuts0.AutoSize = true;
            this.Minuts0.Location = new System.Drawing.Point(6, 19);
            this.Minuts0.Name = "Minuts0";
            this.Minuts0.Size = new System.Drawing.Size(65, 17);
            this.Minuts0.TabIndex = 20;
            this.Minuts0.Text = "0 Minuts";
            this.Minuts0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Minuts0);
            this.groupBox1.Controls.Add(this.Minuts5);
            this.groupBox1.Controls.Add(this.Minuts60);
            this.groupBox1.Controls.Add(this.Minuts10);
            this.groupBox1.Controls.Add(this.Minuts45);
            this.groupBox1.Controls.Add(this.Minuts15);
            this.groupBox1.Controls.Add(this.Minuts30);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(333, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 329);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // TimingOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.ExecuteBTN);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.SecondsTXT);
            this.Controls.Add(this.Minuts);
            this.Controls.Add(this.MinutsTXT);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.HoursTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimingOff";
            this.Text = "TimingOff";
            this.Load += new System.EventHandler(this.TimingOff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HoursTXT;
        private System.Windows.Forms.ListBox Hours;
        private System.Windows.Forms.TextBox MinutsTXT;
        private System.Windows.Forms.ListBox Minuts;
        private System.Windows.Forms.TextBox SecondsTXT;
        private System.Windows.Forms.ListBox Seconds;
        private System.Windows.Forms.RadioButton Off;
        private System.Windows.Forms.RadioButton Sleep;
        private System.Windows.Forms.RadioButton Restart;
        private System.Windows.Forms.Button ExecuteBTN;
        private System.Windows.Forms.RadioButton LogOff;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.RadioButton Minuts5;
        private System.Windows.Forms.RadioButton Minuts10;
        private System.Windows.Forms.RadioButton Minuts15;
        private System.Windows.Forms.RadioButton Minuts30;
        private System.Windows.Forms.RadioButton Minuts45;
        private System.Windows.Forms.RadioButton Minuts60;
        private System.Windows.Forms.RadioButton Minuts0;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

