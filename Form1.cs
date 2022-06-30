using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportacusTest
{
    public partial class Form1 : Form
    {
        int varProd = 0;
        int Minute = 1;
        int varStop = 0;
        int varStopBack = 0;

        DateTime DateAndTime = new DateTime();
        DateTime TimeAndTime = new DateTime();
        TimeSpan Time = new TimeSpan();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdZeitnehmerstart_Click(object sender, EventArgs e)
        {
            lblErgebnisProd.ForeColor = Color.LimeGreen;
            lblErgebnisStops.ForeColor = Color.Black;

            if (ZeitgeberStop.Enabled == true)
                ZeitgeberStop.Enabled = false;

            if (varStop > 0 )
                lstStops.Items.Add(eingatxtGrund.Text + ": " + varStopBack + " min.");

            ZeitgeberProd.Enabled = true;
        }

        private void ZeitgeberProd_Tick(object sender, EventArgs e)
        {
            varProd++;
            lblZeitgeberStart.Text = varProd + " min.";
        }

        private void cmdZeitgeberStop_Click(object sender, EventArgs e)
        {
            lblErgebnisStops.ForeColor = Color.Red;
            lblErgebnisProd.ForeColor = Color.Black;

            varStopBack = 0;

            eingatxtGrund.Text = "";

            if (ZeitgeberProd.Enabled == true)
                ZeitgeberProd.Enabled = false;

            ZeitgeberStop.Enabled = true;
        }

        private void ZeitgeberStop_Tick(object sender, EventArgs e)
        {
            varStop++;

            varStopBack++;

            lblZeitgeberStop.Text = varStop + " min.";
        }

        private void GitHUB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/noahmarcello777");
        }

        private void Uhr_Tick(object sender, EventArgs e)
        {
            DateAndTime = DateTime.Now;
            lblUhrzeit.Text = DateAndTime.TimeOfDay.ToString();
            Time = DateAndTime.TimeOfDay;

            if (Time >= new TimeSpan(21, 30, 0) && Time <= new TimeSpan(23, 59, 0))
                lblSchicht.Text = "Nachtschicht";
            if (Time >= new TimeSpan(00, 00, 0) && Time <= new TimeSpan(05, 30, 0))
                lblSchicht.Text = "Nachtschicht";

            if (Time >= new TimeSpan(05, 30, 0) && Time <= new TimeSpan(13, 30, 0))
                lblSchicht.Text = "Frühschicht";

            if (Time >= new TimeSpan(13, 30, 0) && Time <= new TimeSpan(21, 30, 0))
                lblSchicht.Text = "Spätschicht";
        }
    }
}
