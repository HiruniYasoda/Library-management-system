using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lms_first_try
{
    public partial class SearchBooks : Form
    {
        public SearchBooks()
        {
            InitializeComponent();
        }

        private void BookUsage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Link database
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            string BookName = txtBookName.Text.Trim();
            string BookId = txtBookId.Text.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(BookName) && string.IsNullOrWhiteSpace(BookId))//Check not null
                {
                    MessageBox.Show("Please enter a Name or valid ID", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(BookName))
                    {
                        string q_search = "SELECT * FROM  Books WHERE BookId = '" + BookId + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.HasRows)
                        {
                            reader.Read();

                            txtBookName.Text = reader["BookName"].ToString();
                            txtAuthor.Text = reader["Author"].ToString();
                            txtPublisher.Text = reader["Publisher"].ToString();
                            txtPages.Text = reader["Pages"].ToString();
                            DateTime dtpDOA = (DateTime)reader["Date"];
                            cbCat.Text = reader["Category"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Sorry ! There is no book to the given ID ", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
                        }
                    }

                    else
                    {
                        string q_search = "SELECT * FROM  Books WHERE BookName = '" + BookName + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.HasRows)
                        {
                            reader.Read();

                            txtBookId.Text = reader["BookId"].ToString();
                            txtAuthor.Text = reader["Author"].ToString();
                            txtPublisher.Text = reader["Publisher"].ToString();
                            txtPages.Text = reader["Pages"].ToString();
                            DateTime dtpDOA = (DateTime)reader["Date"];
                            cbCat.Text = reader["Category"].ToString();

                        }

                        else
                        {
                            MessageBox.Show("Sorry ! There is no member with given Member ID ", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }


                }
            }
            catch
            {
                MessageBox.Show("Error while searching" + "Library PRO details");

            }
            finally
            {
                con.Close();
            }

            try
            {
                string q_search = "SELECT * FROM  NotAvaliableBooks WHERE BookId = '" + BookId + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q_search, con);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    txtAvail.Text = "NO";

                }
                else
                {
                    txtAvail.Text = "Yes";
                }
            }
            catch
            {
                MessageBox.Show("Error while searching" + "Library PRO details");

            }
            finally { con.Close(); }

            try
            {
                string q_search = "SELECT * FROM  ReservBooks WHERE BookId = '" + BookId + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q_search, con);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    txtReserv.Text = "Reserved";

                }
                else
                {
                    txtReserv.Text = "Not reserved";
                }
            }
            catch
            {
                MessageBox.Show("Error while searching" + "Library PRO details");

            }
            finally { con.Close(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //Clear record 
            txtBookName.Clear();
            txtBookId.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtPages.Clear();
            dtpDOA.ResetText();
            cbCat.ResetText();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookName = @BookName, BookId = @BookId, Author = @Author, Publisher = @Publisher, Pages = @Pages, Date = @Date, Category = @Category WHERE BookId = @BookId", con);
                //cmd.Parameters.AddWithValue("@MembersId", int.Parse(txtMID.Text));
                cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                cmd.Parameters.AddWithValue("@BookId", txtBookId.Text);
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@Pages", txtPages.Text);
                cmd.Parameters.AddWithValue("@Date", dtpDOA.Value);
                cmd.Parameters.AddWithValue("@Category", cbCat.Text);

                cmd.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("Data updated successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE BookId = @BookId", con);
                cmd.Parameters.AddWithValue("@BookId", txtBookId.Text);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            modules mod = new modules(); // to second form
            mod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txtAvail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
