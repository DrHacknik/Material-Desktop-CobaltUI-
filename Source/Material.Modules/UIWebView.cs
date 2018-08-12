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

        public UIWebView()
        {
            InitializeChromium();
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        public ChromiumWebBrowser chromeBrowser;

        private void HideScrollbars(object sender, FrameLoadEndEventArgs args)
        {
            if (args.Frame.IsMain)
            {
                args
                    .Browser
                    .MainFrame
                    .ExecuteJavaScriptAsync(
                    "document.body.style.overflow = 'hidden'");
            }
        }

        public void InitializeChromium()
        {
            if (File.Exists(cd + "\\Common\\AppData\\web_cache\\Cookies") && File.Exists(cd + "\\Common\\AppData\\web_cache\\Cookies-journal"))
            {
                File.Delete(cd + "\\Common\\AppData\\web_cache\\Cookies");
                File.Delete(cd + "\\Common\\AppData\\web_cache\\Cookie-journal");
            }
            if (!Directory.Exists(cd + "\\Common\\AppData\\web_cache"))
            {
                Directory.CreateDirectory(cd + "\\Common\\AppData\\web_cache");
            }
            CefSettings settings = new CefSettings();
            settings.CachePath = cd + "\\Common\\AppData\\web_cache";
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("https://accounts.google.com/AddSession/signinchooser");

            chromeBrowser.FrameLoadEnd += HideScrollbars;
            this.Controls.Add(chromeBrowser);
        }

        private void UIWebView_Load(object sender, EventArgs e)
        {
            chromeBrowser.Dock = DockStyle.Bottom;
            chromeBrowser.Height = 475;
            return;
        }

        private void UIWebView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void UIWebView_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}