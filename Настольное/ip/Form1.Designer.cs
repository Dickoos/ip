namespace ip
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.buttonAddGuestToMeet = new System.Windows.Forms.Button();
            this.buttonTableAllGuests = new System.Windows.Forms.Button();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelFullNameSearch = new System.Windows.Forms.Label();
            this.labelYearSearch = new System.Windows.Forms.Label();
            this.listBoxAllGuestsOnMeet = new System.Windows.Forms.ListBox();
            this.buttonUpdateGuestList = new System.Windows.Forms.Button();
            this.buttonMembersTable = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGuest.AutoSize = true;
            this.buttonAddGuest.Location = new System.Drawing.Point(304, 45);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(121, 27);
            this.buttonAddGuest.TabIndex = 0;
            this.buttonAddGuest.Text = "Добавить гостя";
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            this.buttonAddGuest.Click += new System.EventHandler(this.ButtonAddGuest_Click);
            // 
            // buttonAddGuestToMeet
            // 
            this.buttonAddGuestToMeet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGuestToMeet.AutoSize = true;
            this.buttonAddGuestToMeet.Location = new System.Drawing.Point(228, 78);
            this.buttonAddGuestToMeet.Name = "buttonAddGuestToMeet";
            this.buttonAddGuestToMeet.Size = new System.Drawing.Size(197, 27);
            this.buttonAddGuestToMeet.TabIndex = 1;
            this.buttonAddGuestToMeet.Text = "Добавить гостя на встречу";
            this.buttonAddGuestToMeet.UseVisualStyleBackColor = true;
            this.buttonAddGuestToMeet.Click += new System.EventHandler(this.ButtonAddGuestToMeet_Click);
            // 
            // buttonTableAllGuests
            // 
            this.buttonTableAllGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTableAllGuests.AutoSize = true;
            this.buttonTableAllGuests.Location = new System.Drawing.Point(271, 111);
            this.buttonTableAllGuests.Name = "buttonTableAllGuests";
            this.buttonTableAllGuests.Size = new System.Drawing.Size(154, 27);
            this.buttonTableAllGuests.TabIndex = 2;
            this.buttonTableAllGuests.Text = "Таблица всех гостей";
            this.buttonTableAllGuests.UseVisualStyleBackColor = true;
            this.buttonTableAllGuests.Click += new System.EventHandler(this.ButtonTableAllGuests_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.Location = new System.Drawing.Point(53, 6);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFullName.TabIndex = 3;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Location = new System.Drawing.Point(114, 31);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxDate.TabIndex = 4;
            // 
            // labelFullNameSearch
            // 
            this.labelFullNameSearch.AutoSize = true;
            this.labelFullNameSearch.Location = new System.Drawing.Point(12, 9);
            this.labelFullNameSearch.Name = "labelFullNameSearch";
            this.labelFullNameSearch.Size = new System.Drawing.Size(35, 17);
            this.labelFullNameSearch.TabIndex = 5;
            this.labelFullNameSearch.Text = "Имя";
            // 
            // labelYearSearch
            // 
            this.labelYearSearch.AutoSize = true;
            this.labelYearSearch.Location = new System.Drawing.Point(12, 34);
            this.labelYearSearch.Name = "labelYearSearch";
            this.labelYearSearch.Size = new System.Drawing.Size(96, 17);
            this.labelYearSearch.TabIndex = 6;
            this.labelYearSearch.Text = "YYYY-MM-DD";
            // 
            // listBoxAllGuestsOnMeet
            // 
            this.listBoxAllGuestsOnMeet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllGuestsOnMeet.FormattingEnabled = true;
            this.listBoxAllGuestsOnMeet.ItemHeight = 16;
            this.listBoxAllGuestsOnMeet.Location = new System.Drawing.Point(12, 174);
            this.listBoxAllGuestsOnMeet.Name = "listBoxAllGuestsOnMeet";
            this.listBoxAllGuestsOnMeet.Size = new System.Drawing.Size(413, 244);
            this.listBoxAllGuestsOnMeet.TabIndex = 7;
            this.listBoxAllGuestsOnMeet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAllGuestsOnMeet_MouseDoubleClick);
            // 
            // buttonUpdateGuestList
            // 
            this.buttonUpdateGuestList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateGuestList.AutoSize = true;
            this.buttonUpdateGuestList.Location = new System.Drawing.Point(247, 12);
            this.buttonUpdateGuestList.Name = "buttonUpdateGuestList";
            this.buttonUpdateGuestList.Size = new System.Drawing.Size(178, 27);
            this.buttonUpdateGuestList.TabIndex = 8;
            this.buttonUpdateGuestList.Text = "Обновить список гостей";
            this.buttonUpdateGuestList.UseVisualStyleBackColor = true;
            this.buttonUpdateGuestList.Click += new System.EventHandler(this.ButtonUpdateGuestList_Click);
            // 
            // buttonMembersTable
            // 
            this.buttonMembersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMembersTable.AutoSize = true;
            this.buttonMembersTable.Location = new System.Drawing.Point(239, 144);
            this.buttonMembersTable.Name = "buttonMembersTable";
            this.buttonMembersTable.Size = new System.Drawing.Size(186, 27);
            this.buttonMembersTable.TabIndex = 9;
            this.buttonMembersTable.Text = "Таблица участников";
            this.buttonMembersTable.UseVisualStyleBackColor = true;
            this.buttonMembersTable.Click += new System.EventHandler(this.ButtonAllMembersTable_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 78);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(202, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 453);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonMembersTable);
            this.Controls.Add(this.buttonUpdateGuestList);
            this.Controls.Add(this.listBoxAllGuestsOnMeet);
            this.Controls.Add(this.labelYearSearch);
            this.Controls.Add(this.labelFullNameSearch);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.buttonTableAllGuests);
            this.Controls.Add(this.buttonAddGuestToMeet);
            this.Controls.Add(this.buttonAddGuest);
            this.MinimumSize = new System.Drawing.Size(455, 500);
            this.Name = "Form1";
            this.Text = "Гости";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.Button buttonAddGuestToMeet;
        private System.Windows.Forms.Button buttonTableAllGuests;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelFullNameSearch;
        private System.Windows.Forms.Label labelYearSearch;
        private System.Windows.Forms.ListBox listBoxAllGuestsOnMeet;
        private System.Windows.Forms.Button buttonUpdateGuestList;
        private System.Windows.Forms.Button buttonMembersTable;
        private System.Windows.Forms.Button buttonSearch;
    }
}

