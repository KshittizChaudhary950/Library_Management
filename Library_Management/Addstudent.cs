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
    public partial class Addstudent : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        public Addstudent()
        {
            InitializeComponent();
        }
        void ClearFunction()
        {
            nametextBox.Clear();
            EnrolltextBox.Clear();
            DepartmanttextBox.Clear();
            SemestertextBox.Clear();
            ContacttextBox.Clear();
            EmailtextBox.Clear();
            nametextBox.Focus();
        }

        private void Addstudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            if(nametextBox.Text!="" || EnrolltextBox.Text!="" || DepartmanttextBox.Text!="" || EmailtextBox.Text!="")
            {
                ClearFunction();// callig a function
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text!="" && EnrolltextBox.Text!="" && DepartmanttextBox.Text!="" && SemestertextBox.Text!="")
            {

                try
                {
                    // working on save button
                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into NewStudent (Sname,senroll,dep,sem,contact,email) values(@name,@enroll,@dep,@sem,@contact,@email)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", nametextBox.Text);
                    cmd.Parameters.AddWithValue("@enroll", EnrolltextBox.Text);
                    cmd.Parameters.AddWithValue("@dep", DepartmanttextBox.Text);
                    cmd.Parameters.AddWithValue("@sem", SemestertextBox.Text);
                    cmd.Parameters.AddWithValue("@contact", ContacttextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailtextBox.Text);
                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if(a>0)
                    {
                        MessageBox.Show("Sucessfully saved");
                    }
                    else
                    {
                        MessageBox.Show("Save failed");
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please provide informarion correctly");
                }
                

            }
            else
            {
                MessageBox.Show("Please fill all information");
            }
            ClearFunction();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent mdi = new MDIParent();
            mdi.Show();
        }
    }
}
