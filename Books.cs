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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            contextMenuStrip1.Show(button2, new Point(0, button2.Height));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if  //Not accepting null values
              (string.IsNullOrWhiteSpace(txtBookName.Text) ||
               string.IsNullOrWhiteSpace(txtAuthor.Text) ||
               string.IsNullOrWhiteSpace(txtPublisher.Text) ||
               string.IsNullOrWhiteSpace(txtBookId.Text) ||
               string.IsNullOrWhiteSpace(cbCat.Text))

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
                    string BookName = txtBookName.Text; //Take details
                    string Author = txtAuthor.Text;
                    string Publisher = txtPublisher.Text;
                    string BookId = txtBookId.Text;
                    string Category = cbCat.Text;
                    //int Pages = txtPages.Text.;
                    int Pages = int.Parse(txtPages.Text);
                    string Date = DateTime.Now.ToString();

                    //Sql query

                    q_insert = "insert into Books values ('" + BookName + "','" + BookId + "','" + Author + "','" + Publisher + "','" + Date + "','" + Category + "'," + Pages + ")";

                    //Sql Command
                    cmd = new SqlCommand(q_insert, con);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Book addded successfully !! ", "LibraryPRO details");
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
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtPages.Clear();
            cbCat.ResetText();
            txtBookId.Clear();
            dtpDOA.ResetText();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtPages.Clear();
            cbCat.ResetText();
            txtBookId.Clear();
            dtpDOA.ResetText();
        }

        private void searchHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBooks buse = new SearchBooks(); // to second form
            buse.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modules mod = new modules(); // to second form
            mod.Show();
            this.Hide();
        }

        private void searchAvaliailityToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            BookUsage buse = new BookUsage(); // to second form
            buse.Show();
        }

        private void addToBookStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width),
                Convert.ToInt32(0.5 * workingRectangle.Height));
            this.Location = new System.Drawing.Point(10, 10);
        }
    }
}
