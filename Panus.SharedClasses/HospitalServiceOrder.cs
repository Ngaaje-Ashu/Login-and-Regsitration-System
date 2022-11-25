using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
    public class HospitalServiceOrder
    {
        public DateTime DateOrdered { get; protected set; }

        public string CreatedBy { get; set; }

        public string PatientName { get; set; }

        public string Unit { get; set; }
    }
}
