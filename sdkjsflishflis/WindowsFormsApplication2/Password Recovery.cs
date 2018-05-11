using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Password_Recovery : Form
    {
        private static Password_Recovery recfrm;
        private Password_Recovery()
        {
            recfrm = null;
            InitializeComponent();
        }
        public static Password_Recovery get_ins()
        {
            if (recfrm == null)
            {
                recfrm = new Password_Recovery();

            }
            return recfrm;
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool wrong = true;
            foreach(Users i in DB.dbase)
            {
                if(textuser.Text==i.Username && combo_Q.Text==i.Sec_question && textAns.Text==i.Sec_answer)
                {
                    i.Password = textpass.Text;
                    MessageBox.Show("Password Reseted");
                    wrong = false;
                }
            }
            if (wrong)
            {
                MessageBox.Show("Username and Secrect Code doesn't match");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = Login.get_ins();
            log.Show();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
