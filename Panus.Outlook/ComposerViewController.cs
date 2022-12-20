using Panus.SharedClasses;

namespace Panus.Outlook
{
    public class ComposerViewController
    {
        public ComposerViewController(IComposerView composerView)
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

        public IComposerView View { get; }
    }
}
