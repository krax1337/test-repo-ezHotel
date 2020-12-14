using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezHotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Infomate", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }

        private void manageClientsButton_Click(object sender, EventArgs e)
        {
            // Possible memory leak with hiding main tweak
            //Show(ManageClientsForm());
            ManageClientsForm manageClientsForm = new ManageClientsForm();
            manageClientsForm.Show();
            //Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void manageReservationsButton_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageReservationsForm = new ManageReservationsForm();
            manageReservationsForm.Show();
        }

        private void manageRoomsButton_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRoomsForm = new ManageRoomsForm();
            manageRoomsForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Current time is: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
