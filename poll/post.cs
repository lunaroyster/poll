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
            string CandidateName;
            string description;
            string imageURL;
            public bool isInitialized;
            public string Name
            {
                get
                {
                    return CandidateName != null ? CandidateName : "Unnamed";
                }
                set
                {
                    CandidateName = value;
                }
            }
            public Candidate(string name)
            {
                Name = name;
            }
        }
        
    }
}
