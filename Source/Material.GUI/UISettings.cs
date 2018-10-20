using System;
using Material_Design_Desktop_Concept.Material.Modules;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UISettings : MaterialForm
    {
        public UISettings()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}