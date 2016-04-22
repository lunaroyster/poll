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
    
    //  TODO Change value parameters to reference parameters where required

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Declarations

            public static List<Post> post = new List<Post>();
            public static int ButtonWidth = 128;
            public static int ButtonMargin = 5;
            public static int ButtonHeight = 128;
            public int WrapButtonCount = 2;
            public string ConfigFileName;

            public static Brush PrimaryBrush;
            public static Brush HighlightBrush = Brushes.White;
            public static Brush PrimaryTextBrush = Brushes.White;
            public static Brush HighlightTextBrush;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            SetColorVariables();
            SetXmlFile();
            LoadProfile();
            LoadDemographics();
            LoadGUI();
        }

        private void SetColorVariables()
        {
            PrimaryBrush = Background;

        }

        private void SetXmlFile()
        {
            //TODO Error Checking/file ennumeration
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = ".xml";
            fd.InitialDirectory = Directory.GetCurrentDirectory();
            fd.Filter = "XML files (.xml)|*.xml";
            fd.Multiselect = false;
            bool? result = fd.ShowDialog();
            ConfigFileName = fd.FileName;
            if (result == false || result == null) { fd.FileName = "D:\\xTemp\\XMLFile1.xml"; }
        }

        private void LoadProfile()
        {
            
            XmlDocument xd = new XmlDocument();
            xd.Load(ConfigFileName);
            XmlNodeList PostNodeList = xd.SelectNodes("/configuration/profile/post");
            int i = 0;
            foreach (XmlNode postNode in PostNodeList)
            {
                string PostName = postNode.Attributes.GetNamedItem("name").Value;
                Post p = new Post(PostName);
                p.PostID = i;
                int j = 0;
                foreach (XmlNode candidateNode in postNode.ChildNodes)
                {
                    string CandidateName = candidateNode.Attributes.GetNamedItem("name").Value;
                    Post.Candidate c = new Post.Candidate(CandidateName);
                    c.CandidateID = j;
                    p.cand.Add(c);
                    j++;
                }
                post.Add(p);
                i++;
            }
        }

        private void LoadDemographics()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(ConfigFileName);
            XmlNodeList DemographicNodeList = xd.SelectNodes("/configuration/demographics/demographic");
            int i = 0;
            foreach (XmlNode DemographicNode in DemographicNodeList)
            {
                string DemographicName = DemographicNode.Attributes.GetNamedItem("name").Value;
                Post.Candidate.Demographic d = new Post.Candidate.Demographic(DemographicName);
                d.DemographicID = i;
                foreach (Post p in post)
                {
                    foreach (Post.Candidate c in p.cand)
                    {
                        c.demo.Add(d);
                    }
                }
            }
        }


        private void LoadGUI()
        {
            foreach (Post p in post)
            {
                PostGrid pg = new PostGrid();
                PostStackPanel.Children.Add(pg);
                pg.CandidateWrapPanel.Width = WrapButtonCount * (ButtonWidth + 2 * ButtonMargin);
                pg.Margin = new Thickness(ButtonMargin);
                pg.PostID = p.PostID;
                pg.LoadOptions(p);
            }
        }

        private WrapPanel PostPanel(Post p)
        {
            WrapPanel wp = new WrapPanel();
            return wp;
        }

        private void Uplink(string message)
        {

        }

        private string TimeStamp()
        {
            return DateTime.Now.ToLongTimeString();
        }
        

        private void cast(int postID, int candidateID, int demographicID)
        {
            //post[postID].cand[candidateID].
        }

        private void VoteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
