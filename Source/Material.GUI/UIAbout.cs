using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UIAbout : MaterialForm
    {
        public UIAbout()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void UIAbout_Load(object sender, EventArgs e)
        {
            LblHeader.Text = Application.ProductName.ToString() + Environment.NewLine + "Codename CobaltUI";
            LblBody.Text = "Version: " + Application.ProductVersion + "\r\nCreated by Dr.Hacknik";
            LblFullBody.Text = "Libraries used: " +
                "\r\n* Chromium CEF v" + CefSharp.Cef.ChromiumVersion + " (Used for WebView) \r\n* MaterialSkin \r\n* NET 4.6.1 \r\n* QTX (Deprecated source)";
        }
    }
}