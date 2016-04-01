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
        private Candidate[] cand;
        public Post(string name)
        {
            Name = name;
            isInitialized = true;
        }
        public void Vote(int CandidateNumber)
        {
            cand[CandidateNumber].VoteCount += 1;
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
            public int VoteCount; //Change with demographic system
        }
        
    }
}
