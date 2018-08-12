namespace Material_Design_Desktop_Concept.Material.GUI
{
    partial class UIAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIAbout));
            this.LblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.LblBody = new MaterialSkin.Controls.MaterialLabel();
            this.LblFullBody = new MaterialSkin.Controls.MaterialLabel();
            this.PcxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.BackColor = System.Drawing.Color.Transparent;
            this.LblHeader.Depth = 0;
            this.LblHeader.Font = new System.Drawing.Font("Roboto", 14F);
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHeader.Location = new System.Drawing.Point(130, 88);
            this.LblHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(306, 27);
            this.LblHeader.TabIndex = 1;
            this.LblHeader.Text = "%HEADER%";
            // 
            // LblBody
            // 
            this.LblBody.BackColor = System.Drawing.Color.Transparent;
            this.LblBody.Depth = 0;
            this.LblBody.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBody.Location = new System.Drawing.Point(130, 115);
            this.LblBody.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(306, 85);
            this.LblBody.TabIndex = 2;
            this.LblBody.Text = "%BODY%";
            // 
            // LblFullBody
            // 
            this.LblFullBody.BackColor = System.Drawing.Color.Transparent;
            this.LblFullBody.Depth = 0;
            this.LblFullBody.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFullBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFullBody.Location = new System.Drawing.Point(12, 217);
            this.LblFullBody.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFullBody.Name = "LblFullBody";
            this.LblFullBody.Size = new System.Drawing.Size(424, 186);
            this.LblFullBody.TabIndex = 3;
            this.LblFullBody.Text = "%FULL%";
            // 
            // PcxLogo
            // 
            this.PcxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxLogo.BackgroundImage")));
            this.PcxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxLogo.Location = new System.Drawing.Point(12, 88);
            this.PcxLogo.Name = "PcxLogo";
            this.PcxLogo.Size = new System.Drawing.Size(112, 112);
            this.PcxLogo.TabIndex = 0;
            this.PcxLogo.TabStop = false;
            // 
            // UIAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 412);
            this.Controls.Add(this.LblFullBody);
            this.Controls.Add(this.LblBody);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.PcxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIAbout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UIAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PcxLogo;
        private MaterialSkin.Controls.MaterialLabel LblHeader;
        private MaterialSkin.Controls.MaterialLabel LblBody;
        private MaterialSkin.Controls.MaterialLabel LblFullBody;
    }
}