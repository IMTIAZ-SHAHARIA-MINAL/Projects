using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRLINEMANAGEMENT
{
    public partial class HelpandSupportForm : Form
    {
        public HelpandSupportForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MemberForm MF = new MemberForm();
            MF.Show();
            this.Hide();
        }
    }
}
