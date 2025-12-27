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
    public partial class CancellationForm : Form
    {
        public CancellationForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");


        private void CancellationForm_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();

        }

        private void fillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Tid from Ticket", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            cbTid.ValueMember = "Tid";
            cbTid.DataSource = dt;
            Con.Close();
        }
        private void fetchfcode()
        {
            Con.Open();
            string query = "select * from Ticket where Tid= " + cbTid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtFcode.Text = dr["Fcode"].ToString();

            }

            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select* from Cancel";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void deleteTicket()
        {

            try
            {
                Con.Open();
                string query = "delete from Ticket where TiD=" + cbTid.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TICKET Deleted Succesfully", "SPEED AIRLINE");
                Con.Close();
                populate();
            }
            catch (Exception Ex)

            {
                MessageBox.Show(Ex.Message);
            }
        }
    
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCid.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION", "SPEED AIRLINE");
            }
            else
            {
                try
                {
                    {
                        Con.Open();
                        string query = "insert into Cancel values (" + txtCid.Text + ",'" + cbTid.SelectedValue.ToString() + "','" + txtFcode.Text + "','" + TCdate.Value.Date + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("TICKET CANCELLED Successfully", "SPEED AIRLINE");
                        Con.Close();
                        populate();
                        deleteTicket();

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Missing Search Information", "SPEED AIRLINE");
            }
            else

            {
                con.Open();


                SqlCommand cmd = new SqlCommand("Select* from Cancel where CancelId=@CancelId ", con);
                cmd.Parameters.AddWithValue("CancelId", int.Parse(txt_Search.Text));


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();



                da.Fill(dt);

                guna2DataGridView1.DataSource = dt;
                guna2DataGridView1.Visible = true;
                Con.Close();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtCid.Text = "";
            cbTid.SelectedItem = null;
            txt_Search.Text = "";
            txtFcode.Text = "";
            TCdate.Text = "";
            MessageBox.Show("All Data Cleared", "SPEED AIRLINE");


        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void cbTid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FormAdmin MF = new FormAdmin();
            MF.Show();
            this.Hide();
        }
    }
}
