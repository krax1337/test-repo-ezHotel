using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ezHotel
{
    public partial class ManageClientsForm : Form
    {

        public void GenerateClientTable()
        {
            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                connect.Open();
                var sqlCommand = new SQLiteCommand("SELECT * FROM Client", connect);
                var sqlReader = sqlCommand.ExecuteReader();
                var clients = new List<Client>();

                // Another way of this

                //var sqlData = new SQLiteDataAdapter("SELECT * FROM Client", connect);
                //var dataTable = new DataTable();
                //sqlData.Fill(dataTable);
                //dataGridView1.DataSource = dataTable;

                if (sqlReader.HasRows) 
                {

                    while (sqlReader.Read()) 
                    {
                        var clientId = Convert.ToInt32(sqlReader["client_id"]);
                        var firstName = sqlReader["first_name"].ToString();
                        var lastName = sqlReader["last_name"].ToString();
                        var phone = sqlReader["phone"].ToString();
                        var email = sqlReader["email"].ToString();
                        var country = sqlReader["country"].ToString();
                        var passportNumber = sqlReader["passport_number"].ToString();

                        var client = new Client(clientId, firstName, lastName, phone, email, country, passportNumber);
                        clients.Add(client);
                    }
                }

                dataGridClient.DataSource = clients;

                connect.Close();
            }
        }
        public ManageClientsForm()
        {
            InitializeComponent();

            GenerateClientTable();
        }

        private void ManageClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dataGridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridClient.SelectedRows[0].DataBoundItem as Client;
                firstNameText.Text = selectedRow.FirstName;
                lastNameText.Text = selectedRow.LastName;
                phoneText.Text = selectedRow.Phone;
                emailText.Text = selectedRow.Email;
                countryText.Text = selectedRow.Country;
                passportNumberText.Text = selectedRow.PassportNumber;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridClient.SelectedRows[0].DataBoundItem as Client;
                var clientPk = selectedRow.ClientId;

                using (var connect = new SQLiteConnection(Program.ConnectionString))
                {
                    var command = new SQLiteCommand($"DELETE FROM Client WHERE client_id = {clientPk}", connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }

                GenerateClientTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridClient.SelectedRows[0].DataBoundItem as Client;
                var clientPk = selectedRow.ClientId;

                using (var connect = new SQLiteConnection(Program.ConnectionString))
                {
                    var command = new SQLiteCommand($"UPDATE Client SET first_name = \"{firstNameText.Text}\", last_name = \"{lastNameText.Text}\", phone = \"{phoneText.Text}\", email = \"{emailText.Text}\", country = \"{countryText.Text}\", passport_number = \"{passportNumberText.Text}\" WHERE client_id = {clientPk}", connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }

                GenerateClientTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            var clientCreationForm = new ClientCreationForm();
            clientCreationForm.Show();

            // question about event

        }

        private void tableUpdateButton_Click(object sender, EventArgs e)
        {
            GenerateClientTable();
        }
    }
}
