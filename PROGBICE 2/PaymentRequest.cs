using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    public enum RequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class PaymentRequest
    {
       
            public Guid RequestID { get; set; }
            public decimal Amount { get; set; }
            public string Description { get; set; }
            public DateTime RequestDate { get; set; }
            public RequestStatus Status { get; set; }
            public List<RequestHistoryAttribute> RequestHistory { get; set; } = new List<RequestHistoryAttribute>();
        
    }
}
