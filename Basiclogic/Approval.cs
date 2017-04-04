using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiclogic
{
    public class Approval
    {
        public string Username { get; set; }
        public string InterventionState { get; set; }
        public string InterventionName { get; set; }
        public string ChangeIntState { get; set; }


        public string InterventionType { get; set; }
        public string InterventionClient { get; set; }
        public string IntUser { get; set; }



        public string ChangeInterventionState(string user, string IntState, string IntName, string changeState)
        {
            Username = user;
            InterventionState = IntState;
            InterventionName = InterventionName;
            ChangeIntState = changeState;
            string Answer = null;

            if (InterventionState == "Approved")
            {
                if (Username == "Site Engineer")
                {
                    ChangeIntState = ChangeIntState == "Cancelled" || ChangeIntState == "Completed" ? changeState
                       : "Not allowed";
                    Answer = ChangeIntState;
                }
                else
                {
                    Answer  = "Not allowed";
                    return Answer;
                }

            }
            return Answer;
        }

        public string CreateIntervention(string IntType, string client, string User)
        {
            InterventionType = IntType;
            InterventionClient = client;
            IntUser = User;
            string answer = null;
            if (IntUser == "Site Engineer")
            {
                answer = "Created";
                return answer;
            }
            else
            {
                answer = "Not Created";
            }
            return answer;
        }
    }

}
