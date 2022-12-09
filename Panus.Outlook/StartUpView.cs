﻿using System;
using System.Windows.Forms;

namespace Panus.Outlook
{
    public partial class StartUpView : Form
    {
        public StartUpView()
        {
            InitializeComponent();
            NewMailButton.Click += NewMailButton_Click;
            ExitButon.Click += ExitButon_Click;
            button_NewMiniMail.Click += Button_NewMiniMail_Click;
        }

        private void Button_NewMiniMail_Click(object sender, EventArgs e)
        {
            MiniComposerView miniComposerView = new MiniComposerView();
            miniComposerView.Show();    
        }

        private void ExitButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewMailButton_Click(object sender, EventArgs e)
        {
            ComposerView composeView = new ComposerView();
            ComposerViewController controller = new ComposerViewController(composeView);
            controller.View.ShowDialog();

            //this.Hide();
        }
    }
}
