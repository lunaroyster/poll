using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poll
{
    class Post
    {
        string name;
        public string Name
        {
            get
            {
                return name != null ? name : "Unassigned";
            }
            set
            {
                name = value;
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
