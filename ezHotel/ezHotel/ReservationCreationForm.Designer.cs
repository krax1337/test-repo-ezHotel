namespace ezHotel
{
    partial class ReservationCreationForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.nowStartButton = new System.Windows.Forms.Button();
            this.oneDayEndDateButton = new System.Windows.Forms.Button();
            this.threeDayEndDateButton = new System.Windows.Forms.Button();
            this.sevenDayEndDateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(60, 351);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 25;
            this.submitButton.Text = "Create";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "End date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Start date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(60, 219);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(390, 20);
            this.startDatePicker.TabIndex = 26;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(60, 292);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(390, 20);
            this.endDatePicker.TabIndex = 27;
            // 
            // clientBox
            // 
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(60, 130);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(390, 21);
            this.clientBox.TabIndex = 28;
            // 
            // roomBox
            // 
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Location = new System.Drawing.Point(60, 173);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(390, 21);
            this.roomBox.TabIndex = 29;
            // 
            // nowStartButton
            // 
            this.nowStartButton.Location = new System.Drawing.Point(60, 245);
            this.nowStartButton.Name = "nowStartButton";
            this.nowStartButton.Size = new System.Drawing.Size(75, 23);
            this.nowStartButton.TabIndex = 30;
            this.nowStartButton.Text = "Now";
            this.nowStartButton.UseVisualStyleBackColor = true;
            this.nowStartButton.Click += new System.EventHandler(this.nowStartButton_Click);
            // 
            // oneDayEndDateButton
            // 
            this.oneDayEndDateButton.Location = new System.Drawing.Point(60, 318);
            this.oneDayEndDateButton.Name = "oneDayEndDateButton";
            this.oneDayEndDateButton.Size = new System.Drawing.Size(75, 23);
            this.oneDayEndDateButton.TabIndex = 31;
            this.oneDayEndDateButton.Text = "1d";
            this.oneDayEndDateButton.UseVisualStyleBackColor = true;
            this.oneDayEndDateButton.Click += new System.EventHandler(this.oneDayEndDateButton_Click);
            // 
            // threeDayEndDateButton
            // 
            this.threeDayEndDateButton.Location = new System.Drawing.Point(141, 318);
            this.threeDayEndDateButton.Name = "threeDayEndDateButton";
            this.threeDayEndDateButton.Size = new System.Drawing.Size(75, 23);
            this.threeDayEndDateButton.TabIndex = 32;
            this.threeDayEndDateButton.Text = "3d";
            this.threeDayEndDateButton.UseVisualStyleBackColor = true;
            this.threeDayEndDateButton.Click += new System.EventHandler(this.threeDayEndDateButton_Click);
            // 
            // sevenDayEndDateButton
            // 
            this.sevenDayEndDateButton.Location = new System.Drawing.Point(222, 318);
            this.sevenDayEndDateButton.Name = "sevenDayEndDateButton";
            this.sevenDayEndDateButton.Size = new System.Drawing.Size(75, 23);
            this.sevenDayEndDateButton.TabIndex = 33;
            this.sevenDayEndDateButton.Text = "7d";
            this.sevenDayEndDateButton.UseVisualStyleBackColor = true;
            this.sevenDayEndDateButton.Click += new System.EventHandler(this.sevenDayEndDateButton_Click);
            // 
            // ReservationCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 412);
            this.Controls.Add(this.sevenDayEndDateButton);
            this.Controls.Add(this.threeDayEndDateButton);
            this.Controls.Add(this.oneDayEndDateButton);
            this.Controls.Add(this.nowStartButton);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(523, 451);
            this.MinimumSize = new System.Drawing.Size(523, 451);
            this.Name = "ReservationCreationForm";
            this.Text = "Create a Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.Button nowStartButton;
        private System.Windows.Forms.Button oneDayEndDateButton;
        private System.Windows.Forms.Button threeDayEndDateButton;
        private System.Windows.Forms.Button sevenDayEndDateButton;
    }
}