using System;
using System.Drawing;
using System.Windows.Forms;

namespace ezHotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            timer1.Start();

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
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
            Hide();
            using (ManageClientsForm manageClientsForm = new ManageClientsForm())
                manageClientsForm.ShowDialog();
            Show();
        }

        private void manageReservationsButton_Click(object sender, EventArgs e)
        {
            Hide();
            using (ManageReservationsForm manageReservationsForm = new ManageReservationsForm())
                manageReservationsForm.ShowDialog();
            Show();
        }

        private void manageRoomsButton_Click(object sender, EventArgs e)
        {
            Hide();
            using (ManageRoomsForm manageRoomsForm = new ManageRoomsForm())
                manageRoomsForm.ShowDialog();
            Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Current time is: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
