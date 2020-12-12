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
    public partial class Form1 : Form
    {
        public void GenerateTable()
        {
            using (var connect = new SQLiteConnection(Program.ConnectionString))
            {
                var command = new SQLiteCommand(QueryHolder.InitQuery, connect);
                connect.Open();
                var sqlData = new SQLiteDataAdapter("SELECT * FROM Client", connect);
                var dataTable = new DataTable();
                sqlData.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connect.Close();
            }
        }
        public Form1()
        {
            InitializeComponent();

            GenerateTable();
        }

    }
}
