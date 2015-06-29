using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimingOff
{
    public partial class TimingOff : Form
    {
        int TimeToOff = 0;
        bool ActionChosen = false;
        bool DefaultChecked = false;
        string ActionName = "";

        public TimingOff()
        {
            InitializeComponent();
        }

        private void TimingOff_Load(object sender, EventArgs e)
        {
            Notes.Text = "Notes:                                            1. Sleep cannot be canceled.                                   2. Default times has the priority.";
            #region Default time lists values
            Hours.SelectedItem = 0;
            Minuts.SelectedItem = 0;
            Seconds.SelectedItem = 0;
            #endregion

            #region Adds hours to the list of hours 1-12.
            for (int i = 0; i < 13; i++)
            {
                Hours.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                Minuts.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                Seconds.Items.Add(i);
            }
            #endregion

        }




        private void ExecuteBTN_Click(object sender, EventArgs e)
        {

            if (Minuts0.Checked)
            {
                DefaultChecked = true;
            }
            else if (Minuts5.Checked)
            {
                DefaultChecked = true;
                TimeToOff = 5 * 60;
            }
            else if (Minuts10.Checked)
            {
                DefaultChecked = true;
                TimeToOff = 10 * 60;
            }
            else if (Minuts15.Checked)
            {
                DefaultChecked = true;
                TimeToOff = 15 * 60;
            }
            else if (Minuts30.Checked)
            {
                DefaultChecked = true;
                TimeToOff = 30 * 60;
            }
            else if (Minuts45.Checked)
            {
                DefaultChecked = true;
                TimeToOff = 45 * 60;
            }
            else if (Minuts60.Checked)
            {
                DefaultChecked = true;
                TimeToOff = 60 * 60;
            }

            if (!DefaultChecked)
            {
                #region Calculats the requested time to action
                TimeToOff += (Convert.ToInt32(Hours.SelectedItem) * 60 * 60)
                    + (Convert.ToInt32(Minuts.SelectedItem) * 60)
                    + (Convert.ToInt32(Seconds.SelectedItem));
                #endregion
            }
            ProcessStartInfo procInfo = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe");


            DialogResult dialogResult = DialogResult.No;

            procInfo.Arguments += @"/c @echo off && ";







            #region Chooses action
            if (Off.Checked)
            {
                procInfo.Arguments += @"shutdown -s -t " + TimeToOff;
                ActionChosen = true;
                ActionName = "Turn off";
            }
            else if (Sleep.Checked)
            {
                procInfo.Arguments += @"timeout -t " + TimeToOff + " && echo do not close this window";
                procInfo.Arguments += @"rundll32.exe powrprof.dll,SetSuspendState 0,1,0";
                ActionChosen = true;
                ActionName = "Sleep";
            }
            else if (LogOff.Checked)
            {
                procInfo.Arguments += @"shutdown -l -t " + TimeToOff;
                ActionChosen = true;
                ActionName = "Log off";
            }
            else if (Restart.Checked)
            {
                procInfo.Arguments += @"shutdown -r -t " + TimeToOff;
                ActionChosen = true;
                ActionName = "Restart";
            }
            #endregion

            if (!ActionChosen)
            {
                MessageBox.Show("You need to choose an action");
            }
            else
            {
                int seconds = TimeToOff % 60;
                int minuts = (TimeToOff / 60) % 60;
                int hours = TimeToOff / 3600;


                dialogResult = MessageBox.Show("Are you sure that you want to " + ActionName + "?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    MessageBox.Show("The computer will " + ActionName + " in " + hours + " Hours " + minuts + " minuts and " + seconds + " seconds");
            }

            if (dialogResult == DialogResult.Yes)
            {
                #region Execute action
                Process proc = new Process();
                procInfo.UseShellExecute = false;
                proc.StartInfo = procInfo;
                proc.Start();
                #endregion
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            ProcessStartInfo procInfo = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe");
            procInfo.Arguments += @"/c shutdown -a";
            proc.StartInfo = procInfo;
            proc.Start();

            if (ActionChosen)
                MessageBox.Show("Action aborted successfully");
            else
                MessageBox.Show("No action has been activated");
        }

        private void Sleep_CheckedChanged(object sender, EventArgs e)
        {
            if (Sleep.Checked)
            {
                DialogResult dr = MessageBox.Show("WARNING: \nSleep mode CANNOT be canceled.\nAre you sure that you want to sleep?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    Sleep.Checked = false;
            }
        }
    }
}
