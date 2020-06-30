namespace ip
{
    partial class MembersListMeet
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdateMembersList = new System.Windows.Forms.Button();
            this.listBoxAllMembersOnMeet = new System.Windows.Forms.ListBox();
            this.labelYearSearch = new System.Windows.Forms.Label();
            this.labelFullNameSearch = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonTableAllMembers = new System.Windows.Forms.Button();
            this.buttonAddMemberToMeet = new System.Windows.Forms.Button();
            this.buttonAddMembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 92);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(177, 23);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonUpdateMembersList
            // 
            this.buttonUpdateMembersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateMembersList.AutoSize = true;
            this.buttonUpdateMembersList.Location = new System.Drawing.Point(302, 26);
            this.buttonUpdateMembersList.Name = "buttonUpdateMembersList";
            this.buttonUpdateMembersList.Size = new System.Drawing.Size(210, 27);
            this.buttonUpdateMembersList.TabIndex = 19;
            this.buttonUpdateMembersList.Text = "Обновить список участников";
            this.buttonUpdateMembersList.UseVisualStyleBackColor = true;
            this.buttonUpdateMembersList.Click += new System.EventHandler(this.ButtonUpdateMembersList_Click);
            // 
            // listBoxAllMembersOnMeet
            // 
            this.listBoxAllMembersOnMeet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllMembersOnMeet.FormattingEnabled = true;
            this.listBoxAllMembersOnMeet.ItemHeight = 16;
            this.listBoxAllMembersOnMeet.Location = new System.Drawing.Point(12, 188);
            this.listBoxAllMembersOnMeet.Name = "listBoxAllMembersOnMeet";
            this.listBoxAllMembersOnMeet.Size = new System.Drawing.Size(500, 244);
            this.listBoxAllMembersOnMeet.TabIndex = 18;
            this.listBoxAllMembersOnMeet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAllMembersOnMeet_MouseDoubleClick);
            // 
            // labelYearSearch
            // 
            this.labelYearSearch.AutoSize = true;
            this.labelYearSearch.Location = new System.Drawing.Point(12, 48);
            this.labelYearSearch.Name = "labelYearSearch";
            this.labelYearSearch.Size = new System.Drawing.Size(96, 17);
            this.labelYearSearch.TabIndex = 17;
            this.labelYearSearch.Text = "YYYY-MM-DD";
            // 
            // labelFullNameSearch
            // 
            this.labelFullNameSearch.AutoSize = true;
            this.labelFullNameSearch.Location = new System.Drawing.Point(12, 23);
            this.labelFullNameSearch.Name = "labelFullNameSearch";
            this.labelFullNameSearch.Size = new System.Drawing.Size(35, 17);
            this.labelFullNameSearch.TabIndex = 16;
            this.labelFullNameSearch.Text = "Имя";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Location = new System.Drawing.Point(114, 45);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(126, 22);
            this.textBoxDate.TabIndex = 15;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.Location = new System.Drawing.Point(53, 20);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(187, 22);
            this.textBoxFullName.TabIndex = 14;
            // 
            // buttonTableAllMembers
            // 
            this.buttonTableAllMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTableAllMembers.AutoSize = true;
            this.buttonTableAllMembers.Location = new System.Drawing.Point(326, 125);
            this.buttonTableAllMembers.Name = "buttonTableAllMembers";
            this.buttonTableAllMembers.Size = new System.Drawing.Size(186, 27);
            this.buttonTableAllMembers.TabIndex = 13;
            this.buttonTableAllMembers.Text = "Таблица всех участников";
            this.buttonTableAllMembers.UseVisualStyleBackColor = true;
            this.buttonTableAllMembers.Click += new System.EventHandler(this.ButtonTableAllMembers_Click);
            // 
            // buttonAddMemberToMeet
            // 
            this.buttonAddMemberToMeet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMemberToMeet.AutoSize = true;
            this.buttonAddMemberToMeet.Location = new System.Drawing.Point(282, 92);
            this.buttonAddMemberToMeet.Name = "buttonAddMemberToMeet";
            this.buttonAddMemberToMeet.Size = new System.Drawing.Size(230, 27);
            this.buttonAddMemberToMeet.TabIndex = 12;
            this.buttonAddMemberToMeet.Text = "Добавить участника на встречу";
            this.buttonAddMemberToMeet.UseVisualStyleBackColor = true;
            this.buttonAddMemberToMeet.Click += new System.EventHandler(this.ButtonAddMemberToMeet_Click);
            // 
            // buttonAddMembers
            // 
            this.buttonAddMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMembers.AutoSize = true;
            this.buttonAddMembers.Location = new System.Drawing.Point(358, 59);
            this.buttonAddMembers.Name = "buttonAddMembers";
            this.buttonAddMembers.Size = new System.Drawing.Size(154, 27);
            this.buttonAddMembers.TabIndex = 11;
            this.buttonAddMembers.Text = "Добавить участника";
            this.buttonAddMembers.UseVisualStyleBackColor = true;
            this.buttonAddMembers.Click += new System.EventHandler(this.ButtonAddMembers_Click);
            // 
            // MembersListMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 453);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdateMembersList);
            this.Controls.Add(this.listBoxAllMembersOnMeet);
            this.Controls.Add(this.labelYearSearch);
            this.Controls.Add(this.labelFullNameSearch);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.buttonTableAllMembers);
            this.Controls.Add(this.buttonAddMemberToMeet);
            this.Controls.Add(this.buttonAddMembers);
            this.MinimumSize = new System.Drawing.Size(540, 500);
            this.Name = "MembersListMeet";
            this.Text = "Участники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdateMembersList;
        private System.Windows.Forms.ListBox listBoxAllMembersOnMeet;
        private System.Windows.Forms.Label labelYearSearch;
        private System.Windows.Forms.Label labelFullNameSearch;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button buttonTableAllMembers;
        private System.Windows.Forms.Button buttonAddMemberToMeet;
        private System.Windows.Forms.Button buttonAddMembers;
    }
}