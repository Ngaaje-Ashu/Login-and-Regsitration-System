using Panus.SharedClasses;
using System;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public partial class MiniComposerView : Form, IComposerView
    {
        public event Action<EmailMessage> SendButtonClicked;

        public MiniComposerView()
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
            //textBox1.Text = "Hi";
            //MessageBox.Show(textBox1.Text);
            var senderEmailAddress = new EmailAddress(textBoxSenderEmailAddress.Text);
            var receiverEmailAddress = new EmailAddress(textBoxRecieverEmailAddress.Text);
            var subject = textBoxSubject.Text;
            var messageBody = textBoxMessage.Text;
            var message = new EmailMessage(senderEmailAddress, receiverEmailAddress, subject, messageBody);
            this.SendButtonClicked?.Invoke(message);
            //var courier = new EmailCourier(message);

           
        }

        public void DisplayConfirmationMessage(string sendConfirmation)
        {
            MessageBox.Show(sendConfirmation);
        }
    }
}
