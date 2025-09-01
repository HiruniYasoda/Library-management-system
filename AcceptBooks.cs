using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lms_first_try
{
    public partial class AcceptBooks : Form
    {
        public AcceptBooks(string bookId, string holdersid, string DTH, string bookname) //get data from privious form
        {
            InitializeComponent();

            //fill textfields
            txtBookId.Text = bookId;
            textBox1.Text = bookname;
            //txtLastHolder.Text = holder;
            txtMID.Text = holdersid;
            textBox3.Text = DTH;
        }
        public AcceptBooks()
        {
            InitializeComponent();
        }

        private void AcceptBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Fine where MembersId = @holdersid";
            cmd.Parameters.AddWithValue("@holdersid", txtMID.Text.Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No fine records found for this member.");
            }


            DateTime dth = Convert.ToDateTime(textBox3.Text);
            if (DateTime.Now > dth)
            {
                pictureBox4.BackColor = System.Drawing.Color.DarkRed;
                label1.BackColor = System.Drawing.Color.IndianRed;
                label2.BackColor = System.Drawing.Color.IndianRed;
                label3.BackColor = System.Drawing.Color.IndianRed;
                label4.BackColor = System.Drawing.Color.IndianRed;
                button3.BackColor = System.Drawing.Color.IndianRed;
                button4.BackColor = System.Drawing.Color.IndianRed;


                TimeSpan delayDays = DateTime.Now - dth;
                double dDays = delayDays.TotalDays;

                int delay = Convert.ToInt32(dDays);

                string delaytext = delay.ToString();
                label4.Text = delaytext + " Days";


                int DDay, Amount, Fine;

                //Assigning the values
                DDay = int.Parse(delaytext);
                Amount = 4;

                //Find the amount
                Fine = DDay * Amount;

                //Display the amount
                string finetext = Fine.ToString();
                label3.Text = finetext + " Rs";


            }
            else
            {

                pictureBox4.BackColor = System.Drawing.Color.OliveDrab;
                //MessageBox.Show(" There is no dalay !! ", " LibPRO Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void btnSearch_Click(object sender, EventArgs e)

        {
            //SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter adamp;
            SqlDataReader read;
            string q_insert;
            string delet;
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            try
            {

                con.Open();
                delet = "DELETE FROM NotAvaliableBooks WHERE BookId = @BookId";
                cmd = new SqlCommand(delet, con);
                //SqlCommand cmd = new SqlCommand("DELETE FROM NotAvaliableBooks WHERE BookId = @BookId", con);
                cmd.Parameters.AddWithValue("@BookId", txtBookId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book accepted successfully");
                con.Close();

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

        private void button4_Click(object sender, EventArgs e)
        {

            // Connection string for your database
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            try
            {
                // Open the connection
                con.Open();

                // Delete the book from NotAvailableBooks
                string delet = "DELETE FROM NotAvaliableBooks WHERE BookId = @BookId";
                using (SqlCommand cmdDelete = new SqlCommand(delet, con))
                {
                    cmdDelete.Parameters.AddWithValue("@BookId", txtBookId.Text);
                    cmdDelete.ExecuteNonQuery();
                }

                // Query to fetch the member's name
                string membersName = string.Empty;
                string memid = txtMID.Text.Trim();
                string query = "SELECT FullName FROM Members WHERE MembersId = @memid";

                using (SqlCommand cmdSelect = new SqlCommand(query, con))
                {
                    cmdSelect.Parameters.AddWithValue("@memid", memid);
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            membersName = reader["FullName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Member not found!", "Error");
                            return; // Exit the method if the member is not found
                        }
                    }
                }

                // Insert fine record into the Fine table
                string bookid = txtBookId.Text.Trim();
                string book = textBox1.Text.Trim();
                string fine = label3.Text.Trim();
                string reason = "Delay to handover";
                string Date = DateTime.Now.ToString();

                string q_inserts = "INSERT INTO Fine (MemberName, MembersId, Book, BookId, Fine, Date, Reason) " +
                                   "VALUES (@membersName, @memid, @book, @bookid, @fine, @date, @reason)";

                using (SqlCommand cmdInsert = new SqlCommand(q_inserts, con))
                {
                    cmdInsert.Parameters.AddWithValue("@membersName", membersName);
                    cmdInsert.Parameters.AddWithValue("@memid", memid);
                    cmdInsert.Parameters.AddWithValue("@book", book);
                    cmdInsert.Parameters.AddWithValue("@bookid", bookid);
                    cmdInsert.Parameters.AddWithValue("@fine", fine);
                    cmdInsert.Parameters.AddWithValue("@date", Date);
                    cmdInsert.Parameters.AddWithValue("@reason", reason);

                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Fine payment is successful!", "LibraryPRO details");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter adamp;
            SqlDataReader read;
            string q_insert;
            string delet;
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            try
            {

                con.Open();
                delet = "DELETE FROM NotAvaliableBooks WHERE BookId = @BookId";
                cmd = new SqlCommand(delet, con);
                //SqlCommand cmd = new SqlCommand("DELETE FROM NotAvaliableBooks WHERE BookId = @BookId", con);
                cmd.Parameters.AddWithValue("@BookId", txtBookId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Accepted without fine successfully");
                con.Close();

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandOver mod = new HandOver(); // to second form
            mod.Show();
            this.Close();
        }
    }
}
