using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
    public class LaboratoryOrder : HospitalServiceOrder
    {

        public LaboratoryOrder(DateTime dateOrdered, string specimenType)
        {
            this.DateOrdered = dateOrdered;
            this.SpecimenType = specimenType;
        }
        public string SpecimenType  { get; set; }
    }
}
