namespace Material_Design_Desktop_Concept.Material.GUI
{
    partial class UIDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIDesktop));
            this.PnlTray = new System.Windows.Forms.Panel();
            this.PnlSelected = new System.Windows.Forms.Panel();
            this.PcxUser = new System.Windows.Forms.PictureBox();
            this.PcxBlue = new System.Windows.Forms.PictureBox();
            this.PcxBat = new System.Windows.Forms.PictureBox();
            this.PcxWireless = new System.Windows.Forms.PictureBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.PnlTraySys = new System.Windows.Forms.Panel();
            this.PcxApps = new System.Windows.Forms.PictureBox();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.PnlTrayPanel = new System.Windows.Forms.Panel();
            this.PnlTrayPanelPowerIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPaneAudio = new System.Windows.Forms.Panel();
            this.PcxTrayPaneAudioForm = new System.Windows.Forms.PictureBox();
            this.PnlTrayPaneAudioIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPanelUserIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPaneBluetoothIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPanelBatteryIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPanelWifiIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPanelUser = new System.Windows.Forms.Label();
            this.PnlTrayPanelBluetooth = new System.Windows.Forms.Label();
            this.LblTrayPanelBattery = new System.Windows.Forms.Label();
            this.LblTrayPanelSSID = new System.Windows.Forms.Label();
            this.TmrGetWireless = new System.Windows.Forms.Timer(this.components);
            this.PnlNotif = new System.Windows.Forms.Panel();
            this.PnlPanelNotifIcon = new System.Windows.Forms.PictureBox();
            this.PnlTrayPanelNotif = new System.Windows.Forms.Panel();
            this.CtxUI = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.uIDisableWirelessContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIModulesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uISettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIExitSafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UIAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlTray.SuspendLayout();
            this.PnlSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWireless)).BeginInit();
            this.PnlTraySys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxApps)).BeginInit();
            this.PnlTrayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelPowerIcon)).BeginInit();
            this.PnlTrayPaneAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcxTrayPaneAudioForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPaneAudioIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPaneBluetoothIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelBatteryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelWifiIcon)).BeginInit();
            this.PnlNotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPanelNotifIcon)).BeginInit();
            this.CtxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTray
            // 
            this.PnlTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTray.BackColor = System.Drawing.Color.Transparent;
            this.PnlTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTray.BackgroundImage")));
            this.PnlTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlTray.Controls.Add(this.PnlSelected);
            this.PnlTray.Controls.Add(this.LblTime);
            this.PnlTray.Location = new System.Drawing.Point(1034, 657);
            this.PnlTray.Name = "PnlTray";
            this.PnlTray.Size = new System.Drawing.Size(234, 51);
            this.PnlTray.TabIndex = 0;
            this.PnlTray.Click += new System.EventHandler(this.PnlTray_Click);
            // 
            // PnlSelected
            // 
            this.PnlSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PnlSelected.Controls.Add(this.PcxUser);
            this.PnlSelected.Controls.Add(this.PcxBlue);
            this.PnlSelected.Controls.Add(this.PcxBat);
            this.PnlSelected.Controls.Add(this.PcxWireless);
            this.PnlSelected.Location = new System.Drawing.Point(39, 7);
            this.PnlSelected.Name = "PnlSelected";
            this.PnlSelected.Size = new System.Drawing.Size(107, 37);
            this.PnlSelected.TabIndex = 5;
            // 
            // PcxUser
            // 
            this.PcxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PcxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxUser.BackgroundImage")));
            this.PcxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("PcxUser.InitialImage")));
            this.PcxUser.Location = new System.Drawing.Point(80, 7);
            this.PcxUser.Name = "PcxUser";
            this.PcxUser.Size = new System.Drawing.Size(18, 24);
            this.PcxUser.TabIndex = 3;
            this.PcxUser.TabStop = false;
            this.PcxUser.Click += new System.EventHandler(this.PcxUser_Click);
            // 
            // PcxBlue
            // 
            this.PcxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PcxBlue.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.if_47_111099_White;
            this.PcxBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxBlue.InitialImage = ((System.Drawing.Image)(resources.GetObject("PcxBlue.InitialImage")));
            this.PcxBlue.Location = new System.Drawing.Point(56, 7);
            this.PcxBlue.Name = "PcxBlue";
            this.PcxBlue.Size = new System.Drawing.Size(18, 24);
            this.PcxBlue.TabIndex = 3;
            this.PcxBlue.TabStop = false;
            this.PcxBlue.Click += new System.EventHandler(this.PcxBlue_Click);
            // 
            // PcxBat
            // 
            this.PcxBat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PcxBat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxBat.BackgroundImage")));
            this.PcxBat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxBat.InitialImage = ((System.Drawing.Image)(resources.GetObject("PcxBat.InitialImage")));
            this.PcxBat.Location = new System.Drawing.Point(32, 7);
            this.PcxBat.Name = "PcxBat";
            this.PcxBat.Size = new System.Drawing.Size(18, 24);
            this.PcxBat.TabIndex = 2;
            this.PcxBat.TabStop = false;
            this.PcxBat.Click += new System.EventHandler(this.PcxBat_Click);
            // 
            // PcxWireless
            // 
            this.PcxWireless.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PcxWireless.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxWireless.BackgroundImage")));
            this.PcxWireless.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxWireless.InitialImage = ((System.Drawing.Image)(resources.GetObject("PcxWireless.InitialImage")));
            this.PcxWireless.Location = new System.Drawing.Point(8, 7);
            this.PcxWireless.Name = "PcxWireless";
            this.PcxWireless.Size = new System.Drawing.Size(18, 24);
            this.PcxWireless.TabIndex = 1;
            this.PcxWireless.TabStop = false;
            this.PcxWireless.Click += new System.EventHandler(this.PcxWireless_Click);
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblTime.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.LblTime.ForeColor = System.Drawing.Color.White;
            this.LblTime.Location = new System.Drawing.Point(148, 7);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(59, 37);
            this.LblTime.TabIndex = 4;
            this.LblTime.Text = "1:19 PM";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlTraySys
            // 
            this.PnlTraySys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlTraySys.BackColor = System.Drawing.Color.Transparent;
            this.PnlTraySys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTraySys.BackgroundImage")));
            this.PnlTraySys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlTraySys.Controls.Add(this.PcxApps);
            this.PnlTraySys.Location = new System.Drawing.Point(12, 657);
            this.PnlTraySys.Name = "PnlTraySys";
            this.PnlTraySys.Size = new System.Drawing.Size(428, 51);
            this.PnlTraySys.TabIndex = 1;
            this.PnlTraySys.Click += new System.EventHandler(this.PnlTraySys_Click);
            // 
            // PcxApps
            // 
            this.PcxApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxApps.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.TrayApps;
            this.PcxApps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxApps.InitialImage = ((System.Drawing.Image)(resources.GetObject("PcxApps.InitialImage")));
            this.PcxApps.Location = new System.Drawing.Point(8, 10);
            this.PcxApps.Name = "PcxApps";
            this.PcxApps.Size = new System.Drawing.Size(33, 30);
            this.PcxApps.TabIndex = 0;
            this.PcxApps.TabStop = false;
            this.PcxApps.Click += new System.EventHandler(this.PcxApps_Click);
            this.PcxApps.MouseLeave += new System.EventHandler(this.PcxApps_MouseLeave);
            this.PcxApps.MouseHover += new System.EventHandler(this.PcxApps_MouseHover);
            // 
            // TmrTime
            // 
            this.TmrTime.Enabled = true;
            this.TmrTime.Interval = 1;
            this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // PnlTrayPanel
            // 
            this.PnlTrayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanel.BackColor = System.Drawing.Color.Transparent;
            this.PnlTrayPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanel.BackgroundImage")));
            this.PnlTrayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPanelPowerIcon);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPaneAudio);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPaneAudioIcon);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPanelUserIcon);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPaneBluetoothIcon);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPanelBatteryIcon);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPanelWifiIcon);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPanelUser);
            this.PnlTrayPanel.Controls.Add(this.PnlTrayPanelBluetooth);
            this.PnlTrayPanel.Controls.Add(this.LblTrayPanelBattery);
            this.PnlTrayPanel.Controls.Add(this.LblTrayPanelSSID);
            this.PnlTrayPanel.Location = new System.Drawing.Point(1034, 413);
            this.PnlTrayPanel.Name = "PnlTrayPanel";
            this.PnlTrayPanel.Size = new System.Drawing.Size(234, 238);
            this.PnlTrayPanel.TabIndex = 2;
            this.PnlTrayPanel.Visible = false;
            // 
            // PnlTrayPanelPowerIcon
            // 
            this.PnlTrayPanelPowerIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelPowerIcon.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.if_060_Off_183189_White;
            this.PnlTrayPanelPowerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlTrayPanelPowerIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelPowerIcon.InitialImage")));
            this.PnlTrayPanelPowerIcon.Location = new System.Drawing.Point(195, 197);
            this.PnlTrayPanelPowerIcon.Name = "PnlTrayPanelPowerIcon";
            this.PnlTrayPanelPowerIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlTrayPanelPowerIcon.TabIndex = 14;
            this.PnlTrayPanelPowerIcon.TabStop = false;
            this.PnlTrayPanelPowerIcon.Click += new System.EventHandler(this.PnlTrayPanelPowerIcon_Click);
            this.PnlTrayPanelPowerIcon.MouseLeave += new System.EventHandler(this.PnlTrayPanelPowerIcon_MouseLeave);
            this.PnlTrayPanelPowerIcon.MouseHover += new System.EventHandler(this.PnlTrayPanelPowerIcon_MouseHover);
            // 
            // PnlTrayPaneAudio
            // 
            this.PnlTrayPaneAudio.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.TrayPanelAudio;
            this.PnlTrayPaneAudio.Controls.Add(this.PcxTrayPaneAudioForm);
            this.PnlTrayPaneAudio.Location = new System.Drawing.Point(49, 164);
            this.PnlTrayPaneAudio.Name = "PnlTrayPaneAudio";
            this.PnlTrayPaneAudio.Size = new System.Drawing.Size(169, 10);
            this.PnlTrayPaneAudio.TabIndex = 13;
            // 
            // PcxTrayPaneAudioForm
            // 
            this.PcxTrayPaneAudioForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PcxTrayPaneAudioForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PcxTrayPaneAudioForm.BackgroundImage")));
            this.PcxTrayPaneAudioForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcxTrayPaneAudioForm.Location = new System.Drawing.Point(0, 0);
            this.PcxTrayPaneAudioForm.Name = "PcxTrayPaneAudioForm";
            this.PcxTrayPaneAudioForm.Size = new System.Drawing.Size(2, 10);
            this.PcxTrayPaneAudioForm.TabIndex = 0;
            this.PcxTrayPaneAudioForm.TabStop = false;
            // 
            // PnlTrayPaneAudioIcon
            // 
            this.PnlTrayPaneAudioIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PnlTrayPaneAudioIcon.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.if_47_111099_White;
            this.PnlTrayPaneAudioIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlTrayPaneAudioIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPaneAudioIcon.InitialImage")));
            this.PnlTrayPaneAudioIcon.Location = new System.Drawing.Point(16, 158);
            this.PnlTrayPaneAudioIcon.Name = "PnlTrayPaneAudioIcon";
            this.PnlTrayPaneAudioIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlTrayPaneAudioIcon.TabIndex = 12;
            this.PnlTrayPaneAudioIcon.TabStop = false;
            this.PnlTrayPaneAudioIcon.Click += new System.EventHandler(this.PnlTrayPaneAudioIcon_Click);
            // 
            // PnlTrayPanelUserIcon
            // 
            this.PnlTrayPanelUserIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelUserIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelUserIcon.BackgroundImage")));
            this.PnlTrayPanelUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlTrayPanelUserIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelUserIcon.InitialImage")));
            this.PnlTrayPanelUserIcon.Location = new System.Drawing.Point(16, 197);
            this.PnlTrayPanelUserIcon.Name = "PnlTrayPanelUserIcon";
            this.PnlTrayPanelUserIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlTrayPanelUserIcon.TabIndex = 11;
            this.PnlTrayPanelUserIcon.TabStop = false;
            this.PnlTrayPanelUserIcon.Click += new System.EventHandler(this.PnlTrayPanelUserIcon_Click);
            this.PnlTrayPanelUserIcon.MouseLeave += new System.EventHandler(this.PnlTrayPanelUserIcon_MouseLeave);
            this.PnlTrayPanelUserIcon.MouseHover += new System.EventHandler(this.PnlTrayPanelUserIcon_MouseHover);
            // 
            // PnlTrayPaneBluetoothIcon
            // 
            this.PnlTrayPaneBluetoothIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPaneBluetoothIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPaneBluetoothIcon.BackgroundImage")));
            this.PnlTrayPaneBluetoothIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlTrayPaneBluetoothIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPaneBluetoothIcon.InitialImage")));
            this.PnlTrayPaneBluetoothIcon.Location = new System.Drawing.Point(16, 98);
            this.PnlTrayPaneBluetoothIcon.Name = "PnlTrayPaneBluetoothIcon";
            this.PnlTrayPaneBluetoothIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlTrayPaneBluetoothIcon.TabIndex = 10;
            this.PnlTrayPaneBluetoothIcon.TabStop = false;
            // 
            // PnlTrayPanelBatteryIcon
            // 
            this.PnlTrayPanelBatteryIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelBatteryIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelBatteryIcon.BackgroundImage")));
            this.PnlTrayPanelBatteryIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlTrayPanelBatteryIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelBatteryIcon.InitialImage")));
            this.PnlTrayPanelBatteryIcon.Location = new System.Drawing.Point(16, 62);
            this.PnlTrayPanelBatteryIcon.Name = "PnlTrayPanelBatteryIcon";
            this.PnlTrayPanelBatteryIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlTrayPanelBatteryIcon.TabIndex = 9;
            this.PnlTrayPanelBatteryIcon.TabStop = false;
            // 
            // PnlTrayPanelWifiIcon
            // 
            this.PnlTrayPanelWifiIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelWifiIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelWifiIcon.BackgroundImage")));
            this.PnlTrayPanelWifiIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlTrayPanelWifiIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelWifiIcon.InitialImage")));
            this.PnlTrayPanelWifiIcon.Location = new System.Drawing.Point(16, 25);
            this.PnlTrayPanelWifiIcon.Name = "PnlTrayPanelWifiIcon";
            this.PnlTrayPanelWifiIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlTrayPanelWifiIcon.TabIndex = 8;
            this.PnlTrayPanelWifiIcon.TabStop = false;
            // 
            // PnlTrayPanelUser
            // 
            this.PnlTrayPanelUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelUser.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.PnlTrayPanelUser.ForeColor = System.Drawing.Color.White;
            this.PnlTrayPanelUser.Location = new System.Drawing.Point(50, 191);
            this.PnlTrayPanelUser.Name = "PnlTrayPanelUser";
            this.PnlTrayPanelUser.Size = new System.Drawing.Size(139, 37);
            this.PnlTrayPanelUser.TabIndex = 7;
            this.PnlTrayPanelUser.Text = "%USER%";
            this.PnlTrayPanelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlTrayPanelBluetooth
            // 
            this.PnlTrayPanelBluetooth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelBluetooth.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.PnlTrayPanelBluetooth.ForeColor = System.Drawing.Color.White;
            this.PnlTrayPanelBluetooth.Location = new System.Drawing.Point(50, 93);
            this.PnlTrayPanelBluetooth.Name = "PnlTrayPanelBluetooth";
            this.PnlTrayPanelBluetooth.Size = new System.Drawing.Size(169, 37);
            this.PnlTrayPanelBluetooth.TabIndex = 6;
            this.PnlTrayPanelBluetooth.Text = "%BTSTAT%";
            this.PnlTrayPanelBluetooth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTrayPanelBattery
            // 
            this.LblTrayPanelBattery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTrayPanelBattery.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.LblTrayPanelBattery.ForeColor = System.Drawing.Color.White;
            this.LblTrayPanelBattery.Location = new System.Drawing.Point(50, 56);
            this.LblTrayPanelBattery.Name = "LblTrayPanelBattery";
            this.LblTrayPanelBattery.Size = new System.Drawing.Size(169, 37);
            this.LblTrayPanelBattery.TabIndex = 5;
            this.LblTrayPanelBattery.Text = "%BATTERY%";
            this.LblTrayPanelBattery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTrayPanelSSID
            // 
            this.LblTrayPanelSSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTrayPanelSSID.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.LblTrayPanelSSID.ForeColor = System.Drawing.Color.White;
            this.LblTrayPanelSSID.Location = new System.Drawing.Point(50, 19);
            this.LblTrayPanelSSID.Name = "LblTrayPanelSSID";
            this.LblTrayPanelSSID.Size = new System.Drawing.Size(169, 37);
            this.LblTrayPanelSSID.TabIndex = 5;
            this.LblTrayPanelSSID.Text = "%SSID%%";
            this.LblTrayPanelSSID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TmrGetWireless
            // 
            this.TmrGetWireless.Enabled = true;
            this.TmrGetWireless.Interval = 1000;
            this.TmrGetWireless.Tick += new System.EventHandler(this.TmrGetWireless_Tick);
            // 
            // PnlNotif
            // 
            this.PnlNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlNotif.BackColor = System.Drawing.Color.Transparent;
            this.PnlNotif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlNotif.BackgroundImage")));
            this.PnlNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlNotif.Controls.Add(this.PnlPanelNotifIcon);
            this.PnlNotif.Location = new System.Drawing.Point(972, 657);
            this.PnlNotif.Name = "PnlNotif";
            this.PnlNotif.Size = new System.Drawing.Size(56, 51);
            this.PnlNotif.TabIndex = 3;
            // 
            // PnlPanelNotifIcon
            // 
            this.PnlPanelNotifIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPanelNotifIcon.BackgroundImage = global::Material_Design_Desktop_Concept.Properties.Resources.if_share4_216719_White;
            this.PnlPanelNotifIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlPanelNotifIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PnlPanelNotifIcon.InitialImage")));
            this.PnlPanelNotifIcon.Location = new System.Drawing.Point(16, 13);
            this.PnlPanelNotifIcon.Name = "PnlPanelNotifIcon";
            this.PnlPanelNotifIcon.Size = new System.Drawing.Size(24, 24);
            this.PnlPanelNotifIcon.TabIndex = 12;
            this.PnlPanelNotifIcon.TabStop = false;
            this.PnlPanelNotifIcon.Click += new System.EventHandler(this.PnlPanelNotifIcon_Click);
            // 
            // PnlTrayPanelNotif
            // 
            this.PnlTrayPanelNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTrayPanelNotif.BackColor = System.Drawing.Color.Transparent;
            this.PnlTrayPanelNotif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTrayPanelNotif.BackgroundImage")));
            this.PnlTrayPanelNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlTrayPanelNotif.Location = new System.Drawing.Point(1034, 169);
            this.PnlTrayPanelNotif.Name = "PnlTrayPanelNotif";
            this.PnlTrayPanelNotif.Size = new System.Drawing.Size(234, 238);
            this.PnlTrayPanelNotif.TabIndex = 4;
            this.PnlTrayPanelNotif.Visible = false;
            // 
            // CtxUI
            // 
            this.CtxUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CtxUI.Depth = 0;
            this.CtxUI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uIDisableWirelessContextToolStripMenuItem,
            this.uIModulesToolStripMenuItem,
            this.uIModulesManagementToolStripMenuItem,
            this.uISettingsToolStripMenuItem,
            this.uIExitSafeToolStripMenuItem,
            this.UIAboutToolStripMenuItem});
            this.CtxUI.MouseState = MaterialSkin.MouseState.HOVER;
            this.CtxUI.Name = "CtxUI";
            this.CtxUI.Size = new System.Drawing.Size(208, 158);
            // 
            // uIDisableWirelessContextToolStripMenuItem
            // 
            this.uIDisableWirelessContextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trueToolStripMenuItem,
            this.falseToolStripMenuItem});
            this.uIDisableWirelessContextToolStripMenuItem.Name = "uIDisableWirelessContextToolStripMenuItem";
            this.uIDisableWirelessContextToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.uIDisableWirelessContextToolStripMenuItem.Text = "UIDisableWirelessContext";
            this.uIDisableWirelessContextToolStripMenuItem.ToolTipText = "This will disable the Wireless check. This setting will only apply the current in" +
    "stance in Memory; and will not save to the Config.\r\n\r\nThis can fix issues with s" +
    "lower drawing, when disabled. ";
            // 
            // trueToolStripMenuItem
            // 
            this.trueToolStripMenuItem.Name = "trueToolStripMenuItem";
            this.trueToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.trueToolStripMenuItem.Text = "True";
            this.trueToolStripMenuItem.Click += new System.EventHandler(this.trueToolStripMenuItem_Click);
            // 
            // falseToolStripMenuItem
            // 
            this.falseToolStripMenuItem.Name = "falseToolStripMenuItem";
            this.falseToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.falseToolStripMenuItem.Text = "False";
            this.falseToolStripMenuItem.Click += new System.EventHandler(this.falseToolStripMenuItem_Click);
            // 
            // uIModulesManagementToolStripMenuItem
            // 
            this.uIModulesManagementToolStripMenuItem.Name = "uIModulesManagementToolStripMenuItem";
            this.uIModulesManagementToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.uIModulesManagementToolStripMenuItem.Text = "UIModulesManagement";
            this.uIModulesManagementToolStripMenuItem.Click += new System.EventHandler(this.uIModulesManagementToolStripMenuItem_Click);
            // 
            // uISettingsToolStripMenuItem
            // 
            this.uISettingsToolStripMenuItem.Name = "uISettingsToolStripMenuItem";
            this.uISettingsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.uISettingsToolStripMenuItem.Text = "UISettings";
            this.uISettingsToolStripMenuItem.Click += new System.EventHandler(this.uISettingsToolStripMenuItem_Click);
            // 
            // uIExitSafeToolStripMenuItem
            // 
            this.uIExitSafeToolStripMenuItem.Name = "uIExitSafeToolStripMenuItem";
            this.uIExitSafeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.uIExitSafeToolStripMenuItem.Text = "UIExitSafe";
            this.uIExitSafeToolStripMenuItem.Click += new System.EventHandler(this.uIExitSafeToolStripMenuItem_Click);
            // 
            // UIAboutToolStripMenuItem
            // 
            this.UIAboutToolStripMenuItem.Name = "UIAboutToolStripMenuItem";
            this.UIAboutToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.UIAboutToolStripMenuItem.Text = "UIAbout";
            this.UIAboutToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // uIModulesToolStripMenuItem
            // 
            this.uIModulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webViewToolStripMenuItem});
            this.uIModulesToolStripMenuItem.Name = "uIModulesToolStripMenuItem";
            this.uIModulesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.uIModulesToolStripMenuItem.Text = "UIModules";
            // 
            // webViewToolStripMenuItem
            // 
            this.webViewToolStripMenuItem.Name = "webViewToolStripMenuItem";
            this.webViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.webViewToolStripMenuItem.Text = "WebView";
            this.webViewToolStripMenuItem.Click += new System.EventHandler(this.WebViewToolStripMenuItem_Click);
            // 
            // UIDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ContextMenuStrip = this.CtxUI;
            this.ControlBox = false;
            this.Controls.Add(this.PnlTrayPanelNotif);
            this.Controls.Add(this.PnlNotif);
            this.Controls.Add(this.PnlTraySys);
            this.Controls.Add(this.PnlTray);
            this.Controls.Add(this.PnlTrayPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIDesktop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIDesktop_FormClosing);
            this.Load += new System.EventHandler(this.UIDesktop_Load);
            this.Click += new System.EventHandler(this.UIDesktop_Click);
            this.PnlTray.ResumeLayout(false);
            this.PnlSelected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcxWireless)).EndInit();
            this.PnlTraySys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcxApps)).EndInit();
            this.PnlTrayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelPowerIcon)).EndInit();
            this.PnlTrayPaneAudio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcxTrayPaneAudioForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPaneAudioIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPaneBluetoothIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelBatteryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTrayPanelWifiIcon)).EndInit();
            this.PnlNotif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlPanelNotifIcon)).EndInit();
            this.CtxUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTray;
        private System.Windows.Forms.Panel PnlTraySys;
        private System.Windows.Forms.PictureBox PcxApps;
        private System.Windows.Forms.PictureBox PcxWireless;
        private System.Windows.Forms.PictureBox PcxUser;
        private System.Windows.Forms.PictureBox PcxBlue;
        private System.Windows.Forms.PictureBox PcxBat;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer TmrTime;
        private System.Windows.Forms.Panel PnlTrayPanel;
        private System.Windows.Forms.Label LblTrayPanelSSID;
        private System.Windows.Forms.Label LblTrayPanelBattery;
        private System.Windows.Forms.Label PnlTrayPanelBluetooth;
        private System.Windows.Forms.Label PnlTrayPanelUser;
        private System.Windows.Forms.PictureBox PnlTrayPanelWifiIcon;
        private System.Windows.Forms.PictureBox PnlTrayPanelBatteryIcon;
        private System.Windows.Forms.PictureBox PnlTrayPaneBluetoothIcon;
        private System.Windows.Forms.PictureBox PnlTrayPanelUserIcon;
        private System.Windows.Forms.Timer TmrGetWireless;
        private System.Windows.Forms.Panel PnlSelected;
        private System.Windows.Forms.PictureBox PnlTrayPaneAudioIcon;
        private System.Windows.Forms.Panel PnlTrayPaneAudio;
        private System.Windows.Forms.PictureBox PcxTrayPaneAudioForm;
        private System.Windows.Forms.PictureBox PnlTrayPanelPowerIcon;
        private System.Windows.Forms.Panel PnlNotif;
        private System.Windows.Forms.PictureBox PnlPanelNotifIcon;
        private System.Windows.Forms.Panel PnlTrayPanelNotif;
        private MaterialSkin.Controls.MaterialContextMenuStrip CtxUI;
        private System.Windows.Forms.ToolStripMenuItem uIDisableWirelessContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uISettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIExitSafeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIModulesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UIAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webViewToolStripMenuItem;
    }
}