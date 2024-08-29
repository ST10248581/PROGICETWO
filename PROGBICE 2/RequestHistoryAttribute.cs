using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RequestHistoryAttribute : Attribute
    {
        public string Action { get; }

        public RequestHistoryAttribute(string action)
        {
            Action = action;
        }
    }

}
