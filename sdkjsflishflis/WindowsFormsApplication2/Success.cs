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
    }
}
