
namespace SportacusTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdZeitnehmerstart = new System.Windows.Forms.Button();
            this.cmdZeitgeberStop = new System.Windows.Forms.Button();
            this.ZeitgeberStop = new System.Windows.Forms.Timer(this.components);
            this.lblZeitgeberStop = new System.Windows.Forms.Label();
            this.lblZeitgeberStart = new System.Windows.Forms.Label();
            this.lblErgebnisProd = new System.Windows.Forms.Label();
            this.lblErgebnisStops = new System.Windows.Forms.Label();
            this.ZeitgeberProd = new System.Windows.Forms.Timer(this.components);
            this.lblSchicht = new System.Windows.Forms.Label();
            this.lstStops = new System.Windows.Forms.ListBox();
            this.eingatxtGrund = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GitHUB = new System.Windows.Forms.LinkLabel();
            this.Uhr = new System.Windows.Forms.Timer(this.components);
            this.lblUhrzeit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdZeitnehmerstart
            // 
            this.cmdZeitnehmerstart.Location = new System.Drawing.Point(98, 51);
            this.cmdZeitnehmerstart.Name = "cmdZeitnehmerstart";
            this.cmdZeitnehmerstart.Size = new System.Drawing.Size(75, 23);
            this.cmdZeitnehmerstart.TabIndex = 0;
            this.cmdZeitnehmerstart.Text = "Start";
            this.cmdZeitnehmerstart.UseVisualStyleBackColor = true;
            this.cmdZeitnehmerstart.Click += new System.EventHandler(this.cmdZeitnehmerstart_Click);
            // 
            // cmdZeitgeberStop
            // 
            this.cmdZeitgeberStop.Location = new System.Drawing.Point(98, 80);
            this.cmdZeitgeberStop.Name = "cmdZeitgeberStop";
            this.cmdZeitgeberStop.Size = new System.Drawing.Size(75, 23);
            this.cmdZeitgeberStop.TabIndex = 2;
            this.cmdZeitgeberStop.Text = "Stop";
            this.cmdZeitgeberStop.UseVisualStyleBackColor = true;
            this.cmdZeitgeberStop.Click += new System.EventHandler(this.cmdZeitgeberStop_Click);
            // 
            // ZeitgeberStop
            // 
            this.ZeitgeberStop.Interval = 60000;
            this.ZeitgeberStop.Tick += new System.EventHandler(this.ZeitgeberStop_Tick);
            // 
            // lblZeitgeberStop
            // 
            this.lblZeitgeberStop.AutoSize = true;
            this.lblZeitgeberStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeitgeberStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeitgeberStop.ForeColor = System.Drawing.Color.DarkRed;
            this.lblZeitgeberStop.Location = new System.Drawing.Point(93, 33);
            this.lblZeitgeberStop.MaximumSize = new System.Drawing.Size(85, 15);
            this.lblZeitgeberStop.MinimumSize = new System.Drawing.Size(85, 15);
            this.lblZeitgeberStop.Name = "lblZeitgeberStop";
            this.lblZeitgeberStop.Size = new System.Drawing.Size(85, 15);
            this.lblZeitgeberStop.TabIndex = 5;
            this.lblZeitgeberStop.Text = "                   ";
            // 
            // lblZeitgeberStart
            // 
            this.lblZeitgeberStart.AutoSize = true;
            this.lblZeitgeberStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeitgeberStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeitgeberStart.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblZeitgeberStart.Location = new System.Drawing.Point(93, 9);
            this.lblZeitgeberStart.MaximumSize = new System.Drawing.Size(85, 15);
            this.lblZeitgeberStart.MinimumSize = new System.Drawing.Size(85, 15);
            this.lblZeitgeberStart.Name = "lblZeitgeberStart";
            this.lblZeitgeberStart.Size = new System.Drawing.Size(85, 15);
            this.lblZeitgeberStart.TabIndex = 6;
            this.lblZeitgeberStart.Text = "                   ";
            // 
            // lblErgebnisProd
            // 
            this.lblErgebnisProd.AutoSize = true;
            this.lblErgebnisProd.Location = new System.Drawing.Point(26, 9);
            this.lblErgebnisProd.Name = "lblErgebnisProd";
            this.lblErgebnisProd.Size = new System.Drawing.Size(61, 13);
            this.lblErgebnisProd.TabIndex = 7;
            this.lblErgebnisProd.Text = "Produktion:";
            // 
            // lblErgebnisStops
            // 
            this.lblErgebnisStops.AutoSize = true;
            this.lblErgebnisStops.Location = new System.Drawing.Point(6, 33);
            this.lblErgebnisStops.Name = "lblErgebnisStops";
            this.lblErgebnisStops.Size = new System.Drawing.Size(81, 13);
            this.lblErgebnisStops.TabIndex = 8;
            this.lblErgebnisStops.Text = "Unterbrechung:";
            // 
            // ZeitgeberProd
            // 
            this.ZeitgeberProd.Interval = 60000;
            this.ZeitgeberProd.Tick += new System.EventHandler(this.ZeitgeberProd_Tick);
            // 
            // lblSchicht
            // 
            this.lblSchicht.AutoSize = true;
            this.lblSchicht.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSchicht.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSchicht.Location = new System.Drawing.Point(418, 9);
            this.lblSchicht.MaximumSize = new System.Drawing.Size(69, 15);
            this.lblSchicht.MinimumSize = new System.Drawing.Size(69, 15);
            this.lblSchicht.Name = "lblSchicht";
            this.lblSchicht.Size = new System.Drawing.Size(69, 15);
            this.lblSchicht.TabIndex = 9;
            this.lblSchicht.Text = ">>Schicht<<";
            // 
            // lstStops
            // 
            this.lstStops.FormattingEnabled = true;
            this.lstStops.HorizontalScrollbar = true;
            this.lstStops.Location = new System.Drawing.Point(184, 9);
            this.lstStops.Name = "lstStops";
            this.lstStops.ScrollAlwaysVisible = true;
            this.lstStops.Size = new System.Drawing.Size(228, 95);
            this.lstStops.TabIndex = 10;
            // 
            // eingatxtGrund
            // 
            this.eingatxtGrund.Location = new System.Drawing.Point(9, 110);
            this.eingatxtGrund.Name = "eingatxtGrund";
            this.eingatxtGrund.Size = new System.Drawing.Size(403, 20);
            this.eingatxtGrund.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Grund:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 7);
            this.label2.TabIndex = 13;
            this.label2.Text = "by Noah-Marcello Hohnholz";
            // 
            // GitHUB
            // 
            this.GitHUB.AutoSize = true;
            this.GitHUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHUB.Location = new System.Drawing.Point(12, 144);
            this.GitHUB.Name = "GitHUB";
            this.GitHUB.Size = new System.Drawing.Size(26, 7);
            this.GitHUB.TabIndex = 14;
            this.GitHUB.TabStop = true;
            this.GitHUB.Text = "GitHub";
            this.GitHUB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHUB_LinkClicked);
            // 
            // Uhr
            // 
            this.Uhr.Enabled = true;
            this.Uhr.Tick += new System.EventHandler(this.Uhr_Tick);
            // 
            // lblUhrzeit
            // 
            this.lblUhrzeit.AutoSize = true;
            this.lblUhrzeit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUhrzeit.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUhrzeit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblUhrzeit.Location = new System.Drawing.Point(149, 137);
            this.lblUhrzeit.Name = "lblUhrzeit";
            this.lblUhrzeit.Size = new System.Drawing.Size(43, 18);
            this.lblUhrzeit.TabIndex = 15;
            this.lblUhrzeit.Text = "Uhrzeit";
            this.lblUhrzeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 160);
            this.Controls.Add(this.lblUhrzeit);
            this.Controls.Add(this.GitHUB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eingatxtGrund);
            this.Controls.Add(this.lstStops);
            this.Controls.Add(this.lblSchicht);
            this.Controls.Add(this.lblErgebnisStops);
            this.Controls.Add(this.lblErgebnisProd);
            this.Controls.Add(this.lblZeitgeberStart);
            this.Controls.Add(this.lblZeitgeberStop);
            this.Controls.Add(this.cmdZeitgeberStop);
            this.Controls.Add(this.cmdZeitnehmerstart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ajalon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdZeitnehmerstart;
        private System.Windows.Forms.Button cmdZeitgeberStop;
        private System.Windows.Forms.Timer ZeitgeberStop;
        private System.Windows.Forms.Label lblZeitgeberStop;
        private System.Windows.Forms.Label lblZeitgeberStart;
        private System.Windows.Forms.Label lblErgebnisProd;
        private System.Windows.Forms.Label lblErgebnisStops;
        private System.Windows.Forms.Timer ZeitgeberProd;
        private System.Windows.Forms.Label lblSchicht;
        private System.Windows.Forms.ListBox lstStops;
        private System.Windows.Forms.TextBox eingatxtGrund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel GitHUB;
        private System.Windows.Forms.Timer Uhr;
        private System.Windows.Forms.Label lblUhrzeit;
    }
}

