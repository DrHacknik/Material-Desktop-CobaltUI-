namespace Material_Design_Desktop_Concept.Material.GUI
{
    partial class UILogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILogin));
            this.TmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.TmrCheckEnter = new System.Windows.Forms.Timer(this.components);
            this.TmrTIme = new System.Windows.Forms.Timer(this.components);
            this.LblUserPass = new System.Windows.Forms.Label();
            this.PcxUser = new System.Windows.Forms.PictureBox();
            this.PnlTrayLoginTime = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblGoogle = new System.Windows.Forms.Label();
            this.PcxBackground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PcxUser)).BeginInit();
            this.PnlTrayLoginTime.SuspendLayout();
            this.PcxBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmrFadeOut
            // 
            this.TmrFadeOut.Interval = 5;
            this.TmrFadeOut.Tick += new System.EventHandler(this.TmrFadeOut_Tick);
            // 
            // TmrCheckEnter
            // 
            this.TmrCheckEnter.Enabled = true;
            this.TmrCheckEnter.Interval = 1;
            this.TmrCheckEnter.Tick += new System.EventHandler(this.TmrCheckEnter_Tick);
            // 
            // TmrTIme
            // 
            this.TmrTIme.Enabled = true;
            this.TmrTIme.Interval = 1;
            this.TmrTIme.Tick += new System.EventHandler(this.TmrTIme_Tick);
            // 
            // LblUserPass
            // 
            this.LblUserPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserPass.BackColor = System.Drawing.Color.Transparent;
            this.LblUserPass.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.LblUserPass.ForeColor = System.Drawing.Color.White;
            this.LblUserPass.Location = new System.Drawing.Point(506, 365);
            this.LblUserPass.Name = "LblUserPass";
            this.LblUserPass.Size = new System.Drawing.Size(277, 33);
            this.LblUserPass.TabIndex = 3;
            this.LblUserPass.Text = "%PASS%";
            this.LblUserPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUserPass.Click += new System.EventHandler(this.LblUserPass_Click);
            // 
            // PcxUser
            // 
            this.PcxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PcxUser.BackColor = System.Drawing.Color.Transparent;
            this.PcxUser.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.if_account_circle_326497_White;
            this.PcxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxUser.Location = new System.Drawing.Point(578, 239);
            this.PcxUser.Name = "PcxUser";
            this.PcxUser.Size = new System.Drawing.Size(128, 128);
            this.PcxUser.TabIndex = 4;
            this.PcxUser.TabStop = false;
            // 
            // PnlTrayLoginTime
            // 
            this.PnlTrayLoginTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayLoginTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayLoginTime.BackgroundImage")));
            this.PnlTrayLoginTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlTrayLoginTime.Controls.Add(this.LblTime);
            this.PnlTrayLoginTime.Location = new System.Drawing.Point(1159, 657);
            this.PnlTrayLoginTime.Name = "PnlTrayLoginTime";
            this.PnlTrayLoginTime.Size = new System.Drawing.Size(109, 51);
            this.PnlTrayLoginTime.TabIndex = 5;
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTime.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.LblTime.ForeColor = System.Drawing.Color.White;
            this.LblTime.Location = new System.Drawing.Point(3, 7);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(103, 37);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "1:19 PM";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGoogle
            // 
            this.LblGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblGoogle.BackColor = System.Drawing.Color.Transparent;
            this.LblGoogle.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.LblGoogle.ForeColor = System.Drawing.Color.White;
            this.LblGoogle.Location = new System.Drawing.Point(12, 675);
            this.LblGoogle.Name = "LblGoogle";
            this.LblGoogle.Size = new System.Drawing.Size(117, 33);
            this.LblGoogle.TabIndex = 6;
            this.LblGoogle.Text = "Sign in with Google";
            this.LblGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblGoogle.Click += new System.EventHandler(this.LblGoogle_Click);
            // 
            // PcxBackground
            // 
            this.PcxBackground.BackColor = System.Drawing.Color.Transparent;
            this.PcxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxBackground.BackgroundImage")));
            this.PcxBackground.Controls.Add(this.LblGoogle);
            this.PcxBackground.Controls.Add(this.PnlTrayLoginTime);
            this.PcxBackground.Controls.Add(this.PcxUser);
            this.PcxBackground.Controls.Add(this.LblUserPass);
            this.PcxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PcxBackground.Location = new System.Drawing.Point(0, 0);
            this.PcxBackground.Name = "PcxBackground";
            this.PcxBackground.Size = new System.Drawing.Size(1280, 720);
            this.PcxBackground.TabIndex = 3;
            this.PcxBackground.Click += new System.EventHandler(this.PcxBackground_Click);
            // 
            // UILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PcxBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UILogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UILogin";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UILogin_Load);
            this.Click += new System.EventHandler(this.UILogin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PcxUser)).EndInit();
            this.PnlTrayLoginTime.ResumeLayout(false);
            this.PcxBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmrFadeOut;
        private System.Windows.Forms.Timer TmrCheckEnter;
        private System.Windows.Forms.Timer TmrTIme;
        private System.Windows.Forms.Label LblUserPass;
        private System.Windows.Forms.PictureBox PcxUser;
        private System.Windows.Forms.Panel PnlTrayLoginTime;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblGoogle;
        private System.Windows.Forms.Panel PcxBackground;
    }
}