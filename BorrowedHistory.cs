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
    public partial class BorrowedHistory : Form
    {
        public BorrowedHistory()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BorrowedHistory));
            btnSearch = new Button();
            label6 = new Label();
            txtName = new TextBox();
            lblNIC = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1615, 186);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(196, 62);
            btnSearch.TabIndex = 118;
            btnSearch.Text = " 🔍 Search\r\n";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.LightSlateGray;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(409, 24);
            label6.Name = "label6";
            label6.Size = new Size(1307, 97);
            label6.TabIndex = 117;
            label6.Text = "Not avilable books";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtName.Location = new Point(657, 198);
            txtName.Name = "txtName";
            txtName.Size = new Size(839, 30);
            txtName.TabIndex = 115;
            // 
            // lblNIC
            // 
            lblNIC.BackColor = Color.LightSlateGray;
            lblNIC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(302, 198);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(326, 43);
            lblNIC.TabIndex = 113;
            lblNIC.Text = "Book Id";
            lblNIC.TextAlign = ContentAlignment.MiddleLeft;
            lblNIC.Click += lblNIC_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.LightSlateGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Brown;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 24);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(115, 97);
            button1.TabIndex = 110;
            button1.Text = " ←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightSlateGray;
            pictureBox2.Location = new Point(9, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1907, 153);
            pictureBox2.TabIndex = 109;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSlateGray;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1906, 120);
            pictureBox1.TabIndex = 108;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.SlateGray;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(20, 140);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(168, 153);
            pictureBox3.TabIndex = 119;
            pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 330);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1894, 500);
            dataGridView1.TabIndex = 120;
            // 
            // BorrowedHistory
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(lblNIC);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BorrowedHistory";
            Load += BorrowedHistory_Load;
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnSearch;
        private Label label6;
        private TextBox txtName;
        private Label lblNIC;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;

        private void lblNIC_Click(object sender, EventArgs e)
        {

        }

        private void BorrowedHistory_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BurroBooks mem = new BurroBooks(); // to second form
            mem.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=HIRUNI;Initial Catalog=LibMSysFirstTry;Integrated Security=True;Encrypt=False");

            
            string BookID = txtName.Text.Trim();
            try
            {

                if (string.IsNullOrWhiteSpace(BookID))//Check not null for id / name
                {
                    MessageBox.Show("Please enter a Book Id to search.", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {

                        string q_searchs = "SELECT * FROM NotAvaliableBooks WHERE BookId = '" + BookID + "'";
                        con.Open();
                        SqlCommand cmds = new SqlCommand(q_searchs, con);
                        SqlDataReader readers = cmds.ExecuteReader();


                        if (readers.HasRows)//Fill name coz' to fill data grid views
                        {
                        DataTable dt = new DataTable();
                        dt.Load(readers);
                        dataGridView1.DataSource = dt;
                        DataRow dataRow = dt.Rows[0];


                    }

                        else
                        {
                            MessageBox.Show("Sorry ! There is no members with given name", "Search Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;//MSG box
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
    }
}
