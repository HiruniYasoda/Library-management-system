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
    public partial class BookUsage : Form
    {
        public BookUsage()
        {
            InitializeComponent();
        }

        private void BookUsage_Load(object sender, EventArgs e)
        {
            //First datagrideview
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM BorrowedBookHistory";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds = new DataSet());

            dataGridView1.DataSource = ds.Tables[0];

            //Fill second gridview
            SqlConnection conm = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            conm.Open();
            SqlCommand cmdm = conm.CreateCommand();
            cmdm.Connection = conm;

            cmdm.CommandText = "SELECT * FROM ReservedHistory";
            SqlDataAdapter dam = new SqlDataAdapter(cmdm);
            DataSet dsm = new DataSet();
            dam.Fill(dsm = new DataSet());

            dataGridView4.DataSource = dsm.Tables[0];

            //First datagrideview
            SqlConnection cons = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            cons.Open();
            SqlCommand cmds = cons.CreateCommand();
            cmds.Connection = cons;

            cmds.CommandText = "SELECT * FROM Fine";
            SqlDataAdapter das = new SqlDataAdapter(cmds);
            DataSet dss = new DataSet();
            das.Fill(dss = new DataSet());

            dataGridView3.DataSource = dss.Tables[0];

            //Fill second gridview
            SqlConnection conl = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            conl.Open();
            SqlCommand cmdl = conl.CreateCommand();
            cmdl.Connection = conl;

            cmdl.CommandText = "SELECT * FROM NotAvaliableBooks";
            SqlDataAdapter dal = new SqlDataAdapter(cmdl);
            DataSet dsl = new DataSet();
            dal.Fill(dsl = new DataSet());

            dataGridView2.DataSource = dsl.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            string BookName = txtBookName.Text.Trim();
            string BookID = txtBookId.Text.Trim();
            try
            {

                if (string.IsNullOrWhiteSpace(BookName) && string.IsNullOrWhiteSpace(BookID))//Check not null for id / name
                {
                    MessageBox.Show("Please enter a Name or Book Id to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {


                    if (string.IsNullOrWhiteSpace(BookID)) // uf name is used for searching
                    {
                        string q_searchs = "SELECT BookId FROM Books WHERE BookName = '" + BookName + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows)//Fill name coz' to fill data grid views
                        {
                            readers.Read();

                            txtBookId.Text = readers["BookId"].ToString();
                        }

                        else
                        {
                            MessageBox.Show("Sorry ! There is no book with given name", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
                        }
                    }

                    else //if the Id was given
                    {
                        string q_searchs = "SELECT BookName FROM Books WHERE BookId = '" + BookID + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows) // Fill the name fiels too
                        {
                            readers.Read();

                            txtBookName.Text = readers["BookName"].ToString();
                        }

                        else
                        {
                            MessageBox.Show("Sorry ! There is no book with given Book Id", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


            try // fill 1st data grid views according to the id 
            {
                string q_search = "SELECT* FROM BorrowedBookHistory WHERE BookId  = '" + BookID + "'";
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
                    //MessageBox.Show("Member has no books right now to handover", "LibraryPRO details");

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


            try // Fill the 2nd data grid view
            {
                string q_search = "SELECT* FROM ReservedHistory WHERE BookId  = '" + BookID + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q_search, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    DataTable dtm = new DataTable();
                    dtm.Load(reader);

                    //Add to data grid view
                    dataGridView4.DataSource = dtm;
                    DataRow dataRow = dtm.Rows[0];
                }
                else
                {
                    //Notfounded
                    //MessageBox.Show("Member has no reserved books right now to burrow ", "LibraryPRO details");

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

            try // Fill the 3rd data grid view
            {
                string q_search = "SELECT* FROM Fine WHERE BookId  = '" + BookID + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(q_search, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    DataTable dtm = new DataTable();
                    dtm.Load(reader);

                    //Add to data grid view
                    dataGridView3.DataSource = dtm;
                    DataRow dataRow = dtm.Rows[0];
                }
                else
                {
                    //Notfounded
                    //MessageBox.Show("Member has no reserved books right now to burrow ", "LibraryPRO details");

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

            try // Fill the 4th data grid view
            {
                string q_search = "SELECT* FROM NotAvaliableBooks WHERE BookId  = '" + BookID + "'";
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
                    MessageBox.Show("Members past activities loaded succesfully! ", "LibraryPRO details");

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books books = new Books(); 
            books.Show();
            this.Close();
        }
    }
}
