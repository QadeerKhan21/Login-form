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
    public partial class Login : Form
    {
        private static Login logfrm;
        private Login()
        {
            logfrm = null;

            InitializeComponent();
        }
        public static Login get_ins()
        {
            if (logfrm == null)
            {
                logfrm = new Login();
            }
            return logfrm;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool wrong = true;
            foreach(Users i in DB.dbase)
            {
                if(i.Username==textuser.Text && i.Password == textpass.Text)
                {
                    wrong = false;
             
                    Success s = Success.get_ins();
                    s.Show();
                    this.Hide();
                }
            }
            if (wrong)
            {
                MessageBox.Show("Incorrect Username or password or both");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = Register.get_ins();
            r.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password_Recovery pr = Password_Recovery.get_ins();
            pr.Show();
            this.Hide();
        }
    }
}
