using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    public class PaymentRequestManager
    {
        private static List<PaymentRequest> _requests = new List<PaymentRequest>();

        public static void CreateRequest(Guid requestId, decimal amount, string description, DateTime requestDate)
        {
            var request = new PaymentRequest
            {
                RequestID = requestId,
                Amount = amount,
                Description = description,
                RequestDate = requestDate,
                Status = RequestStatus.Pending
            };
            _requests.Add(request);
        }

        public static List<PaymentRequest> GetAllRequests() => _requests;
    }
}
