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
    public partial class MembersActivity : Form
    {
        public MembersActivity()
        {
            InitializeComponent();
        }

        private void MembersActivity_Load(object sender, EventArgs e)
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

            dataGridView2.DataSource = dsm.Tables[0];

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

            cmdl.CommandText = "SELECT * FROM DestroyedBooks";
            SqlDataAdapter dal = new SqlDataAdapter(cmdl);
            DataSet dsl = new DataSet();
            dal.Fill(dsl = new DataSet());

            dataGridView4.DataSource = dsl.Tables[0];


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            string MembersName = txtName.Text.Trim();
            string MID = txtMID.Text.Trim();
            try
            {

                if (string.IsNullOrWhiteSpace(MembersName) && string.IsNullOrWhiteSpace(MID))//Check not null for id / name
                {
                    MessageBox.Show("Please enter a Name or Members Id to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {


                    if (string.IsNullOrWhiteSpace(MID)) // uf name is used for searching
                    {
                        string q_searchs = "SELECT MembersId FROM Members WHERE Name = '" + MembersName + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows)//Fill name coz' to fill data grid views
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

                    else //if the Id was given
                    {
                        string q_searchs = "SELECT Name FROM Members WHERE MembersId = '" + MID + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows) // Fill the name fiels too
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


            try // fill 1st data grid views according to the id 
            {
                string q_search = "SELECT* FROM BorrowedBookHistory WHERE HoldersId  = '" + MID + "'";
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
                string q_search = "SELECT* FROM ReservedHistory WHERE MembersId  = '" + MID + "'";
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
                string q_search = "SELECT* FROM Fine WHERE MembersId  = '" + MID + "'";
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
                string q_search = "SELECT* FROM DestroyedBooks WHERE MembersId  = '" + MID + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            modules mem = new modules(); // to second form
            mem.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtMID.Clear();
            txtName.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtMID.Clear();
            txtName.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button3, new Point(0, button3.Height));

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

            modules mem = new modules(); // to second form
            mem.Show();
            this.Close();
        }

        private void membersInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SearchMembers mem = new SearchMembers(); // to second form
            mem.Show();
            this.Close();
        }

        private void reservedBookHIstoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
