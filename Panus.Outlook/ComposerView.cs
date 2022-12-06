using Panus.SharedClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public partial class ComposerView : Form
    {
        public ComposerView()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Hi";
            //MessageBox.Show(textBox1.Text);
            var senderEmailAddress = new EmailAddress(textBoxSenderEmailAddress.Text);
            var receiverEmailAddress = new EmailAddress(textBoxRecieverEmailAddress.Text);
            var subject = textBoxSubject.Text;
            var messageBody = textBoxMessage.Text;
            var message = new EmailMessage(senderEmailAddress, receiverEmailAddress, subject, messageBody);
            var courier = new EmailCourier(message);

            var sendConfirmation = courier.Send();

            MessageBox.Show(sendConfirmation);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartUpView_Load(object sender, EventArgs e)
        {

        }
    }
}
