namespace Material_Design_Desktop_Concept.Material.GUI
{
    partial class UIPrereq
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
            this.LblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.PrgMain = new MaterialSkin.Controls.MaterialProgressBar();
            this.TmCompl = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.Transparent;
            this.LblHeader.Depth = 0;
            this.LblHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHeader.Location = new System.Drawing.Point(0, 65);
            this.LblHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(386, 143);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Please wait, we are setting things up...\r\n\r\nDo keep in mind this is for debugging" +
    " purposes.";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrgMain
            // 
            this.PrgMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrgMain.Depth = 0;
            this.PrgMain.Location = new System.Drawing.Point(12, 191);
            this.PrgMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrgMain.Name = "PrgMain";
            this.PrgMain.Size = new System.Drawing.Size(362, 5);
            this.PrgMain.TabIndex = 1;
            // 
            // TmCompl
            // 
            this.TmCompl.Interval = 3500;
            this.TmCompl.Tick += new System.EventHandler(this.TmCompl_Tick);
            // 
            // UIPrereq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 208);
            this.ControlBox = false;
            this.Controls.Add(this.PrgMain);
            this.Controls.Add(this.LblHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIPrereq";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIPrereq";
            this.Load += new System.EventHandler(this.UIPrereq_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblHeader;
        private MaterialSkin.Controls.MaterialProgressBar PrgMain;
        private System.Windows.Forms.Timer TmCompl;
    }
}