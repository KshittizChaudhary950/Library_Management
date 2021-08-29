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
using System.Configuration;

namespace Library_Management
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }
        void Clear()
        {
            UsernametextBox.Clear();
            PasswordtextBox.Clear();
            UsernametextBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernametextBox.Text!="" && PasswordtextBox.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Login where Username='" + UsernametextBox.Text + "' and Pass='" + PasswordtextBox.Text + "'", con);

                DataTable dt = new DataTable();

                sda.Fill(dt);
                int i = 0;
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Username and password does not match");
                    

                }
                else
                {
                    this.Hide();
                    MDIParent mdi = new MDIParent();
                    mdi.Show();

                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
            Clear(); // calling clear function
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password f1 = new Forget_Password();
            f1.Show();
        }
    }
}
