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
    public partial class IssueBook : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        void ClearFunction()
        {
            EnrollmenttextBox.Clear();
            NametextBox.Clear();
            DepartmenttextBox.Clear();
            SemestertextBox.Clear();
            ContacttextBox.Clear();
            EmailtextBox.Clear();
            // remove selected items of combo box
            BookcomboBox.Items.Remove(BookcomboBox.SelectedItem);
            EnrollmenttextBox.Focus();
        }
        public IssueBook()
        {
            InitializeComponent();
        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepartmenttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlConnection con2 = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select bname from NewBook",con2);
            con2.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {  
                for(int i=0; i < sdr.FieldCount; i++)
                {
                    BookcomboBox.Items.Add(sdr.GetString(i));
                }

            }
            sdr.Close();
            con.Close();


        }
        int count;
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if(EnrollmenttextBox.Text!="")
            {
                string eid = EnrollmenttextBox.Text;
                SqlConnection con2 = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from NewStudent where senroll ='"+eid+"'", con2);
                con2.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                con2.Close();

                //-----------------------------------------------------------------------------------
                SqlCommand cmd2 = new SqlCommand("Select count(Std_enroll) from IRBook where Std_enroll ='" + eid + "'and book_return_date is null", con2);
                con2.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                sda2.Fill(ds2);

                count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());
                con2.Close();
                //-----------------------------------------------------------------------------------

                if (ds.Tables[0].Rows.Count !=0)
                {
                    NametextBox.Text = ds.Tables[0].Rows[0][1].ToString();
                    DepartmenttextBox.Text = ds.Tables[0].Rows[0][3].ToString();
                    SemestertextBox.Text = ds.Tables[0].Rows[0][4].ToString();
                    ContacttextBox.Text = ds.Tables[0].Rows[0][5].ToString();
                    EmailtextBox.Text = ds.Tables[0].Rows[0][6].ToString();
                   

                }
                else
                {
                    ClearFunction();
                    MessageBox.Show("Invalid enrollment No!! ");
                }
            }
            else
            {
                MessageBox.Show("Please provide Erollment No");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NametextBox.Text!="")
            {
                if (BookcomboBox.SelectedIndex != -1 && count <= 2)
                {

                    string eid = EnrollmenttextBox.Text;

                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into IRBook (Std_enroll, Std_name, Std_dep, Std_sem, Std_contact, Std_email, book_name, book_issuedate)  values(@enroll, @name, @sdep, @sem, @contact, @email, @bookname, @datepicker)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@enroll", EnrollmenttextBox.Text);
                    cmd.Parameters.AddWithValue("@name", NametextBox.Text);
                    cmd.Parameters.AddWithValue("@sdep", DepartmenttextBox.Text);
                    cmd.Parameters.AddWithValue("@sem", SemestertextBox.Text);
                    cmd.Parameters.AddWithValue("@contact", ContacttextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailtextBox.Text);
                    cmd.Parameters.AddWithValue("@bookname", BookcomboBox.Text);
                    cmd.Parameters.AddWithValue("@datepicker", issuedateTimePicker.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                  

                    MessageBox.Show("Issue book sucessfully");

                }
                else
                {
                    MessageBox.Show("Please selected book or Maximum 3 books issue only");
                }

            }
            else
            {
                MessageBox.Show("Please Select entorllment no first");
            }
            ClearFunction();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            ClearFunction();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                MDIParent mdi = new MDIParent();
                mdi.Show();
            }
        }
    }
}
