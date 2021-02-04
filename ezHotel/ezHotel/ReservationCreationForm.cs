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
    public partial class ReservationCreationForm : Form
    {
        private Dictionary<int, int> roomPrice = new Dictionary<int, int>();
        private Dictionary<string, int> clients = new Dictionary<string, int>();
        private Dictionary<string, int> rooms = new Dictionary<string, int>();

        public ReservationCreationForm()
        {
            InitializeComponent();
            endDatePicker.Value = DateTime.Now.AddDays(1);
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";

            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";

            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                connect.Open();
                var sqlCommand = new SQLiteCommand(@"select client_id, 'ID - ' || client_id || ' ' || 
                                                first_name || ' ' || last_name as 'client_string' from Client;", connect);
                var sqlReader = sqlCommand.ExecuteReader();
                

                if (sqlReader.HasRows)
                {

                    while (sqlReader.Read())
                    {
                        var client_id = Convert.ToInt32(sqlReader["client_id"]);
                        var client_string = sqlReader["client_string"].ToString();

                        clients.Add(client_string, client_id);
                    }
                }

                connect.Close();
            }

            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                connect.Open();
                var sqlCommand = new SQLiteCommand(@"select ro.room_id, 'ID - ' || ro.room_id || ' ' || rt.Name || ' No. of beds ' 
                                                        || rt.number_of_beds as 'room_string' from Room ro join RoomType rt
                                                            on ro.room_type_id = rt.room_type_id where ro.occupied = 0;", connect);
                var sqlReader = sqlCommand.ExecuteReader();


                if (sqlReader.HasRows)
                {

                    while (sqlReader.Read())
                    {
                        var room_id = Convert.ToInt32(sqlReader["room_id"]);
                        var room_string = sqlReader["room_string"].ToString();

                        rooms.Add(room_string, room_id);
                    }
                }

                connect.Close();
            }

            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                connect.Open();
                var sqlCommand = new SQLiteCommand(@"select ro.room_id, rt.price
                                                    from Room ro join RoomType rt
                                                    on ro.room_type_id = rt.room_type_id where ro.occupied = 0;", connect);
                var sqlReader = sqlCommand.ExecuteReader();


                if (sqlReader.HasRows)
                {

                    while (sqlReader.Read())
                    {
                        var room_id = Convert.ToInt32(sqlReader["room_id"]);
                        var room_price = Convert.ToInt32(sqlReader["price"]);

                        roomPrice.Add(room_id, room_price);
                    }
                }

                connect.Close();
            }

            clientBox.DataSource = clients.Keys.ToList();
            roomBox.DataSource = rooms.Keys.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nowStartButton_Click(object sender, EventArgs e)
        {
            startDatePicker.Value = DateTime.Now;
        }

        private void threeDayEndDateButton_Click(object sender, EventArgs e)
        {
            endDatePicker.Value = DateTime.Now.AddDays(3);
        }

        private void sevenDayEndDateButton_Click(object sender, EventArgs e)
        {
            endDatePicker.Value = DateTime.Now.AddDays(7);
        }

        private void oneDayEndDateButton_Click(object sender, EventArgs e)
        {
            endDatePicker.Value = DateTime.Now.AddDays(1);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var amount = roomPrice[rooms[roomBox.Text]] * Convert.ToInt32((endDatePicker.Value - startDatePicker.Value).TotalDays);

            if (amount == 0)
            {
                amount = roomPrice[rooms[roomBox.Text]];
            }

            try
            {
                using (var connect = new SQLiteConnection(Program.ConnectionString))
                {
                    var command = new SQLiteCommand($@"insert into Reservation values(null, { rooms[roomBox.Text]} , 
                                                    { clients[clientBox.Text] }, '{startDatePicker.Text}', '{endDatePicker.Text}', 
                                                    'In progress', {amount});
                                                    UPDATE Room SET occupied = 1 WHERE room_id = {rooms[roomBox.Text]};", connect);
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
