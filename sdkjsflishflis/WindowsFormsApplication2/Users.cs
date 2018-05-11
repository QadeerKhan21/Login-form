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
        private string sec_question;
        private string sec_answer;
        public string Sec_question
        
        {
            get { return sec_question; }
            set { sec_question = value; }
        }
        

        public string Sec_answer
        {
            get { return sec_answer; }
            set { sec_answer = value; }
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
