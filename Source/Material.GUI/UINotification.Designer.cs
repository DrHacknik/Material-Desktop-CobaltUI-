namespace Material_Design_Desktop_Concept.Material.GUI
{
    partial class UINotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UINotification));
            this.PcxLogo = new System.Windows.Forms.PictureBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblBody = new System.Windows.Forms.Label();
            this.TmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.TmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.TmrNotify = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PcxLogo
            // 
            this.PcxLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PcxLogo, "PcxLogo");
            this.PcxLogo.Name = "PcxLogo";
            this.PcxLogo.TabStop = false;
            this.PcxLogo.MouseHover += new System.EventHandler(this.PcxLogo_MouseHover);
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblHeader, "LblHeader");
            this.LblHeader.ForeColor = System.Drawing.Color.White;
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.MouseHover += new System.EventHandler(this.LblHeader_MouseHover);
            // 
            // LblBody
            // 
            this.LblBody.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblBody, "LblBody");
            this.LblBody.ForeColor = System.Drawing.Color.White;
            this.LblBody.Name = "LblBody";
            this.LblBody.MouseHover += new System.EventHandler(this.LblBody_MouseHover);
            // 
            // TmrFadeIn
            // 
            this.TmrFadeIn.Interval = 15;
            this.TmrFadeIn.Tick += new System.EventHandler(this.TmrFadeIn_Tick);
            // 
            // TmrFadeOut
            // 
            this.TmrFadeOut.Interval = 35;
            this.TmrFadeOut.Tick += new System.EventHandler(this.TmrFadeOut_Tick);
            // 
            // TmrNotify
            // 
            this.TmrNotify.Enabled = true;
            this.TmrNotify.Interval = 6500;
            this.TmrNotify.Tick += new System.EventHandler(this.TmrNotify_Tick);
            // 
            // UINotification
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ControlBox = false;
            this.Controls.Add(this.LblBody);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.PcxLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UINotification";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UINotification_Load);
            this.MouseLeave += new System.EventHandler(this.UINotification_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UINotification_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.PcxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TmrFadeIn;
        private System.Windows.Forms.Timer TmrFadeOut;
        private System.Windows.Forms.Timer TmrNotify;
        public System.Windows.Forms.Label LblHeader;
        public System.Windows.Forms.Label LblBody;
        public System.Windows.Forms.PictureBox PcxLogo;
    }
}