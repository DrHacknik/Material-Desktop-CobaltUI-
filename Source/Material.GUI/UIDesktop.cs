using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Material_Design_Desktop_Concept.Material.Web;
using Material_Design_Desktop_Concept.Material.Modules;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UIDesktop : Form
    {
        private string cd = Application.StartupPath;

        public UIDesktop()
        {
            //MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void PcxApps_MouseHover(object sender, EventArgs e)
        {
            PcxApps.BackgroundImage = Properties.Resources.TrayAppsInactive;
            return;
        }

        private void PcxApps_MouseLeave(object sender, EventArgs e)
        {
            PcxApps.BackgroundImage = Properties.Resources.TrayApps;
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToShortTimeString();
            LblTrayPanelBattery.Text = SystemInformation.PowerStatus.BatteryLifePercent + "%".ToString();
        }

        private void ShowTrayPanel()
        {
            PnlNotif.BackgroundImage = Properties.Resources.TrayPanelNotif;
            PnlTrayPanelNotif.Visible = false;
            PnlTrayPanel.Visible = true;
            PnlSelected.BackgroundImage = Properties.Resources.TraySel;
            return;
        }

        private void HideTrayPanel()
        {
            PnlNotif.BackgroundImage = Properties.Resources.TrayPanelNotif;
            PnlTrayPanel.Visible = false;
            PnlTrayPanelNotif.Visible = false;
            PnlSelected.BackgroundImage = null;
            return;
        }

        private void GetWireless()
        {
            /*Thread Get_Wireless = new Thread(delegate ()
            {*/
            try
            {
                var process = new Process
                {
                    StartInfo = {
                    FileName = "netsh.exe",
                    Arguments = "wlan show interfaces",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                    }
                };
                process.Start();

                var output = process.StandardOutput.ReadToEnd();
                var line = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                    .FirstOrDefault(l => l.Contains("SSID") && !l.Contains("BSSID"));
                if (line == null)
                {
                    LblTrayPanelSSID.Text = "";
                }
                var ssid = line.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
                this.LblTrayPanelSSID.Text = ssid;

                this.PcxWireless.BackgroundImage = Properties.Resources.if_ic_signal_wifi_1_bar_48px_352128_White;
                this.PnlTrayPanelWifiIcon.BackgroundImage = Properties.Resources.if_ic_signal_wifi_1_bar_48px_352128_White;
            }
            catch (Exception ex)
            {
                this.LblTrayPanelSSID.Text = "Wifi Disabled";
                this.PcxWireless.BackgroundImage = Properties.Resources.if_ic_signal_wifi_off_48px_352130_White;
                this.PnlTrayPanelWifiIcon.BackgroundImage = Properties.Resources.if_ic_signal_wifi_off_48px_352130_White;
            }
            //});
        }

        private void PcxUser_Click(object sender, EventArgs e)
        {
            ShowTrayPanel();
        }

        private void PcxWireless_Click(object sender, EventArgs e)
        {
            ShowTrayPanel();
        }

        private void PcxBat_Click(object sender, EventArgs e)
        {
            ShowTrayPanel();
        }

        private void PcxBlue_Click(object sender, EventArgs e)
        {
            ShowTrayPanel();
        }

        private void UIDesktop_Load(object sender, EventArgs e)
        {
            PnlTrayPanelUser.Text = Properties.Settings.Default.TmpUser;
            GetWireless();
            if (!File.Exists(cd + "\\Common\\User\\Wallpapers\\_current.png"))
            {
                this.BackgroundImage = Image.FromFile(cd + "\\Common\\User\\Wallpapers\\_default.png");
                return;
            }
            else
            {
                this.BackgroundImage = Image.FromFile(cd + "\\Common\\User\\Wallpapers\\_current.png");
                return;
            }
        }

        private void TmrGetWireless_Tick(object sender, EventArgs e)
        {
            GetWireless();
            return;
        }

        private void UIDesktop_Click(object sender, EventArgs e)
        {
            HideTrayPanel();
        }

        private void PnlTraySys_Click(object sender, EventArgs e)
        {
            HideTrayPanel();
        }

        private void PcxApps_Click(object sender, EventArgs e)
        {
            HideTrayPanel();
        }

        private void PnlTray_Click(object sender, EventArgs e)
        {
            HideTrayPanel();
        }

        private void PnlTrayPaneAudioIcon_Click(object sender, EventArgs e)
        {
            PcxTrayPaneAudioForm.Width += 5;
        }

        private void UIDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PnlTrayPanelPowerIcon_Click(object sender, EventArgs e)
        {
            PnlTrayPanelPowerIcon.BackgroundImage = Properties.Resources.if_060_Off_183189_White_Sel;
            Application.Exit();
        }

        private void PnlTrayPanelPowerIcon_MouseLeave(object sender, EventArgs e)
        {
            PnlTrayPanelPowerIcon.BackgroundImage = Properties.Resources.if_060_Off_183189_White;
            return;
        }

        private void PnlTrayPanelPowerIcon_MouseHover(object sender, EventArgs e)
        {
            PnlTrayPanelPowerIcon.BackgroundImage = Properties.Resources.if_060_Off_183189_White_Sel;
            return;
        }

        private void PnlTrayPanelUserIcon_Click(object sender, EventArgs e)
        {
            PnlTrayPanelUserIcon.BackgroundImage = Properties.Resources.if_account_circle_326497_White_Sel;
            HideTrayPanel();

            try
            {
                Form _UISettings = new UISettings();
                _UISettings.Show();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to dispose object." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Overall error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PnlTrayPanelUserIcon_MouseHover(object sender, EventArgs e)
        {
            PnlTrayPanelUserIcon.BackgroundImage = Properties.Resources.if_account_circle_326497_White_Sel;
            return;
        }

        private void PnlTrayPanelUserIcon_MouseLeave(object sender, EventArgs e)
        {
            PnlTrayPanelUserIcon.BackgroundImage = Properties.Resources.if_account_circle_326497_White;
            return;
        }

        private void PnlPanelNotifIcon_Click(object sender, EventArgs e)
        {
            PnlNotif.BackgroundImage = Properties.Resources.TrayPanelNotifSel;
            PnlTrayPanel.Visible = true;
            PnlSelected.BackgroundImage = null;
            PnlTrayPanelNotif.Location = PnlTrayPanel.Location;
            PnlTrayPanelNotif.Visible = true;
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TmrGetWireless.Stop();
        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TmrGetWireless.Start();
        }

        private void uIExitSafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uISettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form _UISettings = new UISettings();
                _UISettings.Show();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to dispose object." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Overall error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void uIModulesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form _UIModules = new UIModules();
                _UIModules.Show();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to dispose object." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Overall error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Form _UIAbout = new UIAbout();
                _UIAbout.Show();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to dispose object." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Overall error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void WebViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form _UIWebView = new UIWebView();
                _UIWebView.Show();
                Properties.Settings.Default.TmpURL = "file:///" + cd + "/Common/AppData/web_cache/NoData/index.html";
                Properties.Settings.Default.Save();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to dispose object." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Overall error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void wallpaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpDialogWall.ShowDialog();
        }

        private void OpDialogWall_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.TmpWallPath = OpDialogWall.FileName;
            Properties.Settings.Default.Save();
            this.BackgroundImage = Image.FromFile(Properties.Settings.Default.TmpWallPath);
            try
            {
                if (File.Exists(cd + "\\Common\\User\\Wallpapers\\_current.png"))
                {
                    File.Delete(cd + "\\Common\\User\\Wallpapers\\_current.png");
                    File.Copy(Properties.Settings.Default.TmpWallPath, cd + "\\Common\\User\\Wallpapers\\_current.png", true);
                }
                else
                {
                    File.Copy(Properties.Settings.Default.TmpWallPath, cd + "\\Common\\User\\Wallpapers\\_current.png", true);
                }
            }
            catch (Exception ex) { }
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form _UIWeather = new UIWeather();
                _UIWeather.Show();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to dispose object." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Overall error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}