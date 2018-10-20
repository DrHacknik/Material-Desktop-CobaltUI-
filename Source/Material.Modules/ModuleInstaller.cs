using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Material_Design_Desktop_Concept.Material.Web;

namespace Material_Design_Desktop_Concept.Material.Modules
{
    internal class ModuleInstaller
    {
        private static string cd = Application.StartupPath;
        public static string installPath;
        public static string Module;
        public static string ModuleID;
        public static bool RequireWebView = false;
        private string WebViewURL = Properties.Settings.Default.TmpURL;
        public static string WebViewOATH;

        public void InstallModule()
        {
            if (!Directory.Exists(cd + "\\Common\\Modules") || !Directory.Exists(cd + "\\Common\\Modules\\" + Module) || !Directory.Exists(cd + "\\Common\\AppData\\" + ModuleID))
            {
                Directory.CreateDirectory(cd + "\\Common\\Modules");
                Directory.CreateDirectory(cd + "\\Common\\Modules\\" + Module);
                Directory.CreateDirectory(cd + "\\Common\\AppData\\" + ModuleID);
            }

            if (RequireWebView == true)
            {
                Form _UIWebView = new UIWebView();
                _UIWebView.Show();
                return;
            }
            else { }
        }

        public void RemoveModule()
        {
        }

        public void CleanModule()
        {
            if (!Directory.Exists(cd + "\\Common\\Modules") || (!Directory.Exists(cd + "\\Common\\Modules" + Module)))
            {
                Directory.CreateDirectory(cd + "\\Common\\Modules");
                Directory.CreateDirectory(cd + "\\Common\\Modules\\" + Module);
            }
            else
            {
                try
                {
                    Directory.Delete(cd + "\\Common\\AppData\\" + ModuleID, true);
                    if (File.Exists(cd + "\\Common\\Modules\\" + Module + "\\Config.json") || File.Exists(cd + "\\Common\\Modules\\" + Module + "\\Config.conf") ||
                        File.Exists(cd + "\\Common\\Modules\\" + Module + "\\Config.xml") || File.Exists(cd + "\\Common\\Modules\\" + Module + "\\Config.ini"))
                    {
                        try
                        {
                            File.Delete(cd + "\\Common\\Modules\\" + Module + "\\Config.json");
                            File.Delete(cd + "\\Common\\Modules\\" + Module + "\\Config.conf");
                            File.Delete(cd + "\\Common\\Modules\\" + Module + "\\Config.xml");
                            File.Delete(cd + "\\Common\\Modules\\" + Module + "\\Config.ini");
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine("\r\nERROR:: " + err);
                            return;
                        }
                    }
                    Console.WriteLine("\r\nMODULE:: Module has been cleaned.");
                    return;
                }
                catch (Exception err)
                {
                    Console.WriteLine("\r\nERROR:: " + err);
                    return;
                }
            }
        }

        public void RepairModule()
        {
        }
    }
}