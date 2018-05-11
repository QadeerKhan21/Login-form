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
    public partial class Register : Form
    {
        public bool agree = false;
        private static Register regfrm;

        private Register()
        {
            regfrm = null;
           
            InitializeComponent();
        }
        public static Register get_ins()
        {
            if (regfrm == null)
            {
                regfrm = new Register();
            }
            return regfrm;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupSignUp_Enter(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool exist=false;
            bool blank = false;
            if (textuser.Text == "")
            {
                MessageBox.Show("Username Cannot be Blank");
                blank = true;
            }
            if (textpass.Text == "")
            {
                MessageBox.Show("PAssword Cannot be Blank");
                blank = true;
            }
            
            



            foreach (Users x in DB.dbase)
            {
                if (x.Username == textuser.Text)
                {
                    MessageBox.Show("Username already registered");
                    exist = true;

                }
            }
            if (agree == true)
            {
                if (exist != true && blank != true)
                {
                    Users usr = new Users();
                    usr.Username = textuser.Text;
                    usr.Password = textpass.Text;
                    usr.Question = combo_q.Text;
                    usr.Answer = textAns.Text;
                    usr.Regtime = DateTime.Now.ToString("T");
             
                    DB.dbase.Add(usr);
                    MessageBox.Show("User Registered");
                }
            }
            else
            {
                MessageBox.Show("You must agree to terms and conditions in order to use services.");
            }
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            Login frm = Login.get_ins();
            frm.Show();
            this.Hide();
            
        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsecret_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        Register:agree = true;

        }

        private void Register_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text= DateTime.Now.ToString("T");

        }
    }
}
