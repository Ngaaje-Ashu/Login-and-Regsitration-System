namespace Panus.Outlook
{
    partial class StartUpView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButon = new System.Windows.Forms.Button();
            this.NewMailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_NewMiniMail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButon
            // 
            this.ExitButon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ExitButon.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.ExitButon.FlatAppearance.BorderSize = 0;
            this.ExitButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ExitButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButon.Location = new System.Drawing.Point(1339, 12);
            this.ExitButon.Name = "ExitButon";
            this.ExitButon.Size = new System.Drawing.Size(43, 45);
            this.ExitButon.TabIndex = 0;
            this.ExitButon.Text = "X";
            this.ExitButon.UseVisualStyleBackColor = true;
            this.ExitButon.UseWaitCursor = true;
            // 
            // NewMailButton
            // 
            this.NewMailButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewMailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.NewMailButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMailButton.Location = new System.Drawing.Point(320, 576);
            this.NewMailButton.Name = "NewMailButton";
            this.NewMailButton.Size = new System.Drawing.Size(190, 80);
            this.NewMailButton.TabIndex = 1;
            this.NewMailButton.Text = "New Mail";
            this.NewMailButton.UseVisualStyleBackColor = true;
            this.NewMailButton.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(551, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "PANUS OUTLOOK";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(187, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(78, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(794, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "This is just a sample email courrier. Tap on \"New Mail\" to test features";
            this.label2.UseWaitCursor = true;
            // 
            // button_NewMiniMail
            // 
            this.button_NewMiniMail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_NewMiniMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_NewMiniMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewMiniMail.Location = new System.Drawing.Point(795, 576);
            this.button_NewMiniMail.Name = "button_NewMiniMail";
            this.button_NewMiniMail.Size = new System.Drawing.Size(190, 80);
            this.button_NewMiniMail.TabIndex = 1;
            this.button_NewMiniMail.Text = "New Mini Mail";
            this.button_NewMiniMail.UseVisualStyleBackColor = true;
            this.button_NewMiniMail.UseWaitCursor = true;
            // 
            // StartUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1394, 706);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_NewMiniMail);
            this.Controls.Add(this.NewMailButton);
            this.Controls.Add(this.ExitButon);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUpView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Composer";
            this.UseWaitCursor = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButon;
        private System.Windows.Forms.Button NewMailButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_NewMiniMail;
    }
}