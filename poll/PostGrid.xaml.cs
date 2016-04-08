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
        public PostGrid()
        {
            InitializeComponent();
        }
        public void LoadOptions(Post p)
        {
            foreach (Post.Candidate c in p.cand)
            {
                PostButton pb = new PostButton();
                pb.Height = 50;
                pb.Width = (CandidateWrapPanel.ActualWidth / 2);
                pb.Content = c.Name;
                this.CandidateWrapPanel.Children.Add(pb);
            }
        }
    }
}
