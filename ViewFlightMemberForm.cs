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
    public partial class ViewFlightMemberForm : Form
    {
        public ViewFlightMemberForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
        private void ViewFlightMemberForm_Load(object sender, EventArgs e)
        {
            populate();
        }

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
        private void btnback_Click(object sender, EventArgs e)
        {
            MemberForm FF = new MemberForm();
            FF.Show();
            this.Hide();
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




        private void btnreset_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            
            MessageBox.Show("All Data Cleared", "SPEED AIRLINE");
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
