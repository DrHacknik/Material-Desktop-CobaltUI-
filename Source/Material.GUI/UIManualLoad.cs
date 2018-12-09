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
using Material_Design_Desktop_Concept.Material.Core;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UIManualLoad : MaterialForm
    {
        public UIManualLoad()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        private void BtnStartModule_Click(object sender, EventArgs e)
        {
            try
            {
                AppLoader.ModuleIsWebView = true;
                if (MtForceOath.Checked == true)
                {
                    AppLoader.ModuleIsWebView = true;
                }

                if (MtForceAllBackground.Checked == true)
                {
                    AppLoader.SvcBackgroundPerms = true;
                }
                if (MtEmulateNet.Checked == true)
                {
                    AppLoader.EmulateNet = true;
                }
                if (MtDisableUpdate.Checked == true)
                {
                    AppLoader.DisableMetaChecks = true;
                }
                if (MtDisableUpdate.Checked == true)
                {
                    AppLoader.Module = TxtModule.Text;
                    AppLoader.ParseModule();
                }
                else if (MtDisableUpdate.Checked == false)
                {
                    AppLoader.Module = TxtModule.Text;
                    AppLoader.ParseMeta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}