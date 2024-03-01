using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    partial class frmUpdateMember
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
            txtCountry = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtMemberID = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(168, 269);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.MaxLength = 15;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(253, 23);
            txtCountry.TabIndex = 24;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 272);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 23;
            label6.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(168, 224);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(253, 23);
            txtCity.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 226);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 21;
            label3.Text = "City";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(168, 177);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(253, 23);
            txtCompanyName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 179);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 19;
            label4.Text = "Company Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(168, 83);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 17;
            label2.Text = "Email";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(168, 38);
            txtMemberID.Margin = new Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(253, 23);
            txtMemberID.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 15;
            label1.Text = "Member ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(268, 326);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 30);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(86, 326);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 30);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 128);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(253, 23);
            txtPassword.TabIndex = 29;
            txtPassword.Text = "123";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 131);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 28;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // frmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 388);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(btnUpdate);
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
            Name = "frmUpdateMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Member";
            FormClosing += frmUpdateMember_FormClosing;
            Load += frmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCountry;
        private Label label6;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtMemberID;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label label5;
    }
}