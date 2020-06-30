namespace ip
{
    partial class AllGuests
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
            this.labelAllGuestsFullName = new System.Windows.Forms.Label();
            this.textBoxAllGuestsFullName = new System.Windows.Forms.TextBox();
            this.buttonAllGuestsSearch = new System.Windows.Forms.Button();
            this.listBoxAllGuestsList = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAllGuestsFullName
            // 
            this.labelAllGuestsFullName.AutoSize = true;
            this.labelAllGuestsFullName.Location = new System.Drawing.Point(12, 9);
            this.labelAllGuestsFullName.Name = "labelAllGuestsFullName";
            this.labelAllGuestsFullName.Size = new System.Drawing.Size(46, 17);
            this.labelAllGuestsFullName.TabIndex = 0;
            this.labelAllGuestsFullName.Text = "ФИО:";
            // 
            // textBoxAllGuestsFullName
            // 
            this.textBoxAllGuestsFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAllGuestsFullName.Location = new System.Drawing.Point(64, 6);
            this.textBoxAllGuestsFullName.Name = "textBoxAllGuestsFullName";
            this.textBoxAllGuestsFullName.Size = new System.Drawing.Size(351, 22);
            this.textBoxAllGuestsFullName.TabIndex = 1;
            // 
            // buttonAllGuestsSearch
            // 
            this.buttonAllGuestsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllGuestsSearch.Location = new System.Drawing.Point(12, 34);
            this.buttonAllGuestsSearch.Name = "buttonAllGuestsSearch";
            this.buttonAllGuestsSearch.Size = new System.Drawing.Size(313, 23);
            this.buttonAllGuestsSearch.TabIndex = 2;
            this.buttonAllGuestsSearch.Text = "Поиск";
            this.buttonAllGuestsSearch.UseVisualStyleBackColor = true;
            this.buttonAllGuestsSearch.Click += new System.EventHandler(this.ButtonAllGuestsSearch_Click);
            // 
            // listBoxAllGuestsList
            // 
            this.listBoxAllGuestsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllGuestsList.FormattingEnabled = true;
            this.listBoxAllGuestsList.ItemHeight = 16;
            this.listBoxAllGuestsList.Location = new System.Drawing.Point(12, 63);
            this.listBoxAllGuestsList.Name = "listBoxAllGuestsList";
            this.listBoxAllGuestsList.Size = new System.Drawing.Size(403, 132);
            this.listBoxAllGuestsList.TabIndex = 3;
            this.listBoxAllGuestsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxAllGuestsList_MouseClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Location = new System.Drawing.Point(331, 34);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 27);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // AllGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 223);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxAllGuestsList);
            this.Controls.Add(this.buttonAllGuestsSearch);
            this.Controls.Add(this.textBoxAllGuestsFullName);
            this.Controls.Add(this.labelAllGuestsFullName);
            this.MinimumSize = new System.Drawing.Size(445, 270);
            this.Name = "AllGuests";
            this.Text = "Все гости";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAllGuestsFullName;
        private System.Windows.Forms.TextBox textBoxAllGuestsFullName;
        private System.Windows.Forms.Button buttonAllGuestsSearch;
        private System.Windows.Forms.ListBox listBoxAllGuestsList;
        private System.Windows.Forms.Button buttonUpdate;
    }
}