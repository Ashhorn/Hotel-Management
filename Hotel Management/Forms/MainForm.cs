using Hotel;
using Hotel_Management.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class MainForm : Form
    {
        public RoomUC RoomUC { get; set; }
        public MainForm()
        {
            InitializeComponent();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DashboardUC dashboard = new DashboardUC();
            mainformpanel.Controls.Add(dashboard);
            dashboard.BringToFront();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("MMMM-dd-yyy hh:mm:ss tt");
        }
        
        private void label5_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Hide();
                FormLogin fd = new FormLogin();
                fd.ShowDialog();
            }
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            RateUC rate = new RateUC();
            if (!mainformpanel.Contains(rate))
            {
                mainformpanel.Controls.Add(rate);
            }
            rate.BringToFront();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            RoomUC room = new RoomUC(this);
            if (!mainformpanel.Contains(room))
            {
                mainformpanel.Controls.Add(room);
            }
            room.BringToFront();
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            ReservationUC reservation = new ReservationUC();
            if (!mainformpanel.Contains(reservation))
            {
                mainformpanel.Controls.Add(reservation);
            }
            reservation.BringToFront();
        }

        private void buttonFrontdesk_Click(object sender, EventArgs e)
        {
            frontdeskUC frontdesk = new frontdeskUC();
            if (!mainformpanel.Contains(frontdesk))
            {
                mainformpanel.Controls.Add(frontdesk);
            }
            frontdesk.BringToFront();
        }

        private void dashboardbutton_Click_1(object sender, EventArgs e)
        {
            DashboardUC dashboard = new DashboardUC();
            if (!mainformpanel.Contains(dashboard))
            {
                mainformpanel.Controls.Add(dashboard);
            }
            dashboard.BringToFront();
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("MMMM-dd-yyy hh:mm:ss tt");
        }
    }
}
