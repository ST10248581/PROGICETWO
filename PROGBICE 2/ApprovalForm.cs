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
    public partial class ApprovalForm : Form
    {
        private ApprovalProcessor _approvalProcessor;

        public ApprovalForm(ApprovalProcessor approvalProcessor)
        {
            InitializeComponent();
            _approvalProcessor = approvalProcessor;
           LoadPendingRequests();
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadPendingRequests()
        {
            var pendingRequests = PaymentRequestManager.GetAllRequests()
                .Where(r => r.Status == RequestStatus.Pending)
                .ToList();

            dgvRequests.Columns.Clear();
            dgvRequests.DataSource = null;

            dgvRequests.Columns.Add("RequestID", "Request ID");
            dgvRequests.Columns.Add("Amount", "Amount");
            dgvRequests.Columns.Add("Description", "Description");
            dgvRequests.Columns.Add("RequestDate", "Request Date");

            dgvRequests.Columns["RequestID"].Visible = false;

            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Approve",
                HeaderText = "Approve",
                Text = "Approve",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn rejectButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Reject",
                HeaderText = "Reject",
                Text = "Reject",
                UseColumnTextForButtonValue = true
            };

            dgvRequests.Columns.Add(approveButtonColumn);
            dgvRequests.Columns.Add(rejectButtonColumn);

            foreach (var request in pendingRequests)
            {
                dgvRequests.Rows.Add(request.RequestID, request.Amount, request.Description, request.RequestDate);
            }

           dgvRequests.CellClick += dgvRequests_CellClick;
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                var requestID = (Guid)dgvRequests.Rows[e.RowIndex].Cells["RequestID"].Value;
                var request = PaymentRequestManager.GetAllRequests().FirstOrDefault(r => r.RequestID == requestID);

               
                if (dgvRequests.Columns[e.ColumnIndex].Name == "Approve")
                {
                    if (request != null)
                    {
                        _approvalProcessor.ProcessRequest(request);
                        MessageBox.Show(NotificationService.NotifyEmployee(request));
                    }
                }
                else if (dgvRequests.Columns[e.ColumnIndex].Name == "Reject")
                {
                    if (request != null)
                    {
                        request.Status = RequestStatus.Rejected;
                        request.RequestHistory.Add(new RequestHistoryAttribute($"Request rejected by {request.Description} on {DateTime.Now}"));
                        MessageBox.Show(NotificationService.NotifyEmployee(request));
                    }
                }
              
                LoadPendingRequests();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.ShowDialog();
            this.Close();
        }
    }
}
