using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class UIPrereq : MaterialForm
    {
        private string cd = Application.StartupPath;

        public UIPrereq()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void GetPreReq()
        {
            //Reserved for Prereq downloads.
            PrgMain.Value = 50;
            Setup();
        }

        private void Setup()
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
                        if (Properties.Settings.Default.TmpWallPath == null)
                        {
                        }
                        else
                        {
                            File.Copy(Properties.Settings.Default.TmpWallPath, cd + "\\Common\\User\\Wallpapers\\_current.png", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \r\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            Cleanup();
            PrgMain.Value = 75;
        }

        private void Cleanup()
        {
            if (Directory.Exists(cd + "\\Common\\Temp"))
            {
                Directory.Delete(cd + "\\Common\\Temp");
                return;
            }
            Properties.Settings.Default.TmpURL = "";
            Properties.Settings.Default.Save();
            PrgMain.Value = 100;
            TmCompl.Start();
        }

        private void UIPrereq_Load(object sender, EventArgs e)
        {
            GetPreReq();
        }

        private void TmCompl_Tick(object sender, EventArgs e)
        {
            Form FmLogin = new UILogin();
            FmLogin.Show();
            Hide();
            TmCompl.Stop();
            return;
        }
    }
}