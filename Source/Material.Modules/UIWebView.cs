using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Material_Design_Desktop_Concept.Material.GUI;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material_Design_Desktop_Concept.Material.Web
{
    public partial class UIWebView : MaterialForm
    {
        private string cd = Environment.CurrentDirectory;
        public const string WebViewDefURL = "https://accounts.google.com/AddSession/signinchooser";
        private const string WebViewTabDefURL = "https://accounts.google.com/AddSession/signinchooser";
        public static string WebViewLoadURL;
        public static bool WebViewLoginGoogle;
        public bool Movable = false;
        public static int IntHeight;
        public static int IntWidth;
        private const double ZoomIncrement = 0.10;

        public static bool ModuleIsWebView;
        public static string WebViewVer;
        public static string WebViewURL;
        public static string WebViewSizeHeight;
        public static string WebViewSizeWidth;
        public static string WebViewOath;
        public static string WebViewScrollBars;
        public static string WebViewControls;
        public static string WebViewLockscreen;
        public static string WebViewColor;

        public static string ModuleAllowLockScreenSvc;
        public static string ModuleDesktopSvc;
        public static string ModuleRefreshSvcRate;

        private MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
        private ChromiumWebBrowser WebViewBrowser;

        public UIWebView()
        {
            InitializeChromium();
            InitializeComponent();
        }

        public static void HideScrollbars(object sender, FrameLoadEndEventArgs args)
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
            Properties.Settings.Default.TmpURL = WebViewLoadURL;
            Properties.Settings.Default.Save();
            CEFCleanup();
            CefSettings CefSettings = new CefSettings();

            CefSettings.CachePath = cd + "\\Common\\AppData\\web_cache";
            Cef.Initialize(CefSettings);

            this.Controls.Add(WebViewBrowser);

            if (ModuleIsWebView == true)
            {
                if (WebViewScrollBars == "true")
                {
                    WebViewBrowser.FrameLoadEnd += HideScrollbars;
                }

                if (WebViewOath == "true")
                {
                    WebViewBrowser = new ChromiumWebBrowser(WebViewDefURL);
                }
                else if (WebViewOath == "false")
                {
                    WebViewBrowser = new ChromiumWebBrowser(WebViewURL);
                }

                if (WebViewControls == "full")
                {
                    this.ControlBox = true;
                    this.MaximizeBox = true;
                    this.MinimizeBox = true;
                }
                else if (WebViewControls == "minimal_close")
                {
                    this.ControlBox = true;
                    this.MaximizeBox = false;
                    this.MinimizeBox = false;
                }
                else if (WebViewControls == "minimal_max")
                {
                    this.ControlBox = true;
                    this.MaximizeBox = true;
                    this.MinimizeBox = false;
                }
                else if (WebViewControls == "minimal_min")
                {
                    this.ControlBox = true;
                    this.MaximizeBox = false;
                    this.MinimizeBox = true;
                }
                if (WebViewColor == "DeepBlue")
                {
                    skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                    skinmgr.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                }
                if (WebViewColor == "Gray" || WebViewColor == "DeepGray")
                {
                    skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                    skinmgr.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.LightBlue200, TextShade.WHITE);
                }
                if (WebViewColor == "DeepRed")
                {
                    skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                    skinmgr.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
                }
                if (WebViewColor == "DeepOrange")
                {
                    skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                    skinmgr.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
                }
                if (WebViewColor == "DeepGreen" || WebViewColor == "Green")
                {
                    skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                    skinmgr.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
                }
                if (WebViewColor == "DeepOrange")
                {
                    skinmgr.Theme = MaterialSkinManager.Themes.DARK;
                    skinmgr.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
                }

                IntHeight = Convert.ToInt32(WebViewSizeHeight);
                IntWidth = Convert.ToInt32(WebViewSizeWidth);
                this.Size = new Size(IntWidth, IntHeight);
            }
        }

        private void CEFCleanup()
        {
            if (File.Exists(cd + "\\Common\\AppData\\web_cache\\Cookies") && File.Exists(cd + "\\Common\\AppData\\web_cache\\Cookies-journal"))
            {
                File.Delete(cd + "\\Common\\AppData\\web_cache\\Cookies");
                File.Delete(cd + "\\Common\\AppData\\web_cache\\Cookie-journal");
            }
            if (!Directory.Exists(cd + "\\Common\\AppData\\web_cache") || !Directory.Exists(cd + "\\Common\\AppData\\web_cache\\NoData"))
            {
                Directory.CreateDirectory(cd + "\\Common\\AppData\\web_cache");
                Directory.CreateDirectory(cd + "\\Common\\AppData\\web_cache\\NoData");
                //File.WriteAllLines(cd + "\\Common\\AppData\\web_cache\\NoData\\index.html", Properties.Resources.index);

                if (!File.Exists(cd + "\\Common\\AppData\\web_cache\\NoData\\index.html"))
                {
                    try
                    {
                        using (var HTML = new WebClient())
                        {
                            HTML.DownloadFile("https://github.com/DrHacknik/Material-Desktop-CobaltUI-/raw/master/Common/Com/index.html", cd + "\\Common\\AppData\\web_cache\\NoData\\index.html");
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

                Properties.Resources.Logo_128_Chrom.Save(cd + "\\Common\\AppData\\web_cache\\NoData\\Logo_128_Chrom.png");
            }
            return;
        }

        private void UIWebView_Load(object sender, EventArgs e)
        {
            WebViewBrowser.Dock = DockStyle.Bottom;
        }

        private void UIWebView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Properties.Settings.Default.TmpURL = "";
            Properties.Settings.Default.Save();
        }

        private void UIWebView_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void TmrCheckMovable_Tick(object sender, EventArgs e)
        {
        }
    }
}