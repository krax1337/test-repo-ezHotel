namespace ezHotel
{
    partial class ManageReservationsForm
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
            this.dataGridReservation = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationIdText = new System.Windows.Forms.TextBox();
            this.clientFullNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.refreshTableButton = new System.Windows.Forms.Button();
            this.currentMonthLabel1 = new System.Windows.Forms.Label();
            this.currentMonthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReservation
            // 
            this.dataGridReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservation.Location = new System.Drawing.Point(12, 134);
            this.dataGridReservation.Name = "dataGridReservation";
            this.dataGridReservation.ReadOnly = true;
            this.dataGridReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservation.Size = new System.Drawing.Size(1230, 321);
            this.dataGridReservation.TabIndex = 2;
            this.dataGridReservation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservation_CellDoubleClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(200, 66);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reservation ID";
            // 
            // reservationIdText
            // 
            this.reservationIdText.Location = new System.Drawing.Point(12, 25);
            this.reservationIdText.Name = "reservationIdText";
            this.reservationIdText.ReadOnly = true;
            this.reservationIdText.Size = new System.Drawing.Size(169, 20);
            this.reservationIdText.TabIndex = 5;
            // 
            // clientFullNameBox
            // 
            this.clientFullNameBox.Location = new System.Drawing.Point(12, 68);
            this.clientFullNameBox.Name = "clientFullNameBox";
            this.clientFullNameBox.ReadOnly = true;
            this.clientFullNameBox.Size = new System.Drawing.Size(169, 20);
            this.clientFullNameBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client fullname";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(200, 22);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(281, 66);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(160, 23);
            this.finishButton.TabIndex = 9;
            this.finishButton.Text = "Finish reservation";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // refreshTableButton
            // 
            this.refreshTableButton.Location = new System.Drawing.Point(281, 23);
            this.refreshTableButton.Name = "refreshTableButton";
            this.refreshTableButton.Size = new System.Drawing.Size(75, 23);
            this.refreshTableButton.TabIndex = 10;
            this.refreshTableButton.Text = "Refresh";
            this.refreshTableButton.UseVisualStyleBackColor = true;
            this.refreshTableButton.Click += new System.EventHandler(this.refreshTableButton_Click);
            // 
            // currentMonthLabel1
            // 
            this.currentMonthLabel1.AutoSize = true;
            this.currentMonthLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentMonthLabel1.Location = new System.Drawing.Point(9, 478);
            this.currentMonthLabel1.Name = "currentMonthLabel1";
            this.currentMonthLabel1.Size = new System.Drawing.Size(296, 31);
            this.currentMonthLabel1.TabIndex = 11;
            this.currentMonthLabel1.Text = "Current month income: ";
            // 
            // currentMonthLabel
            // 
            this.currentMonthLabel.AutoSize = true;
            this.currentMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentMonthLabel.Location = new System.Drawing.Point(311, 478);
            this.currentMonthLabel.Name = "currentMonthLabel";
            this.currentMonthLabel.Size = new System.Drawing.Size(0, 31);
            this.currentMonthLabel.TabIndex = 12;
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 518);
            this.Controls.Add(this.currentMonthLabel);
            this.Controls.Add(this.currentMonthLabel1);
            this.Controls.Add(this.refreshTableButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clientFullNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservationIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridReservation);
            this.Name = "ManageReservationsForm";
            this.Text = "ManageReservationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReservation;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reservationIdText;
        private System.Windows.Forms.TextBox clientFullNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button refreshTableButton;
        private System.Windows.Forms.Label currentMonthLabel1;
        private System.Windows.Forms.Label currentMonthLabel;
    }
}