using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Material_Design_Desktop_Concept.Material.GUI;
using System.IO;

namespace Material_Design_Desktop_Concept.Material.Web
{
    public partial class UIWebView : MaterialForm
    {
        private string cd = Application.StartupPath;
        private const string DefaultUrlForAddedTabs = "https://accounts.google.com/AddSession/signinchooser";

        // Default to a small increment:
        private const double ZoomIncrement = 0.10;

        private bool multiThreadedMessageLoopEnabled;

        public UIWebView()
        {
            InitializeChromium();
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        public ChromiumWebBrowser chromeBrowser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = cd + "\\Common\\System\\data\\web_cache\\Chromium_";
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("http://www.google.com");
            if (!Directory.Exists(cd + "\\Common\\AppData\\web_cache"))
            {
                Directory.CreateDirectory(cd + "\\Common\\AppData\\web_cache");
            }

            this.Controls.Add(chromeBrowser);
        }

        private void UIWebView_Load(object sender, EventArgs e)
        {
            chromeBrowser.Dock = DockStyle.Bottom;
            chromeBrowser.Height = 475;
            return;
        }
    }
}