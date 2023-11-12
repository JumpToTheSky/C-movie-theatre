using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMovieApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm form3 = new SearchForm();
            form3.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailForm detail = new DetailForm();
            detail.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
