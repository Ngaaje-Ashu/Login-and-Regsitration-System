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
        public StartUpView()
        {

            InitializeComponent();
        }

        private void btnNewMail_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ComposerView composeView = new ComposerView();
            composeView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
