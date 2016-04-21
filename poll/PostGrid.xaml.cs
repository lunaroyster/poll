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

namespace poll
{
    /// <summary>
    /// Interaction logic for PostGrid.xaml
    /// </summary>
    public partial class PostGrid : UserControl
    {
        int width = MainWindow.ButtonWidth;
        int height = MainWindow.ButtonHeight;
        int margin = MainWindow.ButtonMargin;
        int selectedCandidate;
        public int PostID;

        private void SelectCandidate(object sender, RoutedEventArgs e)
        {
            PostButton pb = (PostButton)sender;
            selectedCandidate = pb.CandidateID;
            MessageBox.Show((pb.CandidateID + PostID).ToString());
        }

        public PostGrid()
        {
            InitializeComponent();
            CandidateWrapPanel.Margin = new Thickness(margin);
        }
        public void LoadOptions(Post p)
        {
            
            foreach (Post.Candidate c in p.cand)
            {
                PostButton pb = new PostButton();
                pb.Height = height;
                pb.Width = width;
                pb.Margin = new Thickness(margin);
                pb.Content = c.Name;
                pb.CandidateID = c.CandidateID;
                pb.Click += SelectCandidate;
                CandidateWrapPanel.Children.Add(pb);
            }
        }
       
    }
}
