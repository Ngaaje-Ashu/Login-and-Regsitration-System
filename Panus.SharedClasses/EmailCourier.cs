using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Panus.SharedClasses
{
   public class EmailCourier
    {
        private EmailMessage emailMessage;

        public EmailCourier(EmailMessage message)
        {
            this.emailMessage = message;
        }
        public DateTime DateSent { get; set; }
        public DateTime? DateDelivered { get; set; }


        public void Send()
        {
            this.DateSent = DateTime.Now;
            this.MessageSent.Invoke(this.DateSent, this.emailMessage);
            Thread.Sleep(5000);
            this.DateDelivered = DateTime.Now;
            this.MessageDelivered.Invoke(this.DateDelivered.Value);
        }

        public void Send(EmailMessage message)
        {
        }

        public bool Delivered() 
        {
            return DateDelivered.HasValue;
        }

        public event Action<DateTime> MessageDelivered;

        public event Action<DateTime, EmailMessage> MessageSent;
        

    }
}
