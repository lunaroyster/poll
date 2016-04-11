using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace poll
{
    
    class PostButton : Button
    {
        private bool active;
        public int PostID { get; set; }
        public int CandidateID { get; set; }
        private Brush activeBrush;
        private Brush defaultBrush;
        //public Post.Candidate LinkedCandidateObject { }

        public PostButton()
        {
            defaultBrush = Background;
        }

        private void UpdateActivation()
        {
            if (active)
            {
                Background = activeBrush;
            }
            else
            {
                Background = defaultBrush;
            }
        }

        public Brush ActiveBackground
        {
            get
            {
                return activeBrush;
            }
            set
            {
                activeBrush = value;
            }
        }
        
        public bool IsActive
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
                UpdateActivation();
            }
        }

        protected override void OnClick()
        {
            IsActive = !IsActive;
        }
    }
}
