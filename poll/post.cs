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
        
        public List<Candidate> cand = new List<Candidate>();

        public Post(string name)
        {
            Name = name;
            isInitialized = true;
        }
        public void Vote(int CandidateNumber)
        {
            
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

        //public void AddCandidate(string CandidateName)
        //{
        //    Candidate c = new Candidate();
        //    c.Name = CandidateName;
        //    cand.Add(c);
        //}

        public class Candidate
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
            public Candidate()
            {
                isInitialized = true;
                //Name = name;
            }
            public int VoteCount; //Change with demographic system
        }
        
    }
}
