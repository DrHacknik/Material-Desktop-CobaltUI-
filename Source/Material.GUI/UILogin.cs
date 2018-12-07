using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Material_Design_Desktop_Concept.Material.Web;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UILogin : Form
    {
        private string cd = Application.StartupPath;

        public UILogin()
        {
            InitializeComponent();
        }

        private void UILogin_Click(object sender, EventArgs e)
        {
        }

        private void TmrFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                TmrFadeOut.Stop();
                Hide();
            }
            return;
        }

        private void TmrCheckEnter_Tick(object sender, EventArgs k)
        {
        }

        private void UILogin_Load(object sender, EventArgs e)
        {
            LblUserPass.Text = Properties.Settings.Default.TmpUser;
            try
            {
                if (!File.Exists(cd + "\\Common\\User\\Wallpapers\\_current.png"))
                {
                    this.BackgroundImage = Image.FromFile(cd + "\\Common\\User\\Wallpapers\\_default.png");
                    return;
                }
                else
                {
                    try
                    {
                        File.Copy(Properties.Settings.Default.TmpWallPath, cd + "\\Common\\User\\Wallpapers\\_current.png", true);
                    }
                    catch { }
                    this.BackgroundImage = Image.FromFile(cd + "\\Common\\User\\Wallpapers\\_current.png");
                    return;
                }
            }
            catch
            {
                this.BackgroundImage = Properties.Resources.Concept_Wall_1920;
                return;
            }
        }

        private void PcxBackground_Click(object sender, EventArgs e)
        {
            Form _UILoader = new _UILoader();
            _UILoader.Show();
            TmrFadeOut.Start();
            return;
        }

        private void LblUserPass_Click(object sender, EventArgs e)
        {
            Form _UILoader = new _UILoader();
            _UILoader.Show();
            TmrFadeOut.Start();
            return;
        }

        private void TmrTIme_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void LblGoogle_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.TopMost = false;
            PcxUser.Visible = false;
            LblUserPass.Visible = false;
            LblGoogle.Visible = false;
            UIWebView.IntHeight = 539;
            UIWebView.WebViewLoginGoogle = true;
            Form _UIWebView = new UIWebView();
            _UIWebView.Show();
            _UIWebView.ControlBox = false;
            return;
        }
    }
}