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
using Material_Design_Desktop_Concept.Material.Core;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UIModules : MaterialForm
    {
        public UIModules()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void UIModules_Load(object sender, EventArgs e)
        {
            ParseModules.CheckModules();
            //LblModuleList.Text = ParseModules.List;
        }
    }
}