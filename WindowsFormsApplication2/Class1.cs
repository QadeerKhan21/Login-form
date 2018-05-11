using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Myusers
    {
        private String username;
        private String password;
        private String question;
        private String answer;
        private List<mycontacts> contacts = new List<mycontacts>();



        public String Password
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

        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        internal List<mycontacts> Contacts
        {
            get
            {
                return contacts;
            }

            set
            {
                contacts = value;
            }
        }
    }
}
