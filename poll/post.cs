using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poll
{
    public class Post
    {
        public int PostID;
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
            public int CandidateID;
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
                isInitialized = true;
                Name = name;
            }
            public int VoteCount; //Change with demographic system


            public List<Demographic> demo = new List<Demographic>();
            public class Demographic
            {
                string DemographicName;
                public int DemographicID;
                int VoteCount;


                public Demographic(string name)
                {
                    Name = name;
                }

                public string Name
                {
                    get
                    {
                        return DemographicName != null ? DemographicName : "Unnamed";
                    }
                    set
                    {
                        DemographicName = value;
                    }
                }

            }

        }
        
    }
}
