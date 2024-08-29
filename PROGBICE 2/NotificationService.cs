using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    public class NotificationService
    {
        public static string NotifyEmployee(PaymentRequest request)
        {
            string message = "";

            if (request.Status == RequestStatus.Rejected)
            {
                message = $"Notification: Request {request.RequestID} was rejected.";
            }
            else if (request.Status == RequestStatus.Approved)
            {
                message = $"Notification: Request {request.RequestID} was approved.";
            }

            return message;

        }

    }
}
