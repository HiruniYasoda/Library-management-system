using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lms_first_try
{
    public partial class HandOver : Form
    {
        public HandOver()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void membersactivity_Load(object sender, EventArgs e)
        {
            //First datagrideview
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM NotAvaliableBooks";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds = new DataSet());

            dataGridView1.DataSource = ds.Tables[0];

            //Fill second gridview
            SqlConnection conm = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            conm.Open();
            SqlCommand cmdm = conm.CreateCommand();
            cmdm.Connection = conm;

            cmdm.CommandText = "SELECT * FROM ReservBooks";
            SqlDataAdapter dam = new SqlDataAdapter(cmdm);
            DataSet dsm = new DataSet();
            dam.Fill(dsm = new DataSet());

            dataGridView2.DataSource = dsm.Tables[0];


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            string MembersName = txtName.Text.Trim();
            string MID = txtMID.Text.Trim();
            try
            {
                //Fill textboxes
                if (string.IsNullOrWhiteSpace(MembersName) && string.IsNullOrWhiteSpace(MID))//Check not null
                {
                    MessageBox.Show("Please enter a Name or Members Id to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {

                    //Which option used for search (members name)
                    if (string.IsNullOrWhiteSpace(MID))
                    {
                        string q_searchs = "SELECT MembersId FROM Members WHERE Name = '" + MembersName + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows)
                        {
                            readers.Read();

                            txtMID.Text = readers["MembersId"].ToString();
                        }

                        else
                        {
                            MessageBox.Show("Sorry ! There is no members with given name", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
                        }
                    }

                    else
                    {
                        string q_searchs = "SELECT Name FROM Members WHERE MembersId = '" + MID + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows)
                        {
                            readers.Read();

                            txtName.Text = readers["Name"].ToString();
                        }

                        else
                        {
                            MessageBox.Show("Sorry ! There is no members with given Members Id", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
                        }


                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while searching" + ex.ToString(), "Library PRO details");

            }

            finally
            {

                con.Close();
            }


            try
            {
                string q_search = "SELECT* FROM NotAvaliableBooks WHERE HoldersId  = '" + MID + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q_search, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    DataRow dataRow = dt.Rows[0];
                }
                else
                {
                    //Notfounded
                    MessageBox.Show("Member has no books right now to handover", "LibraryPRO details");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while searching" + ex.ToString(), "Library PRO details");

            }

            finally
            {

                con.Close();

            }


            try
            {
                string q_search = "SELECT* FROM ReservBooks WHERE HoldersId  = '" + MID + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q_search, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    DataTable dtm = new DataTable();
                    dtm.Load(reader);

                    //Add to data grid view
                    dataGridView2.DataSource = dtm;
                    DataRow dataRow = dtm.Rows[0];
                }
                else
                {
                    //Notfounded
                    MessageBox.Show("Member has no reserved books right now to burrow ", "LibraryPRO details");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while searching" + ex.ToString(), "Library PRO details");

            }

            finally
            {

                con.Close();

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Members WHERE MembersId = @memid", con);
                cmd.Parameters.AddWithValue("@memid", txtMID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);

            }

            finally
            {
                //Close the connection
                con.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the data from the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string bookId = selectedRow.Cells["BookId"].Value.ToString();
                string bookname = selectedRow.Cells["BookName"].Value.ToString();
                string holder = selectedRow.Cells["Holder"].Value.ToString();
                string holdersid = selectedRow.Cells["HoldersId"].Value.ToString();

                // Create an instance of LostBooks form and pass the data to its constructor
                LostBooks lostBooksForm = new LostBooks(bookId, bookname, holder, holdersid);
                lostBooksForm.Show();

                // Optionally hide or close Form1
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtMID.Clear();
            txtName.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            modules mod = new modules(); // to second form
            mod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the data from the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string bookId = selectedRow.Cells["BookId"].Value.ToString();
                string DHO = selectedRow.Cells["DayToHandover"].Value.ToString();
                string bookname = selectedRow.Cells["BookName"].Value.ToString();
                // string holder = selectedRow.Cells["Holder"].Value.ToString();
                string holdersid = selectedRow.Cells["HoldersId"].Value.ToString();

                // Create an instance of LostBooks form and pass the data to its constructor
                AcceptBooks acceptBooksForm = new AcceptBooks(bookId, holdersid, DHO, bookname);
                acceptBooksForm.Show();

                // Optionally hide or close Form1
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
