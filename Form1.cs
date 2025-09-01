using System.Reflection;
using System.Xml.Linq;

namespace lms_first_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!(txtUserName.Text == "" && txtPW.Text == "")) //UserName & PW not null
            {

                if (txtUserName.Text == "Admin" && txtPW.Text == "Lib123")
                {

                    MessageBox.Show("Welcome to Library_PRO", "LoginDetails", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    modules modules = new modules(); // to second form
                    modules.Show();

                }
                else
                {

                    

                    txtUserName.Focus(); //select the username
                    txtUserName.SelectAll();

                    txtPW.Clear();
                }
            }
            else
            {

                MessageBox.Show(" Please enter the username and password", "LoginDetails", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation); //Fields null 
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
