using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    public class ApprovalProcessor
    {
        private List<Approver> _approvers;

        public ApprovalProcessor(List<Approver> approvers)
        {
            _approvers = approvers;
        }

        public void ProcessRequest(PaymentRequest request)
        {
            foreach (var approver in _approvers)
            {
                if (request.Status == RequestStatus.Pending && approver.ApproveRequest(request))
                {
                    return;
                }
            }
            request.Status = RequestStatus.Rejected;
            request.RequestHistory.Add(new RequestHistoryAttribute($"Request rejected on {DateTime.Now}"));
        }
    }

}
