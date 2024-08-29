using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGBICE_2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ApprovalLimitAttribute : Attribute
    {
        public decimal Limit { get; }

        public ApprovalLimitAttribute(decimal limit)
        {
            Limit = limit;
        }
    }
}
