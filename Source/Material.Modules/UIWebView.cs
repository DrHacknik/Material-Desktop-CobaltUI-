﻿using System;
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
        public string WebViewURL;
        private string cd = Environment.CurrentDirectory;
        public const string WebViewDefURL = "https://accounts.google.com/AddSession/signinchooser";
        private const string WebViewTabDefURL = "https://accounts.google.com/AddSession/signinchooser";
        public static string WebViewLoadURL;
        public static bool WebViewLoginGoogle;
        public bool Movable = false;
        public static int IntHeight;
        private const double ZoomIncrement = 0.10;

        public UIWebView()
        {
            InitializeChromium();
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        public ChromiumWebBrowser WebViewBroser;

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

            if (WebViewLoginGoogle == true)
            {
                WebViewBroser = new ChromiumWebBrowser(WebViewDefURL);
            }
            else if (WebViewLoginGoogle == false)
            {
                WebViewBroser = new ChromiumWebBrowser(Properties.Settings.Default.TmpURL);
            }

            WebViewBroser.FrameLoadEnd += HideScrollbars;
            this.Controls.Add(WebViewBroser);
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
            WebViewBroser.Dock = DockStyle.Bottom;
            WebViewBroser.Height = IntHeight - 66;
            return;
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