using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Design_Desktop_Concept.Material.GUI
{
    public partial class UINotification : Form
    {
        private int RemainingTime = 3500;
        private string cd = Application.StartupPath;

        public UINotification()
        {
            InitializeComponent();
        }

        private void PlaceLowerRight()
        {
            Screen rightmost = Screen.PrimaryScreen;
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width + 47;
            this.Top = rightmost.WorkingArea.Bottom - this.Height - 65;
        }

        private void UINotification_Load(object sender, EventArgs e)
        {
            PlaceLowerRight();
            TmrFadeIn.Start();
        }

        private void TmrFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            this.Refresh();

            if (this.Opacity == 100)
            {
                TmrFadeIn.Stop();
            }
        }

        private void TmrFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.2;
            this.Width -= 35;
            if (this.Opacity == 0)
            {
                TmrFadeOut.Stop();
                this.Close();
            }
            else if (this.Width == 0)
            {
                TmrFadeOut.Stop();
                this.Close();
            }
        }

        private void TmrNotify_Tick(object sender, EventArgs e)
        {
            TmrFadeIn.Stop();
            TmrFadeOut.Start();
        }

        private void UINotification_MouseHover(object sender, EventArgs e)
        {
            TmrNotify.Stop();
            return;
        }

        private void UINotification_MouseLeave(object sender, EventArgs e)
        {
            TmrNotify.Interval = RemainingTime;
            TmrNotify.Start();
        }

        private void LblHeader_MouseHover(object sender, EventArgs e)
        {
            TmrNotify.Stop();
        }

        private void LblBody_MouseHover(object sender, EventArgs e)
        {
            TmrNotify.Stop();
        }

        private void PcxLogo_MouseHover(object sender, EventArgs e)
        {
            TmrNotify.Stop();
        }
    }
}