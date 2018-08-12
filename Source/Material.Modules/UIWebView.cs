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
using Material_Design_Desktop_Concept.Material.GUI;

namespace Material_Design_Desktop_Concept.Material.Web
{
    public partial class UIWebView : MaterialForm
    {
        public UIWebView()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }
    }
}