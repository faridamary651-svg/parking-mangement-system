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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            MessageBox.Show("Report Generated Successfully ");
        }

        private void s(object sender, EventArgs e)
        {

        }
    }
}
