namespace ip
{
    partial class AddMembers
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
            this.buttonAddMemberSave = new System.Windows.Forms.Button();
            this.textBoxAddMemberPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxAddMemberEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddMemberFullName = new System.Windows.Forms.TextBox();
            this.labelAddMemberEmail = new System.Windows.Forms.Label();
            this.labelAddMemberPhoneNum = new System.Windows.Forms.Label();
            this.labelFullNameAddMembers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddMemberSave
            // 
            this.buttonAddMemberSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMemberSave.Location = new System.Drawing.Point(15, 93);
            this.buttonAddMemberSave.Name = "buttonAddMemberSave";
            this.buttonAddMemberSave.Size = new System.Drawing.Size(603, 23);
            this.buttonAddMemberSave.TabIndex = 17;
            this.buttonAddMemberSave.Text = "Сохранить";
            this.buttonAddMemberSave.UseVisualStyleBackColor = true;
            this.buttonAddMemberSave.Click += new System.EventHandler(this.ButtonAddMemberSave_Click);
            // 
            // textBoxAddMemberPhoneNum
            // 
            this.textBoxAddMemberPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddMemberPhoneNum.Location = new System.Drawing.Point(143, 34);
            this.textBoxAddMemberPhoneNum.Name = "textBoxAddMemberPhoneNum";
            this.textBoxAddMemberPhoneNum.Size = new System.Drawing.Size(472, 22);
            this.textBoxAddMemberPhoneNum.TabIndex = 16;
            // 
            // textBoxAddMemberEmail
            // 
            this.textBoxAddMemberEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddMemberEmail.Location = new System.Drawing.Point(63, 62);
            this.textBoxAddMemberEmail.Name = "textBoxAddMemberEmail";
            this.textBoxAddMemberEmail.Size = new System.Drawing.Size(552, 22);
            this.textBoxAddMemberEmail.TabIndex = 15;
            // 
            // textBoxAddMemberFullName
            // 
            this.textBoxAddMemberFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddMemberFullName.Location = new System.Drawing.Point(64, 6);
            this.textBoxAddMemberFullName.Name = "textBoxAddMemberFullName";
            this.textBoxAddMemberFullName.Size = new System.Drawing.Size(551, 22);
            this.textBoxAddMemberFullName.TabIndex = 13;
            // 
            // labelAddMemberEmail
            // 
            this.labelAddMemberEmail.AutoSize = true;
            this.labelAddMemberEmail.Location = new System.Drawing.Point(12, 65);
            this.labelAddMemberEmail.Name = "labelAddMemberEmail";
            this.labelAddMemberEmail.Size = new System.Drawing.Size(46, 17);
            this.labelAddMemberEmail.TabIndex = 11;
            this.labelAddMemberEmail.Text = "Email:";
            // 
            // labelAddMemberPhoneNum
            // 
            this.labelAddMemberPhoneNum.AutoSize = true;
            this.labelAddMemberPhoneNum.Location = new System.Drawing.Point(12, 37);
            this.labelAddMemberPhoneNum.Name = "labelAddMemberPhoneNum";
            this.labelAddMemberPhoneNum.Size = new System.Drawing.Size(125, 17);
            this.labelAddMemberPhoneNum.TabIndex = 10;
            this.labelAddMemberPhoneNum.Text = "Номер телефона:";
            // 
            // labelFullNameAddMembers
            // 
            this.labelFullNameAddMembers.AutoSize = true;
            this.labelFullNameAddMembers.Location = new System.Drawing.Point(12, 9);
            this.labelFullNameAddMembers.Name = "labelFullNameAddMembers";
            this.labelFullNameAddMembers.Size = new System.Drawing.Size(46, 17);
            this.labelFullNameAddMembers.TabIndex = 9;
            this.labelFullNameAddMembers.Text = "ФИО:";
            // 
            // addMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 128);
            this.Controls.Add(this.buttonAddMemberSave);
            this.Controls.Add(this.textBoxAddMemberPhoneNum);
            this.Controls.Add(this.textBoxAddMemberEmail);
            this.Controls.Add(this.textBoxAddMemberFullName);
            this.Controls.Add(this.labelAddMemberEmail);
            this.Controls.Add(this.labelAddMemberPhoneNum);
            this.Controls.Add(this.labelFullNameAddMembers);
            this.MinimumSize = new System.Drawing.Size(645, 175);
            this.Name = "addMembers";
            this.Text = "Добавление участника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMemberSave;
        private System.Windows.Forms.TextBox textBoxAddMemberPhoneNum;
        private System.Windows.Forms.TextBox textBoxAddMemberEmail;
        private System.Windows.Forms.TextBox textBoxAddMemberFullName;
        private System.Windows.Forms.Label labelAddMemberEmail;
        private System.Windows.Forms.Label labelAddMemberPhoneNum;
        private System.Windows.Forms.Label labelFullNameAddMembers;
    }
}