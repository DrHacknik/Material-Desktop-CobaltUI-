namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class _UILoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_UILoader));
            this.TmrDelayStartup = new System.Windows.Forms.Timer(this.components);
            this.TmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TmrDelayStartup
            // 
            this.TmrDelayStartup.Enabled = true;
            this.TmrDelayStartup.Interval = 5000;
            this.TmrDelayStartup.Tick += new System.EventHandler(this.TmrDelayStartup_Tick);
            // 
            // TmrFadeOut
            // 
            this.TmrFadeOut.Interval = 5;
            this.TmrFadeOut.Tick += new System.EventHandler(this.TmrFadeOut_Tick);
            // 
            // _UILoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_UILoader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UILoader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UILoader_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TmrDelayStartup;
        private System.Windows.Forms.Timer TmrFadeOut;
    }
}