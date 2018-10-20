using Material_Design_Desktop_Concept.Material.Core;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Design_Desktop_Concept.Material.Modules
{
    public partial class UIWeather : MaterialForm
    {
        private static string cd = Environment.CurrentDirectory;
        private static string[] Conditions;

        public UIWeather()
        {
            MaterialSkinManager.Instance.AddFormToManage(this);
            InitializeComponent();
        }

        public void ParseDatabase()
        {
            try
            {
                WebClient GetData = new WebClient();
                if (!File.Exists(cd + "\\Common\\AppData\\Modules\\UIWeather\\Database.ini"))
                {
                    GetData.DownloadFile(new Uri("https://github.com/Material-Desktop-CobaltUI/raw/master/Common/Database/Weather/Database.ini"), cd + "\\Common\\AppData\\Modules\\UIWeather\\Database.ini");
                }
                else
                {
                    File.Move(cd + "\\Common\\AppData\\Modules\\UIWeather\\Database.ini", cd + "\\Common\\AppData\\Modules\\UIWeather\\Database.ini.old");
                    GetData.DownloadFile(new Uri("https://github.com/Material-Desktop-CobaltUI/raw/master/Common/Database/Weather/Database.ini"), cd + "\\Common\\AppData\\Modules\\UIWeather\\Database.ini");
                }
            }
            catch (Exception ex)
            {
                LblFooter.Text = "Failed to download database...";
                MessageBox.Show("Failed to download the database." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                IniParser parser = new IniParser(cd + "\\Common\\AppData\\Modules\\UIWeather\\Database.ini");
                //Normal Conditions
                parser.GetSetting("normal_conditions", "clearnight");
                parser.GetSetting("normal_conditions", "sunny");
                parser.GetSetting("normal_conditions", "partlycloudyday");
                parser.GetSetting("normal_conditions", "partlycloudynight");
                parser.GetSetting("normal_conditions", "overcast");
                parser.GetSetting("normal_conditions", "cloudy");
                parser.GetSetting("normal_conditions", "clearnight");

                //Fog & mist
                parser.GetSetting("fog_mist", "mist");
                parser.GetSetting("fog_mist", "fog");
                parser.GetSetting("fog_mist", "freezingfog");

                //Rain
                parser.GetSetting("rain", "rainday");
                parser.GetSetting("rain", "rainnight");
                parser.GetSetting("rain", "rain");
                parser.GetSetting("rain", "heavyrain");
                parser.GetSetting("rain", "heavyrainday");
                parser.GetSetting("rain", "heavyrainnight");
                parser.GetSetting("rain", "freezingrain");
                parser.GetSetting("rain", "freezingdrizzle");
                parser.GetSetting("rain", "rainthunder");

                //Sleet
                parser.GetSetting("sleet", "sleetday");
                parser.GetSetting("sleet", "sleetnight");
                parser.GetSetting("sleet", "lightsleet");

                //Snow
                parser.GetSetting("snow", "snowday");
                parser.GetSetting("snow", "snownight");
                parser.GetSetting("snow", "lightsnow");
                parser.GetSetting("snow", "heavysnow");
                parser.GetSetting("snow", "blizzard");

                //windy
                parser.GetSetting("windy", "wind");
            }
            catch (Exception ex)
            {
                LblFooter.Text = "Failed to parse database...";
                MessageBox.Show("Failed to parse the database." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conditions = new string[] {
                "Sunny.png",
                "ModRain.png",
                "Overcast.png",
                "Clear.png",
                "Cloudy.png",
                "Fog.png",
                "FreezingRain.png",
                "HeavyRain.png",
                "HeavySleet.png",
                "HeavySnow.png",
                "Mist.png",
                "Blizzard.png",
                "Wind.png",
                "ModSnow.png",
                "PartlyCloudyDay.png",
                "PartlyCloudyNight.png",
                "PartCloudRainThunderDay.png",
                "PartCloudRainThunderNight.png",
        };

            PrgWait.Value = 15;

            GetIcons();
            Random rand;

            rand = new Random();
            int randomIndex = rand.Next(Conditions.Length);
            string FinalCondition = Conditions[randomIndex];

            PcxLogo.BackgroundImage = Image.FromFile(cd + "\\Common\\AppData\\Modules\\UIWeather\\Icons\\" + FinalCondition);
            PrgWait.Value = 50;
            ShowWeather();
        }

        private void GetIcons()
        {
            Conditions = new string[] {
                "Sunny.png",
                "ModRain.png",
                "Overcast.png",
                "Clear.png",
                "Cloudy.png",
                "Fog.png",
                "FreezingRain.png",
                "HeavyRain.png",
                "HeavySleet.png",
                "HeavySnow.png",
                "Mist.png",
                "Blizzard.png",
                "Wind.png",
                "ModSnow.png",
                "PartlyCloudyDay.png",
                "PartlyCloudyNight.png",
                "PartCloudRainThunderDay.png",
                "PartCloudRainThunderNight.png",
        };
            if (!Directory.Exists(cd + "\\Common\\AppData\\Modules\\UIWeather\\Icons\\"))
            {
                Directory.CreateDirectory(cd + "\\Common\\AppData\\Modules\\UIWeather\\Icons\\");
            }

            try
            {
                //Download needed weather Icons
                WebClient GetIcon = new WebClient();
                GetIcon.DownloadFile(new Uri("https://github.com/Material-Desktop-CobaltUI/raw/master/Common/Images/Icons/Weather/" + Conditions), cd + "\\Common\\AppData\\Modules\\UIWeather\\Icons\\" + Conditions);
                return;
            }
            catch (Exception ex)
            {
                LblFooter.Text = "Failed to download icons...";
                MessageBox.Show("Failed to download the icons." + Environment.NewLine + Environment.NewLine + ex, "UIWeather: Icons error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void DisplayWeather()
        {
        }

        public void ParseWeatherAPI()
        {
            return;
        }

        private void ShowWeather()
        {
            LblHeader.Visible = true;
            LblBody.Visible = true;
            PcxLogo.Visible = true;
            BtnRefresh.Visible = true;
            BtnChange.Visible = true;

            PrgWait.Visible = false;
            LblFooter.Visible = false;
            return;
        }

        private void HideWeather()
        {
            LblHeader.Visible = false;
            LblBody.Visible = false;
            PcxLogo.Visible = false;
            BtnRefresh.Visible = false;
            BtnChange.Visible = false;

            PrgWait.Visible = true;
            LblFooter.Visible = true;
            return;
        }

        private void UIWeather_Load(object sender, EventArgs e)
        {
            ParseDatabase();
        }
    }
}