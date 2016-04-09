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

        #region Declaration
            List<Post> post = new List<Post>();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            LoadConfig();
            LoadGUI();
        }

        private void LoadConfig()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = ".xml";
            fd.InitialDirectory = Directory.GetCurrentDirectory();
            fd.Filter = "XML files (.xml)|*.xml";
            fd.Multiselect = false;
            Nullable<bool> result = fd.ShowDialog();

            XmlDocument xd = new XmlDocument();
            xd.Load(fd.FileName);
            XmlNodeList PostNodeList = xd.SelectNodes("/configuration/profile/post");
            foreach (XmlNode postNode in PostNodeList)
            {
                string PostName = postNode.Attributes.GetNamedItem("name").Value;
                Post p = new Post(PostName);
                foreach (XmlNode candidateNode in postNode.ChildNodes)
                {
                    string CandidateName = candidateNode.Attributes.GetNamedItem("name").Value;
                    Post.Candidate c = new Post.Candidate(CandidateName);
                    p.cand.Add(c);
                }
                post.Add(p);
            }
        }

        private void LoadGUI()
        {
            //lel.LoadOptions(post[1]);
            foreach (Post p in post)
            {
                PostGrid pg = new PostGrid();
                PostStackPanel.Children.Add(pg);
                pg.Width = 300;
                pg.Margin = new Thickness(5, 5, 5, 5);
                pg.LoadOptions(p);
            }
        }

        private Button CandidateButton(Post.Candidate c)
        {
            Button b = new Button();
            //b.Name = ;
            return b;
        }

        private WrapPanel PostPanel(Post p)
        {
            WrapPanel wp = new WrapPanel();
            return wp;
        }

        private void Uplink(string message)
        {

        }

        private void test()
        {
            foreach (Post p in post)
            {
                MessageBox.Show(p.Name);
                foreach (Post.Candidate c in p.cand)
                {
                    MessageBox.Show(c.Name);
                }
            }
        }

        private void cast(int postID, int candidateID, int demographicID)
        {
            //post[postID].cand[candidateID].
        }

    }
}
