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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HD6PS8A\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True; Connect Timeout =30");
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string sql = "select username, role from Loginn where username = '" + this.txtUserName.Text + "' and password = '" + this.txtPassword.Text + "';";
            
            con.Open();
            SqlCommand sqlcom = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count  > 0)
            {
                var name = ds.Tables[0].Rows[0][1].ToString();
                var role = ds.Tables[0].Rows[0][1].ToString();
                MessageBox.Show(" YOU'RE WELCOME ", " " + name.ToUpper());
                if (role == "Admin")
                {
                    this.Hide();
                    new FormAdmin(name, this).Show();
                }

                else if  (role == "member")
                    
                {
                    this.Hide();
                    new MemberForm(name, this).Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid User");
            }



            con.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
        
   

