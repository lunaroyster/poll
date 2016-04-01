using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poll
{
    public class Post
    {
        public bool isInitialized;
        string PostName;
        public Post(string name)
        {
            Name = name;
            isInitialized = true;
        }
        public string Name
        {
            get
            {
                return PostName != null ? PostName : "Unassigned";
            }
            set
            {
                PostName = value;
            }
        }
        class Candidate
        {
            string name;
            string description;
            string imageURL;
            public string Name
            {
                get
                {
                    return name != null ? name : "Unnamed";
                }
                set
                {
                    name = value;
                }
            }
            
        }
        
    }
}
