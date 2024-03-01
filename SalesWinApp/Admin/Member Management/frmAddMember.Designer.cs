using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    partial class frmAddMember
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
            txtPassword = new TextBox();
            label5 = new Label();
            txtCountry = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(270, 279);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 84);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(253, 23);
            txtPassword.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 86);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 22;
            label5.Text = "Password";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(171, 224);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.MaxLength = 15;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(253, 23);
            txtCountry.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 226);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 20;
            label6.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(171, 178);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(253, 23);
            txtCity.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 180);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 18;
            label3.Text = "City";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(171, 131);
            txtCompanyName.Margin = new Padding(3, 2, 3, 2);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(253, 23);
            txtCompanyName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 134);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 16;
            label4.Text = "Company Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 38);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 40);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 280);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 30);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 345);
            Controls.Add(btnAdd);
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
            Controls.Add(btnClose);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Member";
            FormClosing += frmAddMember_FormClosing;
            Load += frmAddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtCountry;
        private Label label6;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private Button btnAdd;
    }
}