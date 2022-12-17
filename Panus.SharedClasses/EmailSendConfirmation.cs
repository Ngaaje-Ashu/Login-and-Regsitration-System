using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
    public class EmailSendConfirmation
    {
        public EmailSendConfirmation(string deliveryMessage)
        {
            //DateSent = dateSent;
            DeliveryMessage = deliveryMessage;
        }

        public DateTime DateSent { get; set; }

        public string DeliveryMessage { get; set; }
    }
}
