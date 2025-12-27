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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");

        private void populate()
        {
            Con.Open();
            string query = "select* from Ticket";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from Passenger", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PidCb.ValueMember = "PassId";
            PidCb.DataSource = dt;
            Con.Close();



        }
        private void fillFightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from Flight", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(int));
            dt.Load(rdr);
            FcodeCb.ValueMember = "Fcode";
            FcodeCb.DataSource = dt;
            Con.Close();




        }
        string Pname, Ppass, Pnation;
        private void fetchpassenger()
        {
            Con.Open();
            string query = "select * from Passenger where PassId= " + PidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Pname = dr["PassName"].ToString();
                Ppass = dr["Passport"].ToString();
                Pnation = dr["PassNationality"].ToString();

                txtname.Text = Pname;
                txtpasspt.Text = Ppass;
                NatCb.Text = Pnation;


            }

            Con.Close();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MemberForm MF = new MemberForm();
            MF.Show();
            this.Hide();
        }

        private void PidCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txttid.Text = "";
            txtname.Text = "";
            txtpasspt.Text = "";
            txtamt.Text = "";
            txtage.Text = "";
            txtqnt.Text = "";
            txt_Search.Text = "";
            PidCb.SelectedItem = null;
            FcodeCb.SelectedItem = null;
            NatCb.SelectedItem = null;
            MessageBox.Show("All Data Cleared", "SPEED AIRLINE");
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            if (txttid.Text == "" || txtpasspt.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION", "SPEED AIRLINE");

            }
            else
                try
                {
                    {
                        Con.Open();
                        string query = "insert into Ticket values (" + txttid.Text + ",'" + FcodeCb.SelectedValue.ToString() + "','" + PidCb.SelectedValue.ToString() + "','" + txtname.Text + "','" + txtpasspt.Text + "','" + NatCb.SelectedItem.ToString() + "','" + txtage.Text + "','" + txtamt.Text + "','" + txtqnt.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("TICKET BOOKED Successfully", "SPEED AIRLINE");
                        Con.Close();
                        populate();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }

        private void PidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Missing Search Information", "SPEED AIRLINE");
            }
            else
                try { 
                         
                     {
                        con.Open();


                        SqlCommand cmd = new SqlCommand("Select* from Ticket where Tid=@Tid ", con);
                        cmd.Parameters.AddWithValue("Tid", int.Parse(txt_Search.Text));


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
                
                
                
        private void btn_Mback_Click(object sender, EventArgs e)
        {
            FormAdmin FM = new FormAdmin();
            FM.Show();
            this.Hide();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void TicketForm_Load(object sender, EventArgs e)
        {
            fillPassenger();
            populate();
            fillFightCode();
        }
    }
}
