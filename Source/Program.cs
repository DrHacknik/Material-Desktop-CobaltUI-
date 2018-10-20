using Material_Design_Desktop_Concept.Material.Core;
using Material_Design_Desktop_Concept.Material.GUI;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Design_Desktop_Concept
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            MaterialSkinManager skinmgr = MaterialSkinManager.Instance;
            skinmgr.Theme = MaterialSkinManager.Themes.DARK;
            skinmgr.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UILogin());
        }
    }
}