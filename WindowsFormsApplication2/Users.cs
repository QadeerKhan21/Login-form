using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Users
    {
        private string username;
        private string password;
        private string question;
        private string answer;
        private string regtime;
        private List<Contacts> Contact=new List<Contacts>();

internal List<Contacts> Contact1
{
  get { return Contact; }
  set { Contact = value; }
}

        public string Regtime
        {
            get { return regtime; }
            set { regtime = value; }
        }
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        


        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        
    }
}
