using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HenGioTatMayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStatusBar();
        }
        StatusBarPanel downTimePanel = new StatusBarPanel();
        StatusBarPanel barPanel = new StatusBarPanel();

        decimal downTime = 0;
        void LoadStatusBar()
        {
            StatusBar statusbar = new StatusBar();
            statusbar.ShowPanels = true;
            statusbar.Panels.Add(barPanel);
            statusbar.Panels.Add(downTimePanel);

            barPanel.Text = "Waiting...";
            downTimePanel.Text = "";

            this.Controls.Add(statusbar);
        }
        void calculateDownTime()
        {
            downTime = (nmHour.Value * 60 * 60) + nmSecond.Value + nmMinutes.Value * 60;
        }
        private void nmSecond_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown temp = sender as NumericUpDown;
            if (temp.Value >= 60)
            {
                nmMinutes.Value++;
                temp.Value = 0;
            }
        }

        private void nmMinutes_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown temp = sender as NumericUpDown;
            if (temp.Value >= 60)
            {
                nmHour.Value++;
                temp.Value = 0;
            }
        }

        private void nmHour_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown temp = sender as NumericUpDown;
            if (temp.Value >= 24)
            {
                nmSecond.Value = 0;
                nmMinutes.Value = 0;
                temp.Value = 0;
            }
        }
        void shutdown (string command)
        {
            System.Diagnostics.Process.Start("shutdown", command);
        }
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            shutdown("-s -t" + downTime);
            barPanel.Text = "Shutting down...";
            timer1.Start();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            shutdown("-r -t" + downTime);
            barPanel.Text = "Restarting...";
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            shutdown("-a");
            barPanel.Text = "Waiting...";
            downTimePanel.Text = "";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            downTime--;
            downTimePanel.Text = downTime.ToString();
        }
    }
}
