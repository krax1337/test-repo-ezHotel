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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (MessageBox.Show("Are you sure want to exit?",
                "ezHotel",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
            else
                e.Cancel = true;
        }

        private void manageClientsButton_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageClientsForm = new ManageClientsForm();
            manageClientsForm.Show();
            this.Hide();
        }

        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason != CloseReason.UserClosing) return;
        //    if (MessageBox.Show("Are you sure want to exit?",
        //        "ezHotel",
        //        MessageBoxButtons.OKCancel,
        //        MessageBoxIcon.Information) == DialogResult.OK)
        //        Environment.Exit(1);
        //    else
        //        e.Cancel = true;
        //}
    }
}
