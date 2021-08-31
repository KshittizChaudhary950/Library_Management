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
    public partial class Complete_book_details : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        public Complete_book_details()
        {
            InitializeComponent();
        }

        private void Complete_book_details_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            //-------------------------------------------------------------------------------------
            //code for issue datagrid view
            SqlConnection con2 = new SqlConnection(cs);
            string query = "select * from IRBook where book_return_date is null";
            SqlCommand cmd = new SqlCommand(query,con2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            //-------------------------------------------------------------------------------------------

            SqlConnection con3 = new SqlConnection(cs);
            string query2 = "select * from IRBook where book_return_date is not null";
            SqlCommand cmd2 = new SqlCommand(query2, con3);

            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            dataGridView2.DataSource = ds2.Tables[0];

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent mdi = new MDIParent();
            mdi.Show();
        }
    }
}
