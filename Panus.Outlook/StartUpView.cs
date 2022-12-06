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
    public partial class StartUpView : Form
    {

        ComposerView compose = new ComposerView();
        public StartUpView()
        {
            InitializeComponent();
            NewMailButton.Click += NewMailButton_Click;
            ExitButon.Click += ExitButon_Click; 
        }

        private void ExitButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewMailButton_Click(object sender, EventArgs e)
        {
            compose.Show();
            this.Hide();
        }
    }
}
