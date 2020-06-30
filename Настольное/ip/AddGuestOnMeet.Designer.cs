namespace ip
{
    partial class AddGuestOnMeet
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
            this.labelAddGuestOnMeetFullName = new System.Windows.Forms.Label();
            this.labelAddGuestOnMeetDate = new System.Windows.Forms.Label();
            this.textBoxAddGuestOnMeetFullName = new System.Windows.Forms.TextBox();
            this.textBoxAddGuestOnMeetDate = new System.Windows.Forms.TextBox();
            this.buttonAddGuestOnMeet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddGuestOnMeetFullName
            // 
            this.labelAddGuestOnMeetFullName.AutoSize = true;
            this.labelAddGuestOnMeetFullName.Location = new System.Drawing.Point(12, 9);
            this.labelAddGuestOnMeetFullName.Name = "labelAddGuestOnMeetFullName";
            this.labelAddGuestOnMeetFullName.Size = new System.Drawing.Size(46, 17);
            this.labelAddGuestOnMeetFullName.TabIndex = 0;
            this.labelAddGuestOnMeetFullName.Text = "ФИО:";
            // 
            // labelAddGuestOnMeetDate
            // 
            this.labelAddGuestOnMeetDate.AutoSize = true;
            this.labelAddGuestOnMeetDate.Location = new System.Drawing.Point(12, 37);
            this.labelAddGuestOnMeetDate.Name = "labelAddGuestOnMeetDate";
            this.labelAddGuestOnMeetDate.Size = new System.Drawing.Size(100, 17);
            this.labelAddGuestOnMeetDate.TabIndex = 1;
            this.labelAddGuestOnMeetDate.Text = "YYYY-MM-DD:";
            // 
            // textBoxAddGuestOnMeetFullName
            // 
            this.textBoxAddGuestOnMeetFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddGuestOnMeetFullName.Location = new System.Drawing.Point(64, 6);
            this.textBoxAddGuestOnMeetFullName.Name = "textBoxAddGuestOnMeetFullName";
            this.textBoxAddGuestOnMeetFullName.Size = new System.Drawing.Size(587, 22);
            this.textBoxAddGuestOnMeetFullName.TabIndex = 2;
            // 
            // textBoxAddGuestOnMeetDate
            // 
            this.textBoxAddGuestOnMeetDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddGuestOnMeetDate.Location = new System.Drawing.Point(118, 34);
            this.textBoxAddGuestOnMeetDate.Name = "textBoxAddGuestOnMeetDate";
            this.textBoxAddGuestOnMeetDate.Size = new System.Drawing.Size(533, 22);
            this.textBoxAddGuestOnMeetDate.TabIndex = 3;
            // 
            // buttonAddGuestOnMeet
            // 
            this.buttonAddGuestOnMeet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGuestOnMeet.Location = new System.Drawing.Point(12, 62);
            this.buttonAddGuestOnMeet.Name = "buttonAddGuestOnMeet";
            this.buttonAddGuestOnMeet.Size = new System.Drawing.Size(639, 23);
            this.buttonAddGuestOnMeet.TabIndex = 4;
            this.buttonAddGuestOnMeet.Text = "Добавить гостя на встречу";
            this.buttonAddGuestOnMeet.UseVisualStyleBackColor = true;
            this.buttonAddGuestOnMeet.Click += new System.EventHandler(this.ButtonAddGuestOnMeet_Click);
            // 
            // AddGuestOnMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 95);
            this.Controls.Add(this.buttonAddGuestOnMeet);
            this.Controls.Add(this.textBoxAddGuestOnMeetDate);
            this.Controls.Add(this.textBoxAddGuestOnMeetFullName);
            this.Controls.Add(this.labelAddGuestOnMeetDate);
            this.Controls.Add(this.labelAddGuestOnMeetFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddGuestOnMeet";
            this.Text = "Добавить гостя на встречу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddGuestOnMeetFullName;
        private System.Windows.Forms.Label labelAddGuestOnMeetDate;
        private System.Windows.Forms.TextBox textBoxAddGuestOnMeetFullName;
        private System.Windows.Forms.TextBox textBoxAddGuestOnMeetDate;
        private System.Windows.Forms.Button buttonAddGuestOnMeet;
    }
}