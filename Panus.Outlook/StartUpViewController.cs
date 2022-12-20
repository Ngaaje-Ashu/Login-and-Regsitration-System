using System;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public class StartUpViewController : Form
    {
        public StartUpView View = new StartUpView();
       
        public StartUpViewController()
        {
            View.Show();
        }

        //private void RunView()
        //{
        //    StartUpView View = new StartUpView();
        //    View.Show();
        //}

        public void Initialize()
        {
            View.NewMailButtonClicked += View_NewMailButton_Click;
           View.NewMiniMailButtonClicked += View_NewMiniMail_Click;
        }

        private void View_NewMiniMail_Click(MiniComposerView obj)
        {
            obj.ShowDialog();
        }

        private void View_NewMailButton_Click(LargeComposerView obj)
        {
            obj.ShowDialog();
        }


        //internal class View
        //{
        //}
    }
}
