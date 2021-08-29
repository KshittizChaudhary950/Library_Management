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
    public partial class Add_Books : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;

        public Add_Books()
        {
            InitializeComponent();
        }
        void ClearFunction()
        {
            BooknametextBox.Clear();
            AuthornametextBox.Clear();
            PublicationtextBox.Clear();
            PricetextBox.Clear();
            QtytextBox.Clear();
            BooknametextBox.Focus();


        }
        void Display()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select*from NewBook";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            IdnumericUpDown.Value = 0;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent mdi = new MDIParent();
            mdi.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (BooknametextBox.Text != "" && AuthornametextBox.Text != "" && PricetextBox.Text != "")
            {

                // working on Add new book insert 
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into NewBook(bname, bAuthor, bPubl, bPdate, bprice, bQty) values(@name,@author,@Publication,@date,@price,@qty)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", BooknametextBox.Text);
                cmd.Parameters.AddWithValue("@author", AuthornametextBox.Text);
                cmd.Parameters.AddWithValue("@Publication", PublicationtextBox.Text);
                cmd.Parameters.AddWithValue("@date", PurchasedateTimePicker.Text);
                cmd.Parameters.AddWithValue("@price", PricetextBox.Text);
                cmd.Parameters.AddWithValue("@qty", QtytextBox.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                try
                {
                    if (a > 0)
                    {
                        MessageBox.Show("Data is save sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Data is unable to save");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please insert properly");
                }
                
              
            }
            else
            {
                MessageBox.Show("Plese insert all values");
            }
            ClearFunction();
            Display();


        }

        private void Add_Books_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            Display();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            // working on update buttom
            if (BooknametextBox.Text != "" && AuthornametextBox.Text != "" && PricetextBox.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "Update NewBook set bname=@name, bAuthor=@Author, bPubl=@publication,bPdate=@date,bprice=@price,bQty=@qty where bId=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", IdnumericUpDown.Value);
                    cmd.Parameters.AddWithValue("@name", BooknametextBox.Text);
                    cmd.Parameters.AddWithValue("@Author", AuthornametextBox.Text);
                    cmd.Parameters.AddWithValue("@Publication", PublicationtextBox.Text);
                    cmd.Parameters.AddWithValue("@date", PurchasedateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@price", PricetextBox.Text);
                    cmd.Parameters.AddWithValue("@qty", QtytextBox.Text);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Book details is update sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Unable to update");
                    }
                    con.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Please provide information correctly");
                }
        
            }
            else
            {
                MessageBox.Show("Please fill all information");
            }
            ClearFunction();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                IdnumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                BooknametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                AuthornametextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                PublicationtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                PurchasedateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                PricetextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                QtytextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select properly");
                
            }
        

        }
    }
}
