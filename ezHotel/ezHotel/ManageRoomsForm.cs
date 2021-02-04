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
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();

            GenerateRoomTable();

            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        public void GenerateRoomTable()
        {
            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                connect.Open();
                var sqlCommand = new SQLiteCommand(@"select r.room_id, r.floor, r.occupied, rt.name as 'Room type', rt.number_of_beds, rt.price
                                                    from Room r join RoomType rt
                                                    on r.room_type_id = rt.room_type_id;", connect);
                var sqlReader = sqlCommand.ExecuteReader();
                var rooms = new List<Room>();

                if (sqlReader.HasRows)
                {

                    while (sqlReader.Read())
                    {
                        var room_id = Convert.ToInt32(sqlReader["room_id"]);
                        var floor = Convert.ToInt32(sqlReader["floor"]);
                        var occupied = Convert.ToBoolean(sqlReader["occupied"]);
                        var roomType = sqlReader["Room type"].ToString();
                        var numberOfBeds = Convert.ToInt32(sqlReader["number_of_beds"]);
                        var price = Convert.ToInt32(sqlReader["price"]);

                        var room = new Room(room_id, floor, occupied, roomType, numberOfBeds, price);
                        rooms.Add(room);
                    }
                }

                dataGridRoom.DataSource = rooms;

                connect.Close();
            }
        }

        private void dataGridRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridRoom.SelectedRows[0].DataBoundItem as Room;
                textRoomId.Text = selectedRow.RoomId.ToString();
                textFloor.Text = selectedRow.Floor.ToString();
                textRoomType.Text = selectedRow.RoomType;
                checkBoxOccupied.Checked = selectedRow.Occupied;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridRoom.RowCount > 0)
            {
                try
                {
                    var selectedRow = dataGridRoom.SelectedRows[0].DataBoundItem as Room;
                    var roomPk = selectedRow.RoomId;

                    using (var connect = new SQLiteConnection(Program.ConnectionString))
                    {
                        var command = new SQLiteCommand($"DELETE FROM Room WHERE room_id = {roomPk}", connect);
                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();
                    }

                    GenerateRoomTable();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                    throw;
                }
                
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridRoom.SelectedRows[0].DataBoundItem as Room;
                var roomPk = selectedRow.RoomId;

                using (var connect = new SQLiteConnection(Program.ConnectionString))
                {
                    var command = new SQLiteCommand($"UPDATE Room SET occupied = \"{ Convert.ToInt32(checkBoxOccupied.Checked) }\" WHERE room_id = {roomPk}", connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }

                GenerateRoomTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured: {exception.Message} - {exception.Source}");
                throw;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Hide();
            using (RoomCreationForm roomCreationForm = new RoomCreationForm())
                roomCreationForm.ShowDialog();
            Show();
            GenerateRoomTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GenerateRoomTable();
        }
    }
}
