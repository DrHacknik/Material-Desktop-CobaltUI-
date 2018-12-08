using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Design_Desktop_Concept.Material.Core
{
    internal class ParseModules
    {
        public static string[] List;
        private static string cd = Environment.CurrentDirectory;
        /*
        ======================================================
        Get a list of modules and parse them into a list.
        Then parse the requested module (or all the modues')
        metas & Information files.

        This cannot be called after AppLoader.LoadApp() has
        been called. That could cause issues with the currently
        parsed information. This can only be parsed afterwords,
        only if a new module has been installed/updated. Since
        the Parsed info and file is flushed from memory.
        ======================================================
         */

        public static void BeginParse()
        {
            //List = new string[] {
            //   Directory.GetDirectories(Environment.CurrentDirectory + "\\Common\\Modules").ToList
            //};

            return;
        }

        public static void CheckModules()
        {
            if (!Directory.Exists(cd + "\\Common\\Modules\\ModuleInstaller") || !Directory.Exists(cd + "\\Common\\Modules\\WebView"))
            {
                Directory.CreateDirectory(cd + "\\Common\\Modules\\ModuleInstaller");
                Directory.CreateDirectory(cd + "\\Common\\Modules\\DevWebView");
                Directory.CreateDirectory(cd + "\\Common\\Modules\\DevUIFileExplorer");

                MessageBox.Show("Missing module directories and meta information was created.", "CheckModules", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return;
        }

        public static void CleanModules()
        {
            return;
        }
    }
}