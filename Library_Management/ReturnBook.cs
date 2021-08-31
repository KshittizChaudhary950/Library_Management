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
    public partial class ReturnBook : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        void clearfunction()
        {
            SearchtextBox.Clear();
            SearchtextBox.Focus();
        }
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent mdi = new MDIParent();
            mdi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearfunction();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from IRBook where Std_enroll='"+SearchtextBox.Text+"' and book_return_date is null";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            if(dt.Tables[0].Rows.Count!=0)
            {
                dataGridView.DataSource = dt.Tables[0];
            }
            else
            {
                MessageBox.Show("Enrollment no is not found");
            }
        }
        string bname;
        string bdate;
        Int64 rowid;

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panel3.Visible = true;
                if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    rowid = Int64.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    bname = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    bdate = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                BooknametextBox.Text = bname;
                IssueDatetextBox.Text = bdate;
            }
            catch (Exception)
            {

                MessageBox.Show("Please click in cell");
            }
        
        }

        private void Returnbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "update IRBook set book_return_date='" + returndateTimePicker.Text + "' where Std_enroll='" + SearchtextBox.Text + "' and id='" + rowid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your book has been return");
                ReturnBook_Load(this, null);
                dataGridView.DataSource = null;
                panel3.Visible = false;
                SearchtextBox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Book return Failed");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent mdi = new MDIParent();
            mdi.Show();
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchtextBox.Text==null)
            {
                panel3.Visible = false;
                dataGridView.DataSource = null;
            }
        }
    }
}
