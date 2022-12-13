using Panus.SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panus.Outlook
{
    public interface IComposerView
    {
        event Action<EmailMessage> SendButtonClicked;

        void DisplayConfirmationMessage(string sendConfirmation);
    }
}
