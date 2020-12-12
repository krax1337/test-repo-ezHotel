using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System.Diagnostics;


namespace ezHotel
{
    static class Program
    {
        public static string DbName = "mainDB.db";
        public static string ConnectionString = "Data Source=" + DbName + ";Version=3;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(DbName))
            {
                SQLiteConnection.CreateFile(DbName);

                using (var connect = new SQLiteConnection(ConnectionString))
                {
                    var command = new SQLiteCommand(QueryHolder.InitQuery, connect);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }

            }






            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
