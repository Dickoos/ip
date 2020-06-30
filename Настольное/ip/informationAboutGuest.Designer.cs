namespace ip
{
    partial class InformationAboutGuest
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
            this.labelGuestId = new System.Windows.Forms.Label();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPersonalInformation = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelPersonalInformation = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGuestId
            // 
            this.labelGuestId.AutoSize = true;
            this.labelGuestId.Location = new System.Drawing.Point(13, 13);
            this.labelGuestId.Name = "labelGuestId";
            this.labelGuestId.Size = new System.Drawing.Size(19, 17);
            this.labelGuestId.TabIndex = 0;
            this.labelGuestId.Text = "id";
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneNum.Location = new System.Drawing.Point(143, 54);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(780, 22);
            this.textBoxPhoneNum.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(64, 82);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(859, 22);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxPersonalInformation
            // 
            this.textBoxPersonalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPersonalInformation.Location = new System.Drawing.Point(12, 127);
            this.textBoxPersonalInformation.Multiline = true;
            this.textBoxPersonalInformation.Name = "textBoxPersonalInformation";
            this.textBoxPersonalInformation.Size = new System.Drawing.Size(911, 405);
            this.textBoxPersonalInformation.TabIndex = 13;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.Location = new System.Drawing.Point(64, 26);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(859, 22);
            this.textBoxFullName.TabIndex = 12;
            // 
            // labelPersonalInformation
            // 
            this.labelPersonalInformation.AutoSize = true;
            this.labelPersonalInformation.Location = new System.Drawing.Point(12, 107);
            this.labelPersonalInformation.Name = "labelPersonalInformation";
            this.labelPersonalInformation.Size = new System.Drawing.Size(150, 17);
            this.labelPersonalInformation.TabIndex = 11;
            this.labelPersonalInformation.Text = "Личная информация:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 85);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Location = new System.Drawing.Point(12, 57);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(125, 17);
            this.labelPhoneNum.TabIndex = 9;
            this.labelPhoneNum.Text = "Номер телефона:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 30);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(46, 17);
            this.labelFullName.TabIndex = 8;
            this.labelFullName.Text = "ФИО:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(12, 538);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.AutoSize = true;
            this.buttonDel.Location = new System.Drawing.Point(848, 538);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 27);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // informationAboutGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 577);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPersonalInformation);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelPersonalInformation);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNum);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelGuestId);
            this.Name = "informationAboutGuest";
            this.Text = "Информация о госте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGuestId;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPersonalInformation;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelPersonalInformation;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDel;
    }
}