using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lms_first_try
{
    public partial class modules : Form
    {
        public modules()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {


        }

        private void modules_Load(object sender, EventArgs e)
        {
            //this.Close();

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {


            axWindowsMediaPlayer1.URL = @"E:\final project\lms_first_try\img\Books Design.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play(); // Play the video
            axWindowsMediaPlayer1.settings.autoStart = true; // Ensure auto-start is enabled
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            members mem = new members(); // to second form
            mem.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            members mem = new members(); // to second form
            mem.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Books books = new Books(); // to second form
            books.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BurroBooks bbooks = new BurroBooks(); // to second form
            bbooks.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandOver books = new HandOver(); // to second form
            books.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LostBooks mod = new LostBooks(); // to second form
            mod.Show();
            this.Hide();
        }
    }
}

