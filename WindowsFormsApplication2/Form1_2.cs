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
    public partial class FormL : Form
    {
        public FormL()
        {
            InitializeComponent();
        }

        private void lnk_sign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            Boolean Isfound = false;
            foreach (Myusers u in Dataclass.users) {
                if (u.Username == Txtusername.Text && u.Password == textlpwd.Text)
                {

                    Isfound = true;
                    MyUtill.loginuser = u;
                }


            }
            if (Isfound == true)
            {
                MessageBox.Show("valid user");
                Form4 frm = new Form4();
                this.Hide();
                frm.Show();


            }
            else
            {
                MessageBox.Show("invalid username");
            }
            Txtusername.Text = "";
            textlpwd.Text = "";

    }
    } }
