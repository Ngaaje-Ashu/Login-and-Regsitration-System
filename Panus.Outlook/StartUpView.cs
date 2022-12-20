using System;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public partial class StartUpView : Form
    {
        public event Action<ComposerViewController> NewMailButtonClicked;
        public event Action<ComposerViewController> NewMiniMailButtonClicked;
        public StartUpView()
        {
            InitializeComponent();
            ExitButon.Click += ExitButon_Click;
        }

        private void Button_NewMiniMail_Click(object sender, EventArgs e)
        {
            MiniComposerView miniComposerView = new MiniComposerView();
            //controller.View.ShowDialog();
            this.NewMiniMailButtonClicked?.Invoke(miniComposerView);
        }

        private void ExitButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewMailButton_Click(object sender, EventArgs e)
        {
            LargeComposerView composeView = new LargeComposerView();
            ComposerViewController controller = new ComposerViewController(composeView);
            this.NewMailButtonClicked?.Invoke(composeView);

            //this.Hide();
        }

    }
}
