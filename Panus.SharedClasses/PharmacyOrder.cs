using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
    /// <summary>
    /// Represents a new order at the pharmacy
    /// </summary>
   public class PharmacyOrder : HospitalServiceOrder
    {

        public PharmacyOrder()
        {

        }
        public PharmacyOrder(DateTime dateOrdered)
        {
            this.DateOrdered = dateOrdered;
        }
    } 
}
