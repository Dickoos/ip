namespace ip
{
    partial class AllMembers
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxAllMemeberList = new System.Windows.Forms.ListBox();
            this.buttonAllMemeberSearch = new System.Windows.Forms.Button();
            this.textBoxAllMemeberFullName = new System.Windows.Forms.TextBox();
            this.labelAllMemberFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Location = new System.Drawing.Point(331, 45);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 27);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // listBoxAllMemeberList
            // 
            this.listBoxAllMemeberList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllMemeberList.FormattingEnabled = true;
            this.listBoxAllMemeberList.ItemHeight = 16;
            this.listBoxAllMemeberList.Location = new System.Drawing.Point(12, 74);
            this.listBoxAllMemeberList.Name = "listBoxAllMemeberList";
            this.listBoxAllMemeberList.Size = new System.Drawing.Size(403, 132);
            this.listBoxAllMemeberList.TabIndex = 8;
            this.listBoxAllMemeberList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAllMemeberList_MouseClick);
            // 
            // buttonAllMemeberSearch
            // 
            this.buttonAllMemeberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllMemeberSearch.Location = new System.Drawing.Point(12, 45);
            this.buttonAllMemeberSearch.Name = "buttonAllMemeberSearch";
            this.buttonAllMemeberSearch.Size = new System.Drawing.Size(313, 23);
            this.buttonAllMemeberSearch.TabIndex = 7;
            this.buttonAllMemeberSearch.Text = "Поиск";
            this.buttonAllMemeberSearch.UseVisualStyleBackColor = true;
            this.buttonAllMemeberSearch.Click += new System.EventHandler(this.ButtonAllMemeberSearch_Click);
            // 
            // textBoxAllMemeberFullName
            // 
            this.textBoxAllMemeberFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAllMemeberFullName.Location = new System.Drawing.Point(64, 17);
            this.textBoxAllMemeberFullName.Name = "textBoxAllMemeberFullName";
            this.textBoxAllMemeberFullName.Size = new System.Drawing.Size(351, 22);
            this.textBoxAllMemeberFullName.TabIndex = 6;
            // 
            // labelAllMemberFullName
            // 
            this.labelAllMemberFullName.AutoSize = true;
            this.labelAllMemberFullName.Location = new System.Drawing.Point(12, 20);
            this.labelAllMemberFullName.Name = "labelAllMemberFullName";
            this.labelAllMemberFullName.Size = new System.Drawing.Size(46, 17);
            this.labelAllMemberFullName.TabIndex = 5;
            this.labelAllMemberFullName.Text = "ФИО:";
            // 
            // AllMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 223);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxAllMemeberList);
            this.Controls.Add(this.buttonAllMemeberSearch);
            this.Controls.Add(this.textBoxAllMemeberFullName);
            this.Controls.Add(this.labelAllMemberFullName);
            this.MinimumSize = new System.Drawing.Size(445, 270);
            this.Name = "AllMembers";
            this.Text = "Все участники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ListBox listBoxAllMemeberList;
        private System.Windows.Forms.Button buttonAllMemeberSearch;
        private System.Windows.Forms.TextBox textBoxAllMemeberFullName;
        private System.Windows.Forms.Label labelAllMemberFullName;
    }
}