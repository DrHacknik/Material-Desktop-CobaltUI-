namespace Material_Design_Desktop_Concept.Material.GUI
{
    partial class UIManualLoad
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
            this.BtnStartModule = new MaterialSkin.Controls.MaterialFlatButton();
            this.TxtModule = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MtForceOath = new MaterialSkin.Controls.MaterialCheckBox();
            this.MtEmulateNet = new MaterialSkin.Controls.MaterialCheckBox();
            this.MtDisableUpdate = new MaterialSkin.Controls.MaterialCheckBox();
            this.MtForceAllBackground = new MaterialSkin.Controls.MaterialCheckBox();
            this.MtReset = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // BtnStartModule
            // 
            this.BtnStartModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStartModule.AutoSize = true;
            this.BtnStartModule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStartModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnStartModule.Depth = 0;
            this.BtnStartModule.Icon = null;
            this.BtnStartModule.Location = new System.Drawing.Point(209, 316);
            this.BtnStartModule.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnStartModule.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnStartModule.Name = "BtnStartModule";
            this.BtnStartModule.Primary = false;
            this.BtnStartModule.Size = new System.Drawing.Size(122, 36);
            this.BtnStartModule.TabIndex = 0;
            this.BtnStartModule.Text = "Start Module";
            this.BtnStartModule.UseVisualStyleBackColor = false;
            this.BtnStartModule.Click += new System.EventHandler(this.BtnStartModule_Click);
            // 
            // TxtModule
            // 
            this.TxtModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TxtModule.Depth = 0;
            this.TxtModule.Hint = "Type the module name here";
            this.TxtModule.Location = new System.Drawing.Point(12, 100);
            this.TxtModule.MaxLength = 32;
            this.TxtModule.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtModule.Name = "TxtModule";
            this.TxtModule.PasswordChar = '\0';
            this.TxtModule.SelectedText = "";
            this.TxtModule.SelectionLength = 0;
            this.TxtModule.SelectionStart = 0;
            this.TxtModule.Size = new System.Drawing.Size(319, 23);
            this.TxtModule.TabIndex = 1;
            this.TxtModule.TabStop = false;
            this.TxtModule.UseSystemPasswordChar = false;
            // 
            // MtForceOath
            // 
            this.MtForceOath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MtForceOath.AutoSize = true;
            this.MtForceOath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MtForceOath.Depth = 0;
            this.MtForceOath.Font = new System.Drawing.Font("Roboto", 10F);
            this.MtForceOath.Location = new System.Drawing.Point(12, 142);
            this.MtForceOath.Margin = new System.Windows.Forms.Padding(0);
            this.MtForceOath.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MtForceOath.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtForceOath.Name = "MtForceOath";
            this.MtForceOath.Ripple = true;
            this.MtForceOath.Size = new System.Drawing.Size(165, 30);
            this.MtForceOath.TabIndex = 2;
            this.MtForceOath.Text = "Force WebView OATH";
            this.MtForceOath.UseVisualStyleBackColor = false;
            // 
            // MtEmulateNet
            // 
            this.MtEmulateNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MtEmulateNet.AutoSize = true;
            this.MtEmulateNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MtEmulateNet.Depth = 0;
            this.MtEmulateNet.Font = new System.Drawing.Font("Roboto", 10F);
            this.MtEmulateNet.Location = new System.Drawing.Point(12, 181);
            this.MtEmulateNet.Margin = new System.Windows.Forms.Padding(0);
            this.MtEmulateNet.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MtEmulateNet.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtEmulateNet.Name = "MtEmulateNet";
            this.MtEmulateNet.Ripple = true;
            this.MtEmulateNet.Size = new System.Drawing.Size(230, 30);
            this.MtEmulateNet.TabIndex = 3;
            this.MtEmulateNet.Text = "Emulate Network Status (Online)";
            this.MtEmulateNet.UseVisualStyleBackColor = false;
            // 
            // MtDisableUpdate
            // 
            this.MtDisableUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MtDisableUpdate.AutoSize = true;
            this.MtDisableUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MtDisableUpdate.Depth = 0;
            this.MtDisableUpdate.Font = new System.Drawing.Font("Roboto", 10F);
            this.MtDisableUpdate.Location = new System.Drawing.Point(12, 221);
            this.MtDisableUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.MtDisableUpdate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MtDisableUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtDisableUpdate.Name = "MtDisableUpdate";
            this.MtDisableUpdate.Ripple = true;
            this.MtDisableUpdate.Size = new System.Drawing.Size(206, 30);
            this.MtDisableUpdate.TabIndex = 4;
            this.MtDisableUpdate.Text = "Disable Meta Update Checks";
            this.MtDisableUpdate.UseVisualStyleBackColor = false;
            // 
            // MtForceAllBackground
            // 
            this.MtForceAllBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MtForceAllBackground.AutoSize = true;
            this.MtForceAllBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MtForceAllBackground.Depth = 0;
            this.MtForceAllBackground.Font = new System.Drawing.Font("Roboto", 10F);
            this.MtForceAllBackground.Location = new System.Drawing.Point(12, 263);
            this.MtForceAllBackground.Margin = new System.Windows.Forms.Padding(0);
            this.MtForceAllBackground.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MtForceAllBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtForceAllBackground.Name = "MtForceAllBackground";
            this.MtForceAllBackground.Ripple = true;
            this.MtForceAllBackground.Size = new System.Drawing.Size(316, 30);
            this.MtForceAllBackground.TabIndex = 5;
            this.MtForceAllBackground.Text = "Force all background permission services (On)";
            this.MtForceAllBackground.UseVisualStyleBackColor = false;
            // 
            // MtReset
            // 
            this.MtReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MtReset.AutoSize = true;
            this.MtReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MtReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MtReset.Depth = 0;
            this.MtReset.Icon = null;
            this.MtReset.Location = new System.Drawing.Point(79, 316);
            this.MtReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MtReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtReset.Name = "MtReset";
            this.MtReset.Primary = false;
            this.MtReset.Size = new System.Drawing.Size(120, 36);
            this.MtReset.TabIndex = 6;
            this.MtReset.Text = "Reset Module";
            this.MtReset.UseVisualStyleBackColor = false;
            // 
            // UIManualLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(344, 367);
            this.Controls.Add(this.MtReset);
            this.Controls.Add(this.MtForceAllBackground);
            this.Controls.Add(this.MtDisableUpdate);
            this.Controls.Add(this.MtEmulateNet);
            this.Controls.Add(this.MtForceOath);
            this.Controls.Add(this.TxtModule);
            this.Controls.Add(this.BtnStartModule);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIManualLoad";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIManualLoad";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton BtnStartModule;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtModule;
        private MaterialSkin.Controls.MaterialCheckBox MtForceOath;
        private MaterialSkin.Controls.MaterialCheckBox MtEmulateNet;
        private MaterialSkin.Controls.MaterialCheckBox MtDisableUpdate;
        private MaterialSkin.Controls.MaterialCheckBox MtForceAllBackground;
        private MaterialSkin.Controls.MaterialFlatButton MtReset;
    }
}