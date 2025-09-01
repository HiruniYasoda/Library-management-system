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
using System.Xml.Linq;

namespace lms_first_try
{
    public partial class BurroBooks : Form
    {
        public BurroBooks()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if  //Not accepting null values
              (string.IsNullOrWhiteSpace(txtBookName.Text) ||
               string.IsNullOrWhiteSpace(txtBookId.Text) ||
               string.IsNullOrWhiteSpace(txtLastHolder.Text) ||
               string.IsNullOrWhiteSpace(txtLastHoldersId.Text))


            {
                MessageBox.Show("Requested details are not completed. Please complete them and try again", "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter adamp;
                SqlDataReader read;
                string q_insert, q_inserts;

                String sql;
                con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");


                try
                {
                    string Book = txtBookName.Text;
                    string BookId = txtBookId.Text;
                    string Author = txtAuthor.Text;
                    string LastHolder = txtLastHolder.Text;
                    string LastHoldersId = txtLastHoldersId.Text;
                    //string DHO = Date.dateTimePicker1.ToString();
                    //int Fine = int.Parse(txtFine.Text);
                    int Pages = int.Parse(txtPages.Text);
                    string Date = DateTime.Now.ToString();
                    string DHO = dateTimePicker1.Value.ToString();

                    //string DHO = DateTime.Now.ToString();

                    // Check if BookId exists in Books table
                    string checkBookQuery = "SELECT COUNT(*) FROM Books WHERE BookId = @BookId";
                    cmd = new SqlCommand(checkBookQuery, con);
                    cmd.Parameters.AddWithValue("@BookId", BookId);

                    con.Open();
                    int bookCount = (int)cmd.ExecuteScalar();
                    con.Close();

                    // Check if LastHoldersId exists in Students table
                    string checkStudentQuery = "SELECT COUNT(*) FROM Members WHERE MembersId = @LastHoldersId";
                    cmd = new SqlCommand(checkStudentQuery, con);
                    cmd.Parameters.AddWithValue("@LastHoldersId", LastHoldersId);

                    con.Open();
                    int studentCount = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (bookCount == 0)
                    {
                        MessageBox.Show("The book is not registered in the library management system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (studentCount == 0)
                    {
                        MessageBox.Show("The member is not registered in the library management system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {


                        //Sql query

                        q_insert = "insert into NotAvaliableBooks values ('" + BookId + "','" + Book + "','" + Author + "'," + Pages + ",'" + LastHolder + "', '" + LastHoldersId + "','" + Date + "','" + DHO + "')";
                        //q_inserts = "insert into BorrowedBookHistory values ('" + BookId + "','" + Book + "','" + Author + "'," + Pages + ",'" + LastHolder + "', '" + LastHoldersId + "','" + Date + "')";

                        //Sql Command
                        cmd = new SqlCommand(q_insert, con);
                        //cmd = new SqlCommand(q_inserts, con);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        // MessageBox.Show("Borrowed Book addded successfully !! ", "LibraryPRO details");
                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show("Error While Saving" + ex);
                }
                finally
                {
                    con.Close();

                }

                try
                {
                    string Book = txtBookName.Text;
                    string BookId = txtBookId.Text;
                    string Author = txtAuthor.Text;
                    string LastHolder = txtLastHolder.Text;
                    string LastHoldersId = txtLastHoldersId.Text;
                    //string DHO = Date.dateTimePicker1.ToString();
                    //int Fine = int.Parse(txtFine.Text);
                    int Pages = int.Parse(txtPages.Text);
                    string Date = DateTime.Now.ToString();
                    string DHO = dateTimePicker1.Value.ToString();

                    // Check if BookId exists in Books table
                    string checkBookQuery = "SELECT COUNT(*) FROM Books WHERE BookId = @BookId";
                    cmd = new SqlCommand(checkBookQuery, con);
                    cmd.Parameters.AddWithValue("@BookId", BookId);

                    con.Open();
                    int bookCount = (int)cmd.ExecuteScalar();
                    con.Close();

                    // Check if LastHoldersId exists in Students table
                    string checkStudentQuery = "SELECT COUNT(*) FROM Members WHERE MembersId = @LastHoldersId";
                    cmd = new SqlCommand(checkStudentQuery, con);
                    cmd.Parameters.AddWithValue("@LastHoldersId", LastHoldersId);

                    con.Open();
                    int studentCount = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (bookCount == 0)
                    {
                        MessageBox.Show("The book is not registered in the library management system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (studentCount == 0)
                    {
                        MessageBox.Show("The member is not registered in the library management system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {


                        //Sql query

                        //q_insert = "insert into NotAvaliableBooks values ('" + BookId + "','" + Book + "','" + Author + "'," + Pages + ",'" + LastHolder + "', '" + LastHoldersId + "','" + Date + "','" + DHO + "')";
                        q_inserts = "insert into BorrowedBookHistory values ('" + BookId + "','" + Book + "','" + Author + "'," + Pages + ",'" + LastHolder + "', '" + LastHoldersId + "','" + Date + "')";

                        //Sql Command
                        // cmd = new SqlCommand(q_insert, con);
                        cmd = new SqlCommand(q_inserts, con);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Borrowed Book addded successfully !! ", "LibraryPRO details");
                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show("Error While Saving" + ex);
                }
                finally
                {
                    con.Close();

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            modules mod = new modules(); // to second form
            mod.Show();
            this.Close();
        }

        private void BurroBooks_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt"; // Example format

        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookId_KeyDown(object sender, KeyEventArgs e)
        {
            //SqlConnection con;
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                string bookId = txtBookId.Text.Trim(); // Get the entered Book ID

                // Validate Book ID
                if (string.IsNullOrEmpty(bookId))
                {
                    MessageBox.Show("Please enter a valid Book ID.", "Validation Error");
                    return;
                }

                // Database connection string
                //con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

                string connectionString = "Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False";

                // Query to fetch book details
                string querys = "SELECT * FROM NotAvaliableBooks WHERE BookID = @BookID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(querys, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookId); // Parameterize query

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read()) // If a record is found
                            {
                                MessageBox.Show("This book is not currently avaliable in the library");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }





                string query = "SELECT BookName, Author, Pages FROM Books WHERE BookID = @BookID";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookId); // Parameterize query

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read()) // If a record is found
                            {
                                txtBookName.Text = reader["BookName"].ToString();
                                txtAuthor.Text = reader["Author"].ToString();
                                txtPages.Text = reader["Pages"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No book found with the given Book ID.", "Not Found");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }

        }

        private void txtLastHoldersId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                string holId = txtLastHoldersId.Text.Trim(); // Get the entered Book ID

                // Validate Book ID
                if (string.IsNullOrEmpty(holId))
                {
                    MessageBox.Show("Please enter a valid Members ID.", "Validation Error");
                    return;
                }


                string connectionString = "Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False";

                // Query to fetch book details
                string query = "SELECT Name FROM Members  WHERE MembersId = @HolID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@HolID", holId); // Parameterize query

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read()) // If a record is found
                            {
                                txtLastHolder.Text = reader["Name"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("No Member found with the given Members ID.", "Not Found");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtLastHolder.Clear();
            txtLastHoldersId.Clear();
            txtPages.Clear();
            txtAuthor.Clear();
            dtpDOA.ResetText();
            dateTimePicker1.ResetText();

        }

        private void searchHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchAvaliailityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowedHistory mem = new BorrowedHistory(); // to second form
            mem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button2, new Point(0, button2.Height));
        }
    }

}
