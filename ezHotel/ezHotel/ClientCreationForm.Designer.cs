namespace ezHotel
{
    partial class ClientCreationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passportNumberText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(12, 72);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(393, 20);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(12, 115);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(393, 20);
            this.lastNameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(12, 160);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(393, 20);
            this.phoneText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(12, 207);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(393, 20);
            this.emailText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(12, 259);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(393, 20);
            this.countryText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country";
            // 
            // passportNumberText
            // 
            this.passportNumberText.Location = new System.Drawing.Point(12, 310);
            this.passportNumberText.Name = "passportNumberText";
            this.passportNumberText.Size = new System.Drawing.Size(393, 20);
            this.passportNumberText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Passport number";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 351);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Create";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ClientCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 469);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passportNumberText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(433, 508);
            this.MinimumSize = new System.Drawing.Size(433, 508);
            this.Name = "ClientCreationForm";
            this.Text = "Create a Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passportNumberText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
    }
}