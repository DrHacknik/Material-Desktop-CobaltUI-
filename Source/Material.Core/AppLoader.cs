using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Material_Design_Desktop_Concept.Material.Core;
using Material_Design_Desktop_Concept.Material.Modules;
using Material_Design_Desktop_Concept.Material.GUI;
using Material_Design_Desktop_Concept.Material.Web;

namespace Material_Design_Desktop_Concept.Material.Core
{
    internal static class AppLoader
    {
        public static string Module;
        public static bool ModuleIsWebView;
        public static bool EmulateNet;
        public static bool DisableMetaChecks;
        public static bool SvcBackgroundPerms;
        private static string cd = Environment.CurrentDirectory + "\\Common\\Modules";
        /*
        ======================================================
        This is the apploader. This can only be called after
        ParseMeta() has been called by the same instance.
        ======================================================
         */

        public static void ParseMeta()
        {
            ParseModule();
        }

        public static void ParseModule()
        {
            IniParser ModuleParser = new IniParser(cd + "\\" + Module + "\\" + Module + ".ini");
            try
            {
                if (Directory.Exists(cd + "\\" + Module))
                {
                    //File.ReadAllText(cd + "\\");
                    StartModule();
                }
                else
                {
                    MessageBox.Show("Module doesn't exist under the directory: " + cd + "\\" + Module, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private static void StartModule()
        {
            IniParser ModuleParser = new IniParser(cd + "\\" + Module + "\\" + Module + ".ini");
            if (ModuleIsWebView == true)
            {
                UIWebView.WebViewControls = ModuleParser.GetSetting("webview", "webview_controls");
                UIWebView.WebViewSizeHeight = ModuleParser.GetSetting("webview", "webview_size_height");
                UIWebView.WebViewSizeWidth = ModuleParser.GetSetting("webview", "webview_size_width");
                UIWebView.WebViewScrollBars = ModuleParser.GetSetting("webview", "webview_scrollbars");
                UIWebView.WebViewColor = ModuleParser.GetSetting("webview", "webview_color");
                UIWebView.WebViewSizable = ModuleParser.GetSetting("webview", "webview_sizable");
                UIWebView.WebViewURL = ModuleParser.GetSetting("webview", "webview_url");
                UIWebView.WebViewVer = ModuleParser.GetSetting("webview", "webview_ver");
                UIWebView.WebViewLockscreen = ModuleParser.GetSetting("webview", "webview_allow_lockscreen");
                UIWebView.ModuleAllowLockScreenSvc = ModuleParser.GetSetting("webview", "allow_lockscreen_svc");
                UIWebView.ModuleDesktopSvc = ModuleParser.GetSetting("webview", "allow_desktop_svc");
                UIWebView.ModuleRefreshSvcRate = ModuleParser.GetSetting("webview", "refresh_svc_rate");

                UIWebView.ModuleIsWebView = true;

                Form _UIWebView = new UIWebView();
                _UIWebView.Show();
            }
        }
    }
}