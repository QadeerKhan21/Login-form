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
                if(textuser.Text==i.Username && combo_q.Text==i.Question && textAns.Text==i.Answer)
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

        private void textsec_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupSignUp_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_q_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
