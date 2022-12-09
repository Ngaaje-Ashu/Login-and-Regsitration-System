using Panus.SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.Outlook
{
    public class MiniComposerViewController
    {
        public MiniComposerViewController(MiniComposerView miniComposerView)
        {
            this.View = miniComposerView;
            this.View.SendButtonClicked += View_SendButtonClicked;
        }

        private void View_SendButtonClicked(SharedClasses.EmailMessage emailMessage)
        {
            var courier = new EmailCourier(emailMessage);

            var sendConfirmation = courier.Send();
            this.View.DisplayConfirmationMessage(sendConfirmation);
        }

        public MiniComposerView View { get; }
    }
}
