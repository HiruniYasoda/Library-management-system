using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace lms_first_try
{



    public partial class members : Form
    {
        public members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            modules modules = new modules(); // to second form
            modules.Show();
            //modules mod = new modules(); // to second form
            //mod.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            contextMenuStrip1.Show(button2, new Point(0, button2.Height));


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void searchMembersActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersActivity memac = new MembersActivity (); // to second form
            memac.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void members_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if  //Not accepting null values
              (string.IsNullOrWhiteSpace(txtFullName.Text) ||
               string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtNIC.Text) ||
               string.IsNullOrWhiteSpace(txtAddress.Text) ||
               string.IsNullOrWhiteSpace(txtContact.Text) ||
               string.IsNullOrWhiteSpace(txtDarantor.Text) ||
               string.IsNullOrWhiteSpace(txtGancon.Text) ||
               string.IsNullOrWhiteSpace(txtMID.Text))
            {
                MessageBox.Show("Requested details are not completed. Please complete them and try again", "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Else save 
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter adamp;
                SqlDataReader read;
                string q_insert;

                String sql;
                con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

                try
                {
                    string FullName = txtFullName.Text; //Take details
                    string Name = txtName.Text;
                    string NIC = txtNIC.Text;
                    string Address = txtAddress.Text;
                    string Gender;

                    if (cbMale.Checked)
                    {
                        Gender = "Male";
                    }

                    else if (cbFemale.Checked)
                    {
                        Gender = "Female";
                    }
                    else
                    {
                        Gender = "Not given";
                    }
                    string DateOfBirth = dtpDOB.Value.ToShortDateString();
                    string ContactNumber = txtContact.Text;
                    string Email = txtEmail.Text;
                    string Garantor = txtDarantor.Text;
                    string GrantorContactNumber = txtGancon.Text;
                    string MembersId = txtMID.Text;
                    string DateOfReg = DateTime.Now.ToString();

                    //Sql query

                    q_insert = "insert into Members values ('" + FullName + "','" + Name + "','" + NIC + "','" + Address + "','" + Gender + "','" + DateOfBirth + "','" + ContactNumber + "','" + Email + "','" + Garantor + "','" + GrantorContactNumber + "','" + MembersId + "','" + DateOfReg + "')";

                    //Sql Command
                    cmd = new SqlCommand(q_insert, con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Member registration success!! ", "LibraryPRO details");
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

        private void btnclear_Click(object sender, EventArgs e)
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
            cbMale.Checked = false;
            cbFemale.Checked = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
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
            cbMale.Checked = false;
            cbFemale.Checked = false;

        }

        private void searchMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMembers srmem = new SearchMembers(); // to second form
            srmem.Show();
            //this.Hide();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }
    }

    //internal class SqlCommand









}

