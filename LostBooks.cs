using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lms_first_try
{

    public partial class LostBooks : Form
    {
        public LostBooks()
        {
            InitializeComponent();
        }
        public LostBooks(string bookId, string bookname, string holder, string holdersid)//get data from privious form
        {
            InitializeComponent();

            //fill textfields
            txtBookId.Text = bookId;
            txtBookName.Text = bookname;
            txtLastHolder.Text = holder;
            txtLastHoldersId.Text = holdersid;
        }


        private void LostBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");
            string Bookid = txtBookId.Text.Trim();

            try
            {
                //Fill textboxes

                if (string.IsNullOrWhiteSpace(Bookid))
                {
                    MessageBox.Show("A book is not selected.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                else
                {
                    //fill other txtfields with bookid
                    string q_searchs = "SELECT Author, Category, Pages FROM Books WHERE BookId = '" + Bookid + "'";
                    con.Open();
                    SqlCommand cmds = new SqlCommand(q_searchs, con);
                    SqlDataReader readers = cmds.ExecuteReader();


                    if (readers.HasRows)
                    {
                        readers.Read();

                        txtAuthor.Text = readers["Author"].ToString();
                        txtPages.Text = readers["Pages"].ToString();
                        txtCategory.Text = readers["Category"].ToString();
                        txtFine.Text = readers["Pages"].ToString();

                    }

                    else
                    {
                        MessageBox.Show("Sorry ! There is no book with given id ", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;//MSG box
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while filling " + ex.ToString(), "Library PRO details");
            }

            finally
            {
                con.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LostBooks WHERE BookId = @bookid", con);
                cmd.Parameters.AddWithValue("@bookid", txtBookId.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Deleting" + ex);

            }

            finally
            {
                //Close the connection
                con.Close();

            }
        }

        private void txtFine_TextChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            modules mod = new modules();
            mod.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button2, new Point(0, button2.Height));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if  //Not accepting null values
              (string.IsNullOrWhiteSpace(txtBookName.Text) ||
               string.IsNullOrWhiteSpace(txtBookId.Text) ||
               string.IsNullOrWhiteSpace(txtLastHolder.Text) ||
               string.IsNullOrWhiteSpace(txtPages.Text))


            {
                MessageBox.Show("Requested details are not completed. Please complete them and try again", "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter adamp;
                SqlDataReader read;
                string q_insert;
                string delet;

                String sql;
                con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

                try
                {
                    string Book = txtBookName.Text;
                    string BookId = txtBookId.Text;
                    string Author = txtAuthor.Text;
                    string LastHolder = txtLastHolder.Text;
                    string LastHoldersId = txtLastHoldersId.Text;
                    string Category = txtCategory.Text;

                    int Pages;
                    int Fine;



                    if (!int.TryParse(txtFine.Text, out Fine))
                    {
                        MessageBox.Show("Please enter a valid number for Fine.");
                        return;
                    }

                    if (!int.TryParse(txtPages.Text, out Pages))
                    {
                        MessageBox.Show("Please enter a valid number for Pages.");
                        return;
                    }



                    string Date = DateTime.Now.ToString();

                    q_insert = "insert into LostBooks values ('" + Book + "','" + BookId + "','" + Author + "','" + LastHolder + "', '" + LastHoldersId + "','" + Date + "','" + Category + "'," + Pages + "," + Fine + ")";

                    //Sql Command
                    cmd = new SqlCommand(q_insert, con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Lost Book addded successfully !! ", "LibraryPRO details");
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
                    //string Author = txtAuthor.Text;
                    string LastHolder = txtLastHolder.Text;
                    string LastHoldersId = txtLastHoldersId.Text;
                    //string Category = txtCategory.Text;

                    //int Pages;
                    int Fine;



                    if (!int.TryParse(txtFine.Text, out Fine))
                    {
                        MessageBox.Show("Please enter a valid number for Fine.");
                        return;
                    }

                    //if (!int.TryParse(txtPages.Text, out Pages))
                    //{
                    //MessageBox.Show("Please enter a valid number for Pages.");
                    //return;
                    //}



                    string Date = DateTime.Now.ToString();
                    string Reason = "Lost";

                    q_insert = "insert into Fine values ('" + LastHolder + "','" + LastHoldersId + "','" + Book + "', '" + BookId + "'," + Fine + ",'" + Date + "','" + Reason + "')";

                    //Sql Command
                    cmd = new SqlCommand(q_insert, con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Lost Book addded successfully !! ", "LibraryPRO details");
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

                    con.Open();
                    delet = "DELETE FROM NotAvaliableBooks WHERE BookId = @BookId";
                    cmd = new SqlCommand(delet, con);
                    //SqlCommand cmd = new SqlCommand("DELETE FROM NotAvaliableBooks WHERE BookId = @BookId", con);
                    cmd.Parameters.AddWithValue("@BookId", txtBookId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

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

                try
                {

                    con.Open();
                    delet = "DELETE FROM Books WHERE BookId = @BookId";
                    cmd = new SqlCommand(delet, con);
                    //SqlCommand cmd = new SqlCommand("DELETE FROM NotAvaliableBooks WHERE BookId = @BookId", con);
                    cmd.Parameters.AddWithValue("@BookId", txtBookId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Lost Book addded successfully !! ", "LibraryPRO details");


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
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtFine.Clear();
            txtPages.Clear();
            txtCategory.Clear();
            txtBookId.Clear();
            txtLastHolder.Clear();
            txtLastHoldersId.Clear();
            dtpDOA.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Link database
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            string Book = txtBookName.Text.Trim();
            string BookId = txtBookId.Text.Trim();
            //string MID = txtMID.Text.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(Book) && string.IsNullOrWhiteSpace(BookId))//Check not null
                {
                    MessageBox.Show("Please enter a Name or ID of the book to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {

                    //Which option used for search (members name)
                    if (string.IsNullOrWhiteSpace(Book))
                    {
                        string q_search = "SELECT * FROM LostBooks WHERE BookId  = '" + BookId + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.HasRows)
                        {
                            reader.Read();

                            txtBookName.Text = reader["Book"].ToString();
                            //txtBookId.Text = reader["BookId"].ToString();
                            txtAuthor.Text = reader["Author"].ToString();
                            txtLastHolder.Text = reader["LastHolder"].ToString();
                            txtLastHoldersId.Text = reader["LastHoldersId"].ToString();

                            DateTime dtpDOA = (DateTime)reader["Date"];
                            txtCategory.Text = reader["Category"].ToString();
                            txtPages.Text = reader["Pages"].ToString();
                            txtFine.Text = reader["Fine"].ToString();
                            // txtGancon.Text = reader["GarantorContactNumber"].ToString();
                            //txtMID.Text = reader["MembersId"].ToString();
                            //DateTime dtpDOR = (DateTime)reader["DateOfReg"];
                        }
                        else
                        {
                            MessageBox.Show("Sorry ! There is no book with given Id ", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
                        }
                    }

                    else
                    {

                        string q_search = "SELECT * FROM LostBooks WHERE Book = '" + Book + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            //txtBookName.Text = reader["Book"].ToString();
                            txtBookId.Text = reader["BookId"].ToString();
                            txtAuthor.Text = reader["Author"].ToString();
                            txtLastHolder.Text = reader["LastHolder"].ToString();
                            txtLastHoldersId.Text = reader["LastHoldersId"].ToString();

                            DateTime dtpDOA = (DateTime)reader["Date"];
                            txtCategory.Text = reader["Category"].ToString();
                            txtPages.Text = reader["Pages"].ToString();
                            txtFine.Text = reader["Fine"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Sorry ! There is no member with given name ", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
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

        }

        private void searchAvaliailityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FineHistory mod = new FineHistory(); // to second form
            mod.Show();
            this.Close();
        }

        private void searchHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LostHistory mod = new LostHistory(); // to second form
            mod.Show();
            this.Close();
        }
    }
}

