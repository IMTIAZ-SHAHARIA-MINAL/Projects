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
    public partial class FormAdmin : Form
    {
        private LoginForm Fl { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(string text, LoginForm fl) : this()
        {
            this.lblOutput.Text += text;
            this.Fl = fl;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            FlightForm FF = new FlightForm();

            FF.Show();
            this.Hide();
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            PassengerForm PF = new PassengerForm();
            PF.Show();
            this.Hide();
        }

        private void btn_Ticketbook_Click(object sender, EventArgs e)
        {
            TicketForm TF = new TicketForm();
            TF.Show();
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CancellationForm CF = new CancellationForm();
            CF.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout Application?", "SPEED AIRLINE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
