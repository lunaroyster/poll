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
            //LoadConfig();
            //test();
        }
        private void LoadConfig()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = ".xml";
            fd.InitialDirectory = Directory.GetCurrentDirectory();
            fd.Filter = "XML files (.xml)|*.xml";
            fd.Multiselect = false;
            Nullable<bool> result = fd.ShowDialog();

            //string ConfigFile = File.ReadAllText(fd.FileName);
            //using (XmlReader reader = XmlReader.Create(new StringReader(ConfigFile)))
            //{
            //    while (true)
            //    {

            //    }
            //}

            XmlDocument xd = new XmlDocument();
            xd.Load(fd.FileName);
            XmlNodeList PostList = xd.SelectNodes("/configuration/profile/post");
            foreach (XmlNode postNode in PostList)
            {
                postNode.Attributes.GetNamedItem("name").Value;
            }
        }

        private void Uplink(string message)
        {

        }

        //private void test()
        //{
        //    List<Post> post = new List<Post>();
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Post p = new Post(System.DateTime.Now.ToLongTimeString());
        //        post.Add(p);
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Post.Candidate c = new Post.Candidate();
        //            c.Name = System.DateTime.Now.ToLongTimeString();
        //            post[i].cand.Add(c);
        //        }
        //    }
        //    foreach (Post p in post)
        //    {
        //        MessageBox.Show(p.Name);
        //        foreach (Post.Candidate c in p.cand)
        //        {
        //            MessageBox.Show(c.Name);
        //        }
        //    }
        //}
    }
}
