using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
   public class EmailMessage
    {
        public EmailMessage(EmailAddress sender, EmailAddress receiver, string messageBody, string footer, Guid hash)
        {
            SenderEmailAddress = sender;
            RecieverEmailAddress = receiver;
            MessageBody = $"{messageBody} {footer}";
            Hash = hash;
        }
        public EmailMessage(EmailAddress sender, EmailAddress receiver, string subject, string messageBody)
        {
            SenderEmailAddress = sender;
            RecieverEmailAddress = receiver;
            MessageBody = messageBody;
            Subject = subject;
            //messageModifier.Invoke(this);
        }


        //const string Footer = "Sent from PANUS servers";
        public EmailAddress SenderEmailAddress { get; set; }

       
        public EmailAddress RecieverEmailAddress { get; set; }

        
        public string MessageBody { get; set; }

        public string Subject { get; set; }

        public string Footer { get; set; }

        public Guid Hash { get; set; }
    }
}
