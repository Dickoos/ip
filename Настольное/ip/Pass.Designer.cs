namespace ip
{
    partial class Pass
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
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_tryPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pass
            // 
            this.textBox_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pass.Location = new System.Drawing.Point(12, 12);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(322, 22);
            this.textBox_pass.TabIndex = 0;
            // 
            // button_tryPass
            // 
            this.button_tryPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tryPass.Location = new System.Drawing.Point(12, 40);
            this.button_tryPass.Name = "button_tryPass";
            this.button_tryPass.Size = new System.Drawing.Size(322, 39);
            this.button_tryPass.TabIndex = 1;
            this.button_tryPass.Text = "Вход";
            this.button_tryPass.UseVisualStyleBackColor = true;
            this.button_tryPass.Click += new System.EventHandler(this.Button_tryPass_Click);
            // 
            // Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 91);
            this.Controls.Add(this.button_tryPass);
            this.Controls.Add(this.textBox_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pass";
            this.Text = "Пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_tryPass;
    }
}