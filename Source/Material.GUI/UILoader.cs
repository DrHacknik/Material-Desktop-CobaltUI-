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

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class _UILoader : Form
    {
        private string cd = Application.StartupPath;

        public _UILoader()
        {
            InitializeComponent();
        }

        public void LoadDesktop()
        {
            if (!Directory.Exists(cd + "\\Common") || !Directory.Exists(cd + "\\Common\\User") || !Directory.Exists(cd + "\\Common\\User\\Wallpapers") ||
                !Directory.Exists(cd + "\\Common\\Modules") || !Directory.Exists(cd + "\\Common\\AppData") ||
                !Directory.Exists(cd + "\\Common\\Temp") && !File.Exists(cd + "\\Config.xml"))
            {
                Directory.CreateDirectory(cd + "\\Common");
                Directory.CreateDirectory(cd + "\\Common\\User");
                Directory.CreateDirectory(cd + "\\Common\\User\\Wallpapers");
                Directory.CreateDirectory(cd + "\\Common\\Modules");
                Directory.CreateDirectory(cd + "\\Common\\AppData");
                Directory.CreateDirectory(cd + "\\Common\\Temp");
                File.Create(cd + "\\Config.xml");

                Properties.Resources.Concept_Wall_1920.Save(cd + "\\Common\\User\\Wallpapers\\_default.png");
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
                catch
                {
                }
                return;
            }

            Form _UIDesktop = new UIDesktop();
            _UIDesktop.Show();
        }

        private void TmrDelayStartup_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            TmrFadeOut.Start();
            TmrDelayStartup.Stop();
            return;
        }

        private void TmrFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                TmrFadeOut.Stop();
                Hide();
                Cursor.Show();
            }
            return;
        }

        private void UILoader_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(cd + "\\Common\\User\\Wallpapers\\_current.png"))
                {
                    this.BackgroundImage = Image.FromFile(cd + "\\Common\\User\\Wallpapers\\_default.png");
                    Cursor.Hide();
                    LoadDesktop();
                    return;
                }
                else
                {
                    this.BackgroundImage = Image.FromFile(cd + "\\Common\\User\\Wallpapers\\_current.png");
                    Cursor.Hide();
                    LoadDesktop();
                    return;
                }
            }
            catch
            {
                this.BackgroundImage = Properties.Resources.Concept_Wall_1920;
                Cursor.Hide();
                LoadDesktop();
                return;
            }
        }
    }
}