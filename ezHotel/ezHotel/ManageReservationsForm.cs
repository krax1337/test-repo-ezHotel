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
    public partial class ManageReservationsForm : Form
    {
        public void GenerateReservationTable()
        {
            currentMonthLabel.Text = "";
            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                connect.Open();
                var sqlCommand = new SQLiteCommand(@"select re.reservation_id, ro.room_id, rt.Name as 'room_type' , cl.client_id, (cl.first_name || ' ' || cl.last_name) as 'client_full_name', 
                                                    re.start_date, re.end_date, re.current_status, re.amount
                                                    from Reservation re join Client cl
                                                    on re.client_id = cl.client_id
                                                    join Room ro
                                                    on re.room_id = ro.room_id
                                                    join RoomType rt 
                                                    on ro.room_type_id = rt.room_type_id;
                                                    ", connect);
                var sqlReader = sqlCommand.ExecuteReader();
                var reservations = new List<Reservation>();

                if (sqlReader.HasRows)
                {

                    while (sqlReader.Read())
                    {
                        var reservationId = Convert.ToInt32(sqlReader["reservation_id"]);
                        var roomId = Convert.ToInt32(sqlReader["room_id"]);
                        var roomType = sqlReader["room_type"].ToString();
                        var clientId = Convert.ToInt32(sqlReader["client_id"]);
                        var clientFullName = sqlReader["client_full_name"].ToString();
                        var startDate = DateTime.Parse(sqlReader["start_date"].ToString());
                        var endDate = DateTime.Parse(sqlReader["end_date"].ToString());
                        var currentStatus = sqlReader["current_status"].ToString();
                        var amount = Convert.ToInt32(sqlReader["amount"]);

                        var reservation = new Reservation(reservationId, roomId, roomType, clientId, clientFullName, 
                            startDate, endDate, currentStatus, amount);
                        reservations.Add(reservation);
                    }
                }

                dataGridReservation.DataSource = reservations;

                if (reservations.Count() > 0)
                {
                    currentMonthLabel.Text = reservations.Select(x => x.Amount).Sum().ToString();
                }

                connect.Close();
            }


        }
        public ManageReservationsForm()
        {
            InitializeComponent();

            GenerateReservationTable();


        }

        private void dataGridReservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridReservation.SelectedRows[0].DataBoundItem as Reservation;
                reservationIdText.Text = selectedRow.ReservationId.ToString();
                clientFullNameBox.Text = selectedRow.ClientFullName;
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
                var selectedRow = dataGridReservation.SelectedRows[0].DataBoundItem as Reservation;


                using (var connect = new SQLiteConnection(Program.ConnectionString))
                {
                    var command = new SQLiteCommand($@"DELETE FROM Reservation WHERE reservation_id = {selectedRow.ReservationId};
                                                    UPDATE Room SET occupied = 0 WHERE room_id = {selectedRow.RoomId}", connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }

                GenerateReservationTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridReservation.SelectedRows[0].DataBoundItem as Reservation;

                using (var connect = new SQLiteConnection(Program.ConnectionString))
                {
                    var command = new SQLiteCommand($@"UPDATE Reservation SET current_status = 'Finished' WHERE reservation_id = {selectedRow.ReservationId};
                                                       UPDATE Room SET occupied = 0 WHERE room_id = {selectedRow.RoomId}", connect);
                    
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }

                GenerateReservationTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ReservationCreationForm reservationCreationForm = new ReservationCreationForm();
            reservationCreationForm.Show();
        }

        private void refreshTableButton_Click(object sender, EventArgs e)
        {
            GenerateReservationTable();
        }
    }
}
