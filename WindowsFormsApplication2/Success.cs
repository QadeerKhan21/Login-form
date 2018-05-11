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
    public partial class Success : Form
    {
        private static Success successfrm;
        private Success()
        {
            successfrm = null;
            InitializeComponent();
        }
        public static Success get_ins()
        {
            if (successfrm == null)
            {
                successfrm = new Success();
            }
            return successfrm;
        }

        private void Success_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyUtility.LoginUser = null;
            Login s = Login.get_ins();
            
            s.Show();
            this.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contacts con=new Contacts();
            con.Name=textName.Text;
            con.Number=textNumber.Text;
            MyUtility.LoginUser.Contact1.Add(con);
            BindingSource source= new BindingSource();
            source.DataSource = MyUtility.LoginUser.Contact1;
            Gridpage.DataSource = source;


        }

        private void Gridpage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
