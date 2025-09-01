using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace lms_first_try
{
    public partial class SearchMembers : Form
    {
        public SearchMembers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Link database
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            string MembersName = txtFullName.Text.Trim();
            string NIC = txtNIC.Text.Trim();
            string MID = txtMID.Text.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(MembersName) && string.IsNullOrWhiteSpace(NIC) && string.IsNullOrWhiteSpace(MID))//Check not null
                {
                    MessageBox.Show("Please enter a Name, ID, or NIC to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {

                    //Which option used for search (members name)
                    if (string.IsNullOrWhiteSpace(NIC) && string.IsNullOrWhiteSpace(MID))
                    {
                        string q_search = "SELECT * FROM Members WHERE FullName = '" + MembersName + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.HasRows)
                        {
                            reader.Read();

                            txtName.Text = reader["Name"].ToString();
                            txtNIC.Text = reader["NIC"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtGender.Text = reader["Gender"].ToString();
                            DateTime dtpDOB = (DateTime)reader["DateOfBirth"];
                            txtContact.Text = reader["ContactNumber"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtDarantor.Text = reader["Garantor"].ToString();
                            txtGancon.Text = reader["GarantorContactNumber"].ToString();
                            txtMID.Text = reader["MembersId"].ToString();
                            DateTime dtpDOR = (DateTime)reader["DateOfReg"];
                        }
                        else
                        {
                            MessageBox.Show("Sorry ! There is no members with given name", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
                        }
                    }

                    else if (string.IsNullOrWhiteSpace(MembersName) && string.IsNullOrWhiteSpace(MID))
                    {

                        string q_search = "SELECT * FROM Members WHERE NIC = '" + NIC + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            txtFullName.Text = reader["FullName"].ToString();
                            txtName.Text = reader["Name"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtGender.Text = reader["Gender"].ToString();
                            DateTime dtpDOB = (DateTime)reader["DateOfBirth"];
                            txtContact.Text = reader["ContactNumber"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtDarantor.Text = reader["Garantor"].ToString();
                            txtGancon.Text = reader["GarantorContactNumber"].ToString();
                            //int txtMID = (int)reader[10]; int.Parse(txtMID.ToString());
                            txtMID.Text = reader["MembersId"].ToString();
                            DateTime dtpDOR = (DateTime)reader["DateOfReg"];

                        }
                        else
                        {
                            MessageBox.Show("Sorry ! There is no member with given NIC", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    else

                    {
                        string q_search = "SELECT * FROM Members WHERE MembersId = '" + MID + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(q_search, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtFullName.Text = reader["FullName"].ToString();
                            txtName.Text = reader["Name"].ToString();
                            txtNIC.Text = reader["NIC"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtGender.Text = reader["Gender"].ToString();
                            DateTime dtpDOB = (DateTime)reader["DateOfBirth"];
                            txtContact.Text = reader["ContactNumber"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtDarantor.Text = reader["Garantor"].ToString();
                            txtGancon.Text = reader["GarantorContactNumber"].ToString();
                            //int txtMID = (int)reader[10]; int.Parse(txtMID.ToString());
                            DateTime dtpDOR = (DateTime)reader["DateOfReg"];
                        }
                        else
                        {
                            MessageBox.Show("Sorry ! There is no member with given Member ID ", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            members mem = new members(); // to second form
            mem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button2, new Point(0, button2.Height));

        }

        private void searchMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            members mem = new members(); // to second form
            mem.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear record 
            txtFullName.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtMID.Clear();
            txtNIC.Clear();
            txtDarantor.Clear();
            txtGancon.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            dtpDOB.ResetText();
            dtpDOR.ResetText();
            txtGender.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Clear record 
            txtFullName.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtMID.Clear();
            txtNIC.Clear();
            txtDarantor.Clear();
            txtGancon.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            dtpDOB.ResetText();
            dtpDOR.ResetText();
            txtGender.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            modules mod = new modules(); // to second form
            mod.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");
            try
            {


                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Members SET FullName = @FullName, Name = @Name, NIC = @NIC, Address = @Address, Gender = @Gender, DateOfBirth = @DateOfBirth, ContactNumber = @ContactNumber, Email = @Email, Garantor = @Garantor, GarantorContactNumber = @GarantorContactNumber, MembersId = @MembersId, DateOfReg = @DateOfReg WHERE MembersId = @MembersId", con);
                //cmd.Parameters.AddWithValue("@MembersId", int.Parse(txtMID.Text));
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Garantor", txtDarantor.Text);
                cmd.Parameters.AddWithValue("@GarantorContactNumber", txtGancon.Text);
                cmd.Parameters.AddWithValue("@MembersId", txtMID.Text);
                cmd.Parameters.AddWithValue("@DateOfReg", dtpDOR.Value);

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

        private void SearchMembers_Load(object sender, EventArgs e)
        {
            //modules mod = new modules(); // to second form
            //mod.Show();
        }

        private void searchMembersActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MembersActivity memac = new MembersActivity(); // to second form
            memac.Show();
        }
    }
}
