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

        public void GenerateTable()
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

            GenerateTable();
        }

        private void ManageClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
