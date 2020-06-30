namespace ip
{
    partial class AddMemberOnMeet
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
            this.buttonAddMemberOnMeet = new System.Windows.Forms.Button();
            this.textBoxAddMemberOnMeetDate = new System.Windows.Forms.TextBox();
            this.textBoxAddMemeberOnMeetFullName = new System.Windows.Forms.TextBox();
            this.labelAddMemeberOnMeetDate = new System.Windows.Forms.Label();
            this.labelAddMEmberOnMeetFullName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddMemberOnMeet
            // 
            this.buttonAddMemberOnMeet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMemberOnMeet.Location = new System.Drawing.Point(12, 90);
            this.buttonAddMemberOnMeet.Name = "buttonAddMemberOnMeet";
            this.buttonAddMemberOnMeet.Size = new System.Drawing.Size(680, 23);
            this.buttonAddMemberOnMeet.TabIndex = 9;
            this.buttonAddMemberOnMeet.Text = "Добавить участника на встречу";
            this.buttonAddMemberOnMeet.UseVisualStyleBackColor = true;
            this.buttonAddMemberOnMeet.Click += new System.EventHandler(this.ButtonAddMemberOnMeet_Click);
            // 
            // textBoxAddGuestOnMeetDate
            // 
            this.textBoxAddMemberOnMeetDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddMemberOnMeetDate.Location = new System.Drawing.Point(118, 62);
            this.textBoxAddMemberOnMeetDate.Name = "textBoxAddGuestOnMeetDate";
            this.textBoxAddMemberOnMeetDate.Size = new System.Drawing.Size(574, 22);
            this.textBoxAddMemberOnMeetDate.TabIndex = 8;
            // 
            // textBoxAddGuestOnMeetFullName
            // 
            this.textBoxAddMemeberOnMeetFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddMemeberOnMeetFullName.Location = new System.Drawing.Point(64, 6);
            this.textBoxAddMemeberOnMeetFullName.Name = "textBoxAddGuestOnMeetFullName";
            this.textBoxAddMemeberOnMeetFullName.Size = new System.Drawing.Size(628, 22);
            this.textBoxAddMemeberOnMeetFullName.TabIndex = 7;
            // 
            // labelAddGuestOnMeetDate
            // 
            this.labelAddMemeberOnMeetDate.AutoSize = true;
            this.labelAddMemeberOnMeetDate.Location = new System.Drawing.Point(12, 65);
            this.labelAddMemeberOnMeetDate.Name = "labelAddGuestOnMeetDate";
            this.labelAddMemeberOnMeetDate.Size = new System.Drawing.Size(100, 17);
            this.labelAddMemeberOnMeetDate.TabIndex = 6;
            this.labelAddMemeberOnMeetDate.Text = "YYYY-MM-DD:";
            // 
            // labelAddGuestOnMeetFullName
            // 
            this.labelAddMEmberOnMeetFullName.AutoSize = true;
            this.labelAddMEmberOnMeetFullName.Location = new System.Drawing.Point(12, 9);
            this.labelAddMEmberOnMeetFullName.Name = "labelAddGuestOnMeetFullName";
            this.labelAddMEmberOnMeetFullName.Size = new System.Drawing.Size(46, 17);
            this.labelAddMEmberOnMeetFullName.TabIndex = 5;
            this.labelAddMEmberOnMeetFullName.Text = "ФИО:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(12, 37);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(85, 17);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Должность:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPosition.Location = new System.Drawing.Point(103, 34);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(589, 22);
            this.textBoxPosition.TabIndex = 11;
            // 
            // AddMemberOnMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 132);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.buttonAddMemberOnMeet);
            this.Controls.Add(this.textBoxAddMemberOnMeetDate);
            this.Controls.Add(this.textBoxAddMemeberOnMeetFullName);
            this.Controls.Add(this.labelAddMemeberOnMeetDate);
            this.Controls.Add(this.labelAddMEmberOnMeetFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMemberOnMeet";
            this.Text = "Добавить участника на встречу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMemberOnMeet;
        private System.Windows.Forms.TextBox textBoxAddMemberOnMeetDate;
        private System.Windows.Forms.TextBox textBoxAddMemeberOnMeetFullName;
        private System.Windows.Forms.Label labelAddMemeberOnMeetDate;
        private System.Windows.Forms.Label labelAddMEmberOnMeetFullName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
    }
}