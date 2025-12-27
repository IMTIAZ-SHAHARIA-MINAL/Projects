using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AIRLINEMANAGEMENT
{
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MemberForm MF = new MemberForm();
            MF.Show();
            this.Hide();

        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            if (txtPid.Text == "" || txtPad.Text == "" || txtPname.Text == "" || txtPass.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION", "SPEED AIRLINE");

            }
            else
                try
                {
                    {
                        Con.Open();
                        string query = "insert into Passenger values (" +txtPid.Text+ ", '" +txtPname.Text+ "','" +txtPass.Text+ "','" +txtPad.Text+ "','" +cbNat.SelectedItem.ToString()+ "','" +cbGen.SelectedItem.ToString()+ "','" +txtPhone.Text+"')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Passenger Added Successfully", "SPEED AIRLINE");
                        Con.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }
   

        private void btnviewpassenger_Click(object sender, EventArgs e)
        {
            ViewPassengerForm viewpass = new ViewPassengerForm();
            viewpass.Show();
            this.Hide();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtPid.Text = "";
            txtPname.Text = "";
            txtPass.Text = "";        
            txtPad.Text = "";
            txtPhone.Text = "";
            cbNat.SelectedItem = null;
            cbGen.SelectedItem = null;
            MessageBox.Show("All Data Cleared", "SPEED AIRLINE");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            FormAdmin MF = new FormAdmin();
            MF.Show();
            this.Hide();
        }
    }
}
