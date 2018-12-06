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
using Material_Design_Desktop_Concept.Material.Modules;

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