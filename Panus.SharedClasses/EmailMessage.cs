using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
   public class EmailMessage
    {
        public string SenderEmailAddress { get; set; }

        public string SenderName { get; set; }

        public string Sender { get { return $"{SenderName} {SenderEmailAddress}"; } }

        public string RecieverEmailAddress { get; set; }

        public string RecieverName { get; set; }

        public string Reciever { get { return $"{RecieverName} {RecieverEmailAddress}"; } }

        public string MessageBody { get; set; }

        public string Subject { get; set; }
    }
}
