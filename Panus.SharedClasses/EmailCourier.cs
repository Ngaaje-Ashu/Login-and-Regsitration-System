using Humanizer;
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

        public List<EmailMessage> Messages { get; set; }



        public string Send()
        {
            this.DateSent = DateTime.Now;
            this.MessageSent?.Invoke(this.DateSent, this.emailMessage);
            Thread.Sleep(5000);
            this.DateDelivered = DateTime.Now;
            this.MessageDelivered?.Invoke(this.DateDelivered.Value);
            return $"The date delivered was {DateDelivered}";
        }

        public void Send(EmailMessage message, Action<EmailMessage> messageModifier)
        {
            this.DateSent = DateTime.Now;
            messageModifier?.Invoke(message);
            this.MessageSent.Invoke(this.DateSent, message);
            //Console.WriteLine($"This message will be delivered {DateTime.Now.AddSeconds(5).Humanize()}");
            //Console.WriteLine("Be patient a little longer. Your message is on the way".Truncate(13));
            Thread.Sleep(5000);
            this.DateDelivered = DateTime.Now;
            this.MessageDelivered.Invoke(this.DateDelivered.Value);
        }

        public void Send(List<EmailMessage> messages)
        {
            messages.ForEach(SendOneAtATime);
        }

        private void SendOneAtATime(EmailMessage m)
        {
                m.Hash = Guid.NewGuid();
                Send(m, null);
        }

        public bool Delivered() 
        {
            return DateDelivered.HasValue;
        }

        public event Action<DateTime> MessageDelivered;

        public event Action<DateTime, EmailMessage> MessageSent;
    }
}
