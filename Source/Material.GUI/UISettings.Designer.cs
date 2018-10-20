namespace Material_Design_Desktop_Concept.Material.GUI {
    partial class UISettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.BtnAccept = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnApply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.AutoSize = true;
            this.BtnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAccept.Depth = 0;
            this.BtnAccept.Icon = null;
            this.BtnAccept.Location = new System.Drawing.Point(769, 567);
            this.BtnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Primary = true;
            this.BtnAccept.Size = new System.Drawing.Size(113, 36);
            this.BtnAccept.TabIndex = 0;
            this.BtnAccept.Text = "Save & Apply";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.AutoSize = true;
            this.BtnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnApply.Depth = 0;
            this.BtnApply.Icon = null;
            this.BtnApply.Location = new System.Drawing.Point(700, 567);
            this.BtnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Primary = true;
            this.BtnApply.Size = new System.Drawing.Size(63, 36);
            this.BtnApply.TabIndex = 1;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(621, 567);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(73, 36);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // UISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 615);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnAccept);
            this.MaximizeBox = false;
            this.Name = "UISettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UISettings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnAccept;
        private MaterialSkin.Controls.MaterialRaisedButton BtnApply;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
    }
}