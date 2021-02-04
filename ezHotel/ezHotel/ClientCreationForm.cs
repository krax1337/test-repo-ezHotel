using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezHotel
{
    public partial class ClientCreationForm : Form
    {
        public ClientCreationForm()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text == "" || lastNameText.Text == ""
                || phoneText.Text == "" || emailText.Text == "" 
                || countryText.Text == "" || passportNumberText.Text == "")
            {
                MessageBox.Show($"Please complete the form");
            }
            else
            {
                try
                {
                    using (var connect = new SQLiteConnection(Program.ConnectionString))
                    {
                        var command = new SQLiteCommand($"insert into Client values(null,'{firstNameText.Text}', '{lastNameText.Text}', '{phoneText.Text}', '{emailText.Text}', '{countryText.Text}', '{passportNumberText.Text}')", connect);
                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();
                    }

                    MessageBox.Show("Created succesfully");
                    Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                    throw;
                }
            }



        }
    }
}
