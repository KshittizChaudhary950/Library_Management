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
    public partial class View_Student : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        public View_Student()
        {
            InitializeComponent();
        }
        void ClearFunction()
        {
            IDnumericUpDown.Value = 0;
            SnametextBox.Clear();
            searchtextBox.Clear();
            senrolltextBox.Clear();
            DepartmenttextBox.Clear();
            SemstertextBox.Clear();
            ContacttextBox.Clear();
            EmailtextBox.Clear();
            searchtextBox.Focus();
        }
        void DataGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select*from NewStudent";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
          
        }

        private void View_Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DataGridView();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (SnametextBox.Text!="" && senrolltextBox.Text!="" && DepartmenttextBox.Text!="")
            {
                try
                {

                    //working on update
                    SqlConnection con = new SqlConnection(cs);
                    string query = "Update NewStudent set Sname=@name,senroll=@enroll,dep=@dep,sem=@sem,contact=@cont,email=@email where Stuid=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id",IDnumericUpDown.Value);
                    cmd.Parameters.AddWithValue("@name", SnametextBox.Text);
                    cmd.Parameters.AddWithValue("@enroll", senrolltextBox.Text);
                    cmd.Parameters.AddWithValue("@dep", DepartmenttextBox.Text);
                    cmd.Parameters.AddWithValue("@sem", SemstertextBox.Text);
                    cmd.Parameters.AddWithValue("@cont", ContacttextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailtextBox.Text);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if(a>0)
                    {
                        MessageBox.Show("Updated sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Updation is failed");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please update carefully");
                }
               
            }
            else
            {
                MessageBox.Show("Please provide Id to update");
            }
            DataGridView();
            ClearFunction();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                IDnumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                SnametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                senrolltextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                DepartmenttextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                SemstertextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ContacttextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                EmailtextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select properly");

            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (SnametextBox.Text != "" && senrolltextBox.Text != "")
            {
                // working on delete
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from NewStudent where Stuid=@id and Sname=@name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IDnumericUpDown.Value);
                cmd.Parameters.AddWithValue("@name", SnametextBox.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete is complete");
                }
                else
                {
                    MessageBox.Show("deletion is failed");
                }
            }
            else
            {
                MessageBox.Show("Please select data from grid view");
            }
            ClearFunction();
            DataGridView();

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent mdi = new MDIParent();
            mdi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // working on search button
            if (searchtextBox.Text != "")
            {

                //working on serach
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from NewStudent where Sname like @name +'%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", searchtextBox.Text.Trim());

                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;

                }
                else
                {
                    MessageBox.Show("No data is found");
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please search bar which book do you want to search");
            }
            searchtextBox.Clear();
            searchtextBox.Focus();

        }
    }
}
