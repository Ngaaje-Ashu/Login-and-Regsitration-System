using Panus.SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public class ComposerViewController
    {
        public ComposerViewController(ComposerView composerView)
        {
            this.View = composerView;
            this.View.SendButtonClicked += View_SendButtonClicked;
        }

        private void View_SendButtonClicked(SharedClasses.EmailMessage emailMessage)
        {
            var courier = new EmailCourier(emailMessage);

            var sendConfirmation = courier.Send();
            this.View.DisplayConfirmationMessage(sendConfirmation);
        }

        public ComposerView View { get; }
    }
}
