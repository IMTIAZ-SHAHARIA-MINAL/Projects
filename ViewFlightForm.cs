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
    public partial class ViewFlightForm : Form
    {
        public ViewFlightForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
        private void populate()
        {
            Con.Open();
            string query = "select* from Flight";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FlightForm FF = new FlightForm();
            FF.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtFcode.Text == "" || cbDes.Text == "")
            {
                MessageBox.Show("MISSING FULL INFOMATION DETAILS", "SPEED AIRLINE");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Flight set [From]  ='" + cbFrom.SelectedItem.ToString() + "',Destination ='" + cbDes.SelectedItem.ToString() + "',Takeoff ='" + Fdate.Value.ToString() + "' where Fcode= " + txtFcode.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(" FLIGHT UPDATED SUCESSFULLY ", "SPEED AIRLINE");
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
            if (txtFcode.Text == "")
            {
                MessageBox.Show("ENTER THE FLIGHT TO DELETE", "SPEED AIRLINE");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Flight where Fcode=" + txtFcode.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("FLIGHT Deleted Succesfully", "SPEED AIRLINE");
                    populate();

                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void ViewFlightForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtFcode.Text = "";
            Fdate.Text = "";
            txtNos.Text = "";
            txt_Search.Text = "";
            cbFrom.SelectedItem = null;
            cbDes.SelectedItem = null;
            MessageBox.Show("All Data Cleared", "SPEED AIRLINE");
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtFcode.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cbFrom.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cbDes.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtNos.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
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


                        SqlCommand cmd = new SqlCommand("Select* from Flight where Fcode=@Fcode ", con);
                        cmd.Parameters.AddWithValue("Fcode", int.Parse(txt_Search.Text));


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

















