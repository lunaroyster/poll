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
            int width = MainWindow.ButtonWidth;
            int margin = MainWindow.ButtonMargin;
            foreach (Post.Candidate c in p.cand)
            {
                PostButton pb = new PostButton();
                pb.Height = width;
                pb.Width = width;
                pb.Margin = new Thickness(margin, margin, margin, margin);
                pb.Content = c.Name;
                CandidateWrapPanel.Children.Add(pb);
            }
        }
    }
}
