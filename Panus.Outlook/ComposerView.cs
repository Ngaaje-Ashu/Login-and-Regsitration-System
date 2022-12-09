using Panus.SharedClasses;
using System;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public partial class ComposerView : Form, IComposerView
    {

        public event Action<EmailMessage> SendButtonClicked;

        public ComposerView()
        {
            InitializeComponent();

            button_SendEmail.Click += Button_SendEmail_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_SendEmail_Click(object sender, EventArgs e)
        {
            var senderEmailAddress = new EmailAddress(textBoxSenderEmailAddress.Text);
            var receiverEmailAddress = new EmailAddress(textBoxRecieverEmailAddress.Text);
            var subject = textBoxSubject.Text;
            var messageBody = textBoxMessage.Text;
            var message = new EmailMessage(senderEmailAddress, receiverEmailAddress, subject, messageBody);
            this.SendButtonClicked?.Invoke(message);
           // var courier = new EmailCourier(message);

            //var sendConfirmation = courier.Send();

            //MessageBox.Show(sendConfirmation);
        }

        public void DisplayConfirmationMessage(string sendConfirmation)
        {
            MessageBox.Show(sendConfirmation);
        }
    }
}
