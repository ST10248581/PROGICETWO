using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    public class ReportGenerator
    {
        public string GeneratePendingRequestsReport()
        {
            var pendingRequests = PaymentRequestManager.GetAllRequests().Where(r => r.Status == RequestStatus.Pending).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pending Requests Report:");

           
            foreach (var request in pendingRequests)
            {
               sb.AppendLine($"Request ID: {request.RequestID}");
                sb.AppendLine("---------------------------------");
                sb.AppendLine($"Amount: { request.Amount}");
                sb.AppendLine($"Status: {request.Status}");
                sb.AppendLine("---------------------------------");
            }

            return sb.ToString();
        }

        public string GenerateApprovedRejectedRequestsReport()
        {
            var requests = PaymentRequestManager.GetAllRequests().Where(r => r.Status != RequestStatus.Pending).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Approved/Rejected Requests Report:");

            foreach (var request in requests)
            {
                sb.AppendLine($"Request ID: {request.RequestID}");
                sb.AppendLine("---------------------------------");
                sb.AppendLine($"Amount: {request.Amount}");
                sb.AppendLine($"Status: {request.Status}");
                sb.AppendLine("---------------------------------");
            }

            return sb.ToString();
        }
    }

}
