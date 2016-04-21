using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace poll
{
    
    class PostButton : Button
    {
        private bool active;
        public int CandidateID;
        //public Post.Candidate LinkedCandidateObject { }

        public PostButton()
        {
            Background = MainWindow.PrimaryBrush;
        }

        //protected override void OnClick()
        //{
        //    active = !active;
        //    Background = active ? MainWindow.HighlightBrush : MainWindow.PrimaryBrush;
        //}
        
    }
}
