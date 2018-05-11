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
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean Isfound = false;
            foreach (Myusers u in Dataclass.users)
            {
                if (u.Username == textBox1.Text && u.Answer == textBox3.Text)
                {

                    u.Password = "a";
                }



            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormL frm = new FormL();
            frm.Show();
            this.Hide();
        }
    }
}
