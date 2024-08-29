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
    public partial class Form1 : Form
    {
        private PaymentRequestManager _requestManager;
        private ApprovalProcessor _approvalProcessor;
        private ReportGenerator _reportGenerator;

        public Form1()
        {
            InitializeComponent();

            _requestManager = new PaymentRequestManager();
            var approvers = new List<Approver>
        {
            new Approver { EmployeeID = 1, Name = "Team Lead", ApprovalLimit = new ApprovalLimitAttribute(1000) } ,
            new Approver { EmployeeID = 2, Name = "Manager", ApprovalLimit = new ApprovalLimitAttribute(10000)},
            new Approver { EmployeeID = 3, Name = "Director", ApprovalLimit = new ApprovalLimitAttribute(50000)}
        };
            _approvalProcessor = new ApprovalProcessor(approvers);
            _reportGenerator = new ReportGenerator();
        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            var requestForm = new RequestForm();
            requestForm.Show();
            this.Hide();
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            var approvalForm = new ApprovalForm(_approvalProcessor);
            approvalForm.Show();
            this.Hide();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            var form = new Generate_Report();
            form.Show();
            this.Hide();
        }
    }
}
