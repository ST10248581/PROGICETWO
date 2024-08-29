using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGBICE_2
{
    public partial class Generate_Report : Form
    {

        public Generate_Report()
        {
            InitializeComponent();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            try
            {
                var reportGenerator = new ReportGenerator();

                var processedReports = reportGenerator.GenerateApprovedRejectedRequestsReport();
                 
                var pendingReports = reportGenerator.GeneratePendingRequestsReport();

                ReportTB.Text = processedReports.ToString();
                PendingTB.Text = pendingReports.ToString();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
