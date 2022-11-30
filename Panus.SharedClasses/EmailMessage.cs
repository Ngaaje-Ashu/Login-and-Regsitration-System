using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
   public  class EmailMessage
    {
        public string SenderEmailAddress { get; set; }

        public string RecieverEmailAddress { get; set; }

        public string MessageBody { get; set; }

        public string Subject { get; set; }
    }
}
