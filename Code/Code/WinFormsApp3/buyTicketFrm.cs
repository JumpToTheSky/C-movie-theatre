using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInDemo.DAO;
using LogInDemo.DTO;
namespace LogInDemo
{
    public partial class buyTicketFrm : Form
    {
        public User user;
        public Session session;
        public Movie movie;
        private List<string> userTicketList;
        private List<string> sessionTicketList;
        private List<string> currentTicketList;
        
        private int h;
        private int w;
        public buyTicketFrm(User user,Session session,Movie movie)
        {
            this.user = user;
            this.session = session;
            this.movie = movie;
            this.userTicketList = new List<string>();
            this.sessionTicketList = new List<string>();
            this.currentTicketList = new List<string>();
            InitializeComponent();
            
            loadSessionInfor();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadSessionInfor()
        {
            mPrice.Text = session.Price.ToString();
            mName.Text = movie.Name.ToString();
            mLen.Text = movie.Length.ToString();
            mSub.Text = session.Subtitle.ToString();
            mTime.Text = session.Date.TimeOfDay.ToString();
            mDate.Text = session.Date.Date.ToString("dd/MM/yyyy");
            mFormat.Text = session.Format.ToString();
            mTotal.Text = "0";
            mDir.Text = movie.Director.ToString();
            foreach (Ticket ticket in TicketDAO.Instance.getTicketListIn4(session.Id,user.Username))
            {
                userTicketList.Add(ticket.Chair);
            }
            foreach(Ticket ticket in TicketDAO.Instance.getTicketListFromSID(session.Id))
            {
                sessionTicketList.Add(ticket.Chair);
            }
            
        }
        private void loadTicket()
        {
            panel5.Hide();

            this.h = (int)((midFlw.Height - 16 * 6.3) / 16) + 1;
            this.w = (int)((midFlw.Width - 29 * 6.9) / 29) + 1;
            foreach (string chair in TicketDAO.Instance.getMiddleChairList())
            {
                Button bttn = new Button() { Width = this.w, Height = this.h };
                bttn.Click += Bttn_Click;
                bttn.Text = chair;
                if (userTicketList.Contains(chair))
                {
                    bttn.BackColor = Color.Yellow;
                    bttn.ForeColor = Color.Black;
                    bttn.Enabled = false;
                }
                else if (sessionTicketList.Contains(chair))
                {
                    bttn.BackColor = Color.DimGray;
                    bttn.ForeColor = Color.White;
                    bttn.Enabled = false;
                }
                else
                {
                    bttn.BackColor = Color.White;
                    bttn.ForeColor = Color.Black;
                }
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderSize = 0;
                bttn.TextAlign = ContentAlignment.MiddleLeft;
                bttn.Font = new Font("Century Gothic", 7);
                midFlw.Controls.Add(bttn);
            }
            panel5.Show();
        }
        private void loadTotal()
        {
            mTotal.Text = (currentTicketList.Count*session.Price).ToString();
            if (currentTicketList.Count == 0)
            {
                buyTicketBttn.Enabled = false;
            }
            else { buyTicketBttn.Enabled = true; }
        }
        private void Bttn_Click(object? sender, EventArgs e)
        {
            Button bttn = sender as Button;
            if (bttn.ForeColor == Color.Black)
            {
                bttn.BackColor = Color.DarkCyan;
                bttn.ForeColor = Color.White;
                currentTicketList.Add(bttn.Text);
            }
            else if (bttn.ForeColor == Color.White)
            {
                bttn.BackColor = Color.White;
                bttn.ForeColor = Color.Black;
                currentTicketList.Remove(bttn.Text);
            }
            loadTotal();
        }

        private void cancelPurBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel the order?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void buyTicketFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buyTicketFrm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void buyTicketBttn_Click(object sender, EventArgs e)
        {
            if(currentTicketList.Count==0)
            {
                MessageBox.Show("Choose your place first.");
                return;
            }
            if (cbPayment.SelectedItem == null)
            {
                MessageBox.Show("Choose your payment term.");
                return;
            }
            if (cbPayment.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Choose your payment term.");
                return;
            }
            if (MessageBox.Show("Buy the Ticket?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            string bid = generateBillID();
            string query = string.Format(@"INSERT INTO BILL VALUES('{0}','{1}','{2}',N'{3}')",bid,user.Username,session.Id,cbPayment.SelectedItem.ToString());
            DataProvider.Instance.ExcuteQuery(query);
            foreach(string chair in currentTicketList)
            {
                query = string.Format(@"INSERT INTO TICKET VALUES('{0}','{1}','{2}')",bid+chair,bid,chair);
                DataProvider.Instance.ExcuteQuery(query);
            }
            
            MessageBox.Show("Purchase successfully.");
            this.Close();
        }
        private string generateBillID()
        {
            return session.Id + (BillDAO.Instance.getBillList(session.Id).Count + 1).ToString("00000");
        }

        private void unselectBttn_Click(object sender, EventArgs e)
        {
            midFlw.Controls.Clear();
            currentTicketList.Clear();
            loadTicket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel the order?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState != FormWindowState.Maximized)
            {
                
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyTicketFrm_StyleChanged(object sender, EventArgs e)
        {

        }
    }
}
