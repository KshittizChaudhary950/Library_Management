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
    public partial class Forget_Password : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        public Forget_Password()
        {
            InitializeComponent();
        }
        void ClearFunction()
        {
            IDtextBox.Clear();
            UsernametextBox.Clear();
            newPasswordtextBox.Clear();
            ConfirmtextBox.Clear();
            IDtextBox.Focus();
        }


        private void Changebutton_Click(object sender, EventArgs e)
        {
            if (UsernametextBox.Text != "" && newPasswordtextBox.Text != "" && ConfirmtextBox.Text != "")
            {
                if (newPasswordtextBox.Text == ConfirmtextBox.Text)
                {
                    SqlConnection con = new SqlConnection(cs);
                    //working on update
                    string query = "Update Login set Pass=@password where ID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@password", ConfirmtextBox.Text);
                    cmd.Parameters.AddWithValue("@id", IDtextBox.Text);
                    cmd.Parameters.AddWithValue("@username", UsernametextBox.Text);
                    con.Open();
                    int i=cmd.ExecuteNonQuery();
                    if(i>0)
                    {
                        MessageBox.Show("Password change sucessfully");
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            else
            {
                MessageBox.Show("Please fill all information");
            }
            ClearFunction();



        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            UsernametextBox.Clear();
            newPasswordtextBox.Clear();
            ConfirmtextBox.Clear();
            IDtextBox.Focus();
        }
    }
}

