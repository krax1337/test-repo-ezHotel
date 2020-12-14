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
    public partial class RoomCreationForm : Form
    {
        private Dictionary<string, int> roomType = new Dictionary<string, int>
        {
            {"Standard single", 1},
            {"Standard double", 2},
            {"Luxe single", 3},
            {"Luxe double", 4},
            {"Family", 5},
            {"President", 6},

        };
        public RoomCreationForm()
        {
            InitializeComponent();

            comboBoxRoomType.DataSource = roomType.Keys.ToList();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (comboBoxRoomType.Text == "")
            {
                MessageBox.Show($"Please complete the form");
            }
            else
            {
                try
                {
                    using (var connect = new SQLiteConnection(Program.ConnectionString))
                    {
                        var command = new SQLiteCommand($"insert into Room values(null, '{ roomType[comboBoxRoomType.Text]}', {numericFloor.Text }, 0)", connect);
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
