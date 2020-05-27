using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Xml.Serialization;

namespace LedController
{
    public partial class Settings : UserControl
    {
        public MetroThemeStyle Theme;
        public MetroColorStyle Style;

        public SaveSettings settings = new SaveSettings();

        string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Luxuino");
        string path;
        XmlSerializer xml = new XmlSerializer(typeof(SaveSettings));

        public Settings()
        {
            InitializeComponent();
        }

        public void Init()
        {
            path = directory + "/Settings.xml";

            foreach (MetroThemeStyle en in Enum.GetValues(typeof(MetroThemeStyle)))
            {
                if ((int)en == -1)
                    continue;
                settingsLight.Items.Add(en);
            }
            settingsLight.SelectedItem = settings.Theme;
            foreach (MetroColorStyle en in Enum.GetValues(typeof(MetroColorStyle)))
            {
                if ((int)en == -1)
                    continue;
                settingsAccent.Items.Add(en);
            }
            settingsAccent.SelectedItem = settings.Style;
        }

        private void settingsSet_Click(object sender, EventArgs e)
        {
            Theme = (MetroThemeStyle)settingsLight.SelectedItem;
            Style = (MetroColorStyle)settingsAccent.SelectedItem;

            using (TextWriter writer = new StreamWriter(path))
            {
                SaveSettings settingsToSave = new SaveSettings(Theme, Style);
                xml.Serialize(writer, settingsToSave);
            }
        }
    }

    public class SaveSettings
    {
        public MetroThemeStyle Theme = MetroThemeStyle.Light;
        public MetroColorStyle Style = MetroColorStyle.Blue;

        public SaveSettings(MetroThemeStyle theme, MetroColorStyle style)
        {
            Theme = theme;
            Style = style;
        }

        public SaveSettings() { }
    }
}
