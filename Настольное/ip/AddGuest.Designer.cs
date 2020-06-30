namespace ip
{
    partial class AddGuest
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
            this.labelFullNameAddGuest = new System.Windows.Forms.Label();
            this.labelAddGuestPhoneNum = new System.Windows.Forms.Label();
            this.labelAddGuestEmail = new System.Windows.Forms.Label();
            this.labelAddGuestPersonalInformation = new System.Windows.Forms.Label();
            this.textBoxAddGuestFullName = new System.Windows.Forms.TextBox();
            this.textBoxAddGuestPersonalInformation = new System.Windows.Forms.TextBox();
            this.textBoxAddGuestEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddGuestPhoneNum = new System.Windows.Forms.TextBox();
            this.buttonAddGuestSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFullNameAddGuest
            // 
            this.labelFullNameAddGuest.AutoSize = true;
            this.labelFullNameAddGuest.Location = new System.Drawing.Point(12, 9);
            this.labelFullNameAddGuest.Name = "labelFullNameAddGuest";
            this.labelFullNameAddGuest.Size = new System.Drawing.Size(46, 17);
            this.labelFullNameAddGuest.TabIndex = 0;
            this.labelFullNameAddGuest.Text = "ФИО:";
            // 
            // labelAddGuestPhoneNum
            // 
            this.labelAddGuestPhoneNum.AutoSize = true;
            this.labelAddGuestPhoneNum.Location = new System.Drawing.Point(12, 37);
            this.labelAddGuestPhoneNum.Name = "labelAddGuestPhoneNum";
            this.labelAddGuestPhoneNum.Size = new System.Drawing.Size(125, 17);
            this.labelAddGuestPhoneNum.TabIndex = 1;
            this.labelAddGuestPhoneNum.Text = "Номер телефона:";
            // 
            // labelAddGuestEmail
            // 
            this.labelAddGuestEmail.AutoSize = true;
            this.labelAddGuestEmail.Location = new System.Drawing.Point(12, 65);
            this.labelAddGuestEmail.Name = "labelAddGuestEmail";
            this.labelAddGuestEmail.Size = new System.Drawing.Size(46, 17);
            this.labelAddGuestEmail.TabIndex = 2;
            this.labelAddGuestEmail.Text = "Email:";
            // 
            // labelAddGuestPersonalInformation
            // 
            this.labelAddGuestPersonalInformation.AutoSize = true;
            this.labelAddGuestPersonalInformation.Location = new System.Drawing.Point(12, 87);
            this.labelAddGuestPersonalInformation.Name = "labelAddGuestPersonalInformation";
            this.labelAddGuestPersonalInformation.Size = new System.Drawing.Size(150, 17);
            this.labelAddGuestPersonalInformation.TabIndex = 3;
            this.labelAddGuestPersonalInformation.Text = "Личная информация:";
            // 
            // textBoxAddGuestFullName
            // 
            this.textBoxAddGuestFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddGuestFullName.Location = new System.Drawing.Point(64, 6);
            this.textBoxAddGuestFullName.Name = "textBoxAddGuestFullName";
            this.textBoxAddGuestFullName.Size = new System.Drawing.Size(450, 22);
            this.textBoxAddGuestFullName.TabIndex = 4;
            // 
            // textBoxAddGuestPersonalInformation
            // 
            this.textBoxAddGuestPersonalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddGuestPersonalInformation.Location = new System.Drawing.Point(12, 107);
            this.textBoxAddGuestPersonalInformation.Multiline = true;
            this.textBoxAddGuestPersonalInformation.Name = "textBoxAddGuestPersonalInformation";
            this.textBoxAddGuestPersonalInformation.Size = new System.Drawing.Size(502, 302);
            this.textBoxAddGuestPersonalInformation.TabIndex = 5;
            // 
            // textBoxAddGuestEmail
            // 
            this.textBoxAddGuestEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddGuestEmail.Location = new System.Drawing.Point(63, 62);
            this.textBoxAddGuestEmail.Name = "textBoxAddGuestEmail";
            this.textBoxAddGuestEmail.Size = new System.Drawing.Size(451, 22);
            this.textBoxAddGuestEmail.TabIndex = 6;
            // 
            // textBoxAddGuestPhoneNum
            // 
            this.textBoxAddGuestPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddGuestPhoneNum.Location = new System.Drawing.Point(143, 34);
            this.textBoxAddGuestPhoneNum.Name = "textBoxAddGuestPhoneNum";
            this.textBoxAddGuestPhoneNum.Size = new System.Drawing.Size(371, 22);
            this.textBoxAddGuestPhoneNum.TabIndex = 7;
            // 
            // buttonAddGuestSave
            // 
            this.buttonAddGuestSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGuestSave.Location = new System.Drawing.Point(12, 415);
            this.buttonAddGuestSave.Name = "buttonAddGuestSave";
            this.buttonAddGuestSave.Size = new System.Drawing.Size(502, 23);
            this.buttonAddGuestSave.TabIndex = 8;
            this.buttonAddGuestSave.Text = "Сохранить";
            this.buttonAddGuestSave.UseVisualStyleBackColor = true;
            this.buttonAddGuestSave.Click += new System.EventHandler(this.ButtonAddGuestSave_Click);
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.buttonAddGuestSave);
            this.Controls.Add(this.textBoxAddGuestPhoneNum);
            this.Controls.Add(this.textBoxAddGuestEmail);
            this.Controls.Add(this.textBoxAddGuestPersonalInformation);
            this.Controls.Add(this.textBoxAddGuestFullName);
            this.Controls.Add(this.labelAddGuestPersonalInformation);
            this.Controls.Add(this.labelAddGuestEmail);
            this.Controls.Add(this.labelAddGuestPhoneNum);
            this.Controls.Add(this.labelFullNameAddGuest);
            this.Name = "AddGuest";
            this.Text = "Добавление гостя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullNameAddGuest;
        private System.Windows.Forms.Label labelAddGuestPhoneNum;
        private System.Windows.Forms.Label labelAddGuestEmail;
        private System.Windows.Forms.Label labelAddGuestPersonalInformation;
        private System.Windows.Forms.TextBox textBoxAddGuestFullName;
        private System.Windows.Forms.TextBox textBoxAddGuestPersonalInformation;
        private System.Windows.Forms.TextBox textBoxAddGuestEmail;
        private System.Windows.Forms.TextBox textBoxAddGuestPhoneNum;
        private System.Windows.Forms.Button buttonAddGuestSave;
    }
}