using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms_first_try
{
    public partial class FineHistory : Form
    {
        public FineHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LostBooks mod = new LostBooks(); // to second form
            mod.Show();
            this.Hide();
        }

        private void FineHistory_Load(object sender, EventArgs e)
        {
            //First datagrideview
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Fine";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds = new DataSet());

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False"))
            {
                string MembersId = txtMID.Text.Trim();
                string BookId = txtBID.Text.Trim();

                try
                {
                    // Ensure at least one search field is provided
                    if (string.IsNullOrWhiteSpace(MembersId) && string.IsNullOrWhiteSpace(BookId))
                    {
                        MessageBox.Show("Please enter a Name or Members Id to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Determine search criteria
                    string query;
                    SqlCommand cmd = new SqlCommand();

                    if (string.IsNullOrWhiteSpace(MembersId)) // Searching by BookId
                    {
                        query = "SELECT * FROM Fine WHERE BookId = @BookId";
                        cmd.Parameters.AddWithValue("@BookId", BookId);
                    }
                    else // Searching by MembersId
                    {
                        query = "SELECT * FROM Fine WHERE MembersId = @MembersId";
                        cmd.Parameters.AddWithValue("@MembersId", MembersId);
                    }

                    // Execute query safely with parameters
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    // Bind the filtered data to the DataGridView
                    dataGridView1.DataSource = dt;

                    // Check if results were found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the given ID.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message, "Library PRO details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
