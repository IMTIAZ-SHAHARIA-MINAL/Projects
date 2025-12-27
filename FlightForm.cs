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
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormAdmin MF = new FormAdmin();
            MF.Show();
            this.Hide();
        }

        private void btnviewflight_Click(object sender, EventArgs e)
        {
            ViewFlightForm viewflight = new ViewFlightForm();
            viewflight.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            if (txtFcode.Text == "" || txtNos.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION", "SPEED AIRLINE");

            }
            else
                try
                {
                    {
                        Con.Open();
                        string query = "insert into Flight values (" + txtFcode.Text + ", '" + cbFrom.SelectedItem.ToString() + "','" + cbDes.SelectedItem.ToString()+ "','"+Fdate.Value.ToString()+"','" + txtNos.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("NEW FLIGHT ADDED Successfully", "SPEED AIRLINE");
                        Con.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtFcode.Text = "";
            cbFrom.SelectedItem = null;
            cbDes.SelectedItem = null;
            txtNos.Text = "";
            MessageBox.Show("Cleared", "SPEED AIRLINE");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
