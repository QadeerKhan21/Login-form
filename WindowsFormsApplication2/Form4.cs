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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cmd_add_Click(object sender, EventArgs e)
        {
            mycontacts c = new mycontacts();
            c.Name = textBox1.Text;
            c.Cell = textBox2.Text;
            Myusers cu = MyUtill.loginuser;
            MyUtill.loginuser.Contacts.Add(c);
            BindingSource source = new BindingSource();
            source.DataSource = MyUtill.loginuser.Contacts;
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormL frm = new FormL();
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = MyUtill.loginuser.Contacts;
            dataGridView1.DataSource = source;
        }
    }
}
