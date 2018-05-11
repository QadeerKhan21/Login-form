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
            if (exist != true && blank!=true)
            {
                Users usr = new Users();
                usr.Username = textuser.Text;
                usr.Password = textpass.Text;
                usr.Sec_question = combo_Q.Text;
                usr.Sec_answer = textAns.Text;

                DB.dbase.Add(usr);
                MessageBox.Show("User Registered");
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

        private void Secret_Click(object sender, EventArgs e)
        {

        }

        private void combo_Q_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
