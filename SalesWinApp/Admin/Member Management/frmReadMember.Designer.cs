using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    partial class frmReadMember
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
            btnClose = new Button();
            label1 = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(174, 326);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(168, 38);
            txtMemberID.Margin = new Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(253, 23);
            txtMemberID.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(168, 83);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(168, 224);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(253, 23);
            txtCity.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 226);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "City";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(168, 177);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.ReadOnly = true;
            txtCompanyName.Size = new Size(253, 23);
            txtCompanyName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 179);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 6;
            label4.Text = "Company Name";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(168, 269);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(253, 23);
            txtCountry.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 272);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 10;
            label6.Text = "Country";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 128);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(253, 23);
            txtPassword.TabIndex = 13;
            txtPassword.Text = "********";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 131);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // frmReadMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 388);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtCountry);
            Controls.Add(label6);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtMemberID);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReadMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Read Member";
            FormClosing += frmReadMember_FormClosing;
            Load += frmReadMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtCountry;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
    }
}