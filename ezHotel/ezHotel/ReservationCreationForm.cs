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
    public partial class ReservationCreationForm : Form
    {
        private Dictionary<string, int> clients = new Dictionary<string, int>();
        private Dictionary<string, int> rooms = new Dictionary<string, int>();

        public ReservationCreationForm()
        {
            InitializeComponent();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
