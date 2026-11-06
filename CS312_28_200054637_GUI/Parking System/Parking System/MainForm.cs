using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            meunVehicles.Click += (s, e) => new VehiclesForm().Show();
            menuSlots.Click += (s, e) => new SlotsForm().Show();
            menuEntry.Click += (s, e) => new EntryExitFrom().Show();
            menuTickets.Click += (s, e) => new TicketsForm().Show();
            menuReports.Click += (s, e) => new ReportForm().Show();
            menuExit.Click += (s, e) => Application.Exit();
        }
    }
}
