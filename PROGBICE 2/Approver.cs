using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROGBICE_2
{
    public class Approver : Employee
    {
        public ApprovalLimitAttribute ApprovalLimit { get; set; }

        public bool ApproveRequest(PaymentRequest request)
        {
            if (request.Amount <= ApprovalLimit.Limit)
            {
                request.Status = RequestStatus.Approved;
                request.RequestHistory.Add(new RequestHistoryAttribute($"Approved by {Name} on {DateTime.Now}"));
                return true;
            }
            return false;
        }
    }
}
