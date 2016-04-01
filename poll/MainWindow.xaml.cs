using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml;
using Microsoft.Win32;


namespace poll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            LoadConfig();
        }
        private void LoadConfig()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = ".xml";
            fd.InitialDirectory = Directory.GetCurrentDirectory();
            fd.Filter = "XML files (.xml)|*.xml";
            fd.Multiselect = false;
            Nullable<bool> result = fd.ShowDialog();

            string ConfigFile = File.ReadAllText(fd.FileName);
            using (XmlReader reader = XmlReader.Create(new StringReader(ConfigFile)))
            {
                while (true)
                {

                }
            }
        }

        private void Uplink(string message)
        {

        }
    }
}
