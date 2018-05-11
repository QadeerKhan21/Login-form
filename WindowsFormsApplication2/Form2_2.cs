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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lnk_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormL frm = new FormL();
            frm.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            Myusers u1 = new Myusers();
            u1.Username = textBox1.Text;
            u1.Answer = textBox2.Text;
            u1.Password = textpwd.Text;
            u1.Question = comboBox1.Text;

            Dataclass.users.Add(u1);
            MessageBox.Show("user register");
            textBox1.Text = "";
            textpwd.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget frm = new forget();
            frm.Show();
            this.Hide();

        }
    }
}
