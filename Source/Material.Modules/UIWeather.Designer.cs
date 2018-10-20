namespace Material_Design_Desktop_Concept.Material.Modules
{
    partial class UIWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIWeather));
            this.PnlSplash = new System.Windows.Forms.Panel();
            this.PcxLogo = new System.Windows.Forms.PictureBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblBody = new System.Windows.Forms.Label();
            this.BtnRefresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnChange = new MaterialSkin.Controls.MaterialFlatButton();
            this.PrgWait = new MaterialSkin.Controls.MaterialProgressBar();
            this.LblFooter = new System.Windows.Forms.Label();
            this.PnlSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSplash
            // 
            this.PnlSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlSplash.BackgroundImage")));
            this.PnlSplash.Controls.Add(this.LblFooter);
            this.PnlSplash.Controls.Add(this.PrgWait);
            this.PnlSplash.Controls.Add(this.BtnChange);
            this.PnlSplash.Controls.Add(this.BtnRefresh);
            this.PnlSplash.Controls.Add(this.LblBody);
            this.PnlSplash.Controls.Add(this.LblHeader);
            this.PnlSplash.Controls.Add(this.PcxLogo);
            this.PnlSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlSplash.Location = new System.Drawing.Point(0, 64);
            this.PnlSplash.Name = "PnlSplash";
            this.PnlSplash.Size = new System.Drawing.Size(813, 558);
            this.PnlSplash.TabIndex = 0;
            // 
            // PcxLogo
            // 
            this.PcxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxLogo.BackgroundImage")));
            this.PcxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxLogo.Location = new System.Drawing.Point(12, 16);
            this.PcxLogo.Name = "PcxLogo";
            this.PcxLogo.Size = new System.Drawing.Size(151, 138);
            this.PcxLogo.TabIndex = 2;
            this.PcxLogo.TabStop = false;
            this.PcxLogo.Visible = false;
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.Transparent;
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI Light", 19.25F);
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Location = new System.Drawing.Point(169, 19);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(357, 48);
            this.LblHeader.TabIndex = 3;
            this.LblHeader.Text = "Current weather for: NULL";
            this.LblHeader.Visible = false;
            // 
            // LblBody
            // 
            this.LblBody.BackColor = System.Drawing.Color.Transparent;
            this.LblBody.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            this.LblBody.ForeColor = System.Drawing.Color.White;
            this.LblBody.Location = new System.Drawing.Point(169, 67);
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(357, 172);
            this.LblBody.TabIndex = 4;
            this.LblBody.Text = "Temp: NULL\r\nCondition: NULL\r\n\r\nHigh: NULL\r\nLow: NULL\r\n\r\n";
            this.LblBody.Visible = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Depth = 0;
            this.BtnRefresh.Icon = null;
            this.BtnRefresh.Location = new System.Drawing.Point(730, 516);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Primary = false;
            this.BtnRefresh.Size = new System.Drawing.Size(79, 36);
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Visible = false;
            // 
            // BtnChange
            // 
            this.BtnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChange.AutoSize = true;
            this.BtnChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnChange.BackColor = System.Drawing.Color.Transparent;
            this.BtnChange.Depth = 0;
            this.BtnChange.Icon = null;
            this.BtnChange.Location = new System.Drawing.Point(576, 516);
            this.BtnChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Primary = false;
            this.BtnChange.Size = new System.Drawing.Size(146, 36);
            this.BtnChange.TabIndex = 6;
            this.BtnChange.Text = "Change location";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Visible = false;
            // 
            // PrgWait
            // 
            this.PrgWait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrgWait.Depth = 0;
            this.PrgWait.Location = new System.Drawing.Point(212, 525);
            this.PrgWait.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrgWait.Name = "PrgWait";
            this.PrgWait.Size = new System.Drawing.Size(389, 5);
            this.PrgWait.Step = 15;
            this.PrgWait.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PrgWait.TabIndex = 7;
            this.PrgWait.Value = 10;
            // 
            // LblFooter
            // 
            this.LblFooter.BackColor = System.Drawing.Color.Transparent;
            this.LblFooter.Font = new System.Drawing.Font("Segoe UI Light", 16.25F);
            this.LblFooter.ForeColor = System.Drawing.Color.White;
            this.LblFooter.Location = new System.Drawing.Point(212, 474);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(389, 48);
            this.LblFooter.TabIndex = 8;
            this.LblFooter.Text = "Please wait...";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 622);
            this.Controls.Add(this.PnlSplash);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIWeather";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIWeather";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UIWeather_Load);
            this.PnlSplash.ResumeLayout(false);
            this.PnlSplash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSplash;
        private System.Windows.Forms.PictureBox PcxLogo;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblBody;
        private MaterialSkin.Controls.MaterialFlatButton BtnRefresh;
        private MaterialSkin.Controls.MaterialFlatButton BtnChange;
        private MaterialSkin.Controls.MaterialProgressBar PrgWait;
        private System.Windows.Forms.Label LblFooter;
    }
}