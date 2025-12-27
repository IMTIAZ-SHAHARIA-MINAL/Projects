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
    public partial class ViewPassengerForm : Form
    {
        
        public ViewPassengerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
        private void populate()
        {
            Con.Open();
            string query = "select* from Passenger";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            PassengerForm PF = new PassengerForm();
            PF.Show();
            this.Hide();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtPid.Text == "" || txtPname.Text == "" || txtPass.Text == "" || txtPid.Text == "" || txtPad.Text == "")
            {
                MessageBox.Show("Missing Information", "SPEED AIRLINE");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Passenger set PassName ='" + txtPname.Text + "',Passport='" + txtPass.Text + "',PassAddress='" + txtPad.Text + "',PassNationality='" + cbNat.SelectedItem.ToString() + "',PasssGender ='" + cbGen.SelectedItem.ToString() + "',PassPhone ='" + txtPhone.Text + "' where PassId= " + txtPid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully", "SPEED AIRLINE");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtPid.Text == "")
            {
                MessageBox.Show("ENTER THE PASSENGER TO DELETE", "SPEED AIRLINE");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Passenger where PassId=" + txtPid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Succesfully", "SPEED AIRLINE");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);
                }

            }



        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtPid.Text = "";
            txtPname.Text = "";
            txtPass.Text = "";
            txtPad.Text = "";
            txt_Search.Text = "";
            txtPhone.Text = "";
            cbNat.SelectedItem = null;
            cbGen.SelectedItem = null;
            MessageBox.Show("All Data Cleared", "SPEED AIRLINE");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPid.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtPname.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPass.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPad.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cbNat.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cbGen.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPhone.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void ViewPassengerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Missing Search Information", "SPEED AIRLINE");
            }
            else
                try
                {
                    {
                        con.Open();


                        SqlCommand cmd = new SqlCommand("Select* from Passenger where Pid=@Pid ", con);
                        cmd.Parameters.AddWithValue("Pid", int.Parse(txt_Search.Text));


                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();



                        da.Fill(dt);

                        guna2DataGridView1.DataSource = dt;
                        guna2DataGridView1.Visible = true;
                        Con.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }

    }
    
}





