namespace ezHotel
{
    partial class ManageClientsForm
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
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passportNumberText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.tableUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClient
            // 
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Location = new System.Drawing.Point(12, 187);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.ReadOnly = true;
            this.dataGridClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClient.Size = new System.Drawing.Size(782, 321);
            this.dataGridClient.TabIndex = 0;
            this.dataGridClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClient_CellContentClick);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(12, 31);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(184, 20);
            this.firstNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(12, 72);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(184, 20);
            this.lastNameText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(202, 31);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(184, 20);
            this.phoneText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(202, 72);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(184, 20);
            this.emailText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(392, 31);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(184, 20);
            this.countryText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Passport number";
            // 
            // passportNumberText
            // 
            this.passportNumberText.Location = new System.Drawing.Point(392, 72);
            this.passportNumberText.Name = "passportNumberText";
            this.passportNumberText.Size = new System.Drawing.Size(184, 20);
            this.passportNumberText.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(582, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 20);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(582, 71);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 20);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(677, 31);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(89, 20);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Create form";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tableUpdateButton
            // 
            this.tableUpdateButton.Location = new System.Drawing.Point(677, 71);
            this.tableUpdateButton.Name = "tableUpdateButton";
            this.tableUpdateButton.Size = new System.Drawing.Size(89, 20);
            this.tableUpdateButton.TabIndex = 16;
            this.tableUpdateButton.Text = "Update table";
            this.tableUpdateButton.UseVisualStyleBackColor = true;
            this.tableUpdateButton.Click += new System.EventHandler(this.tableUpdateButton_Click);
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 520);
            this.Controls.Add(this.tableUpdateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passportNumberText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.dataGridClient);
            this.Name = "ManageClientsForm";
            this.Text = "v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageClientsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passportNumberText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button tableUpdateButton;
    }
}

