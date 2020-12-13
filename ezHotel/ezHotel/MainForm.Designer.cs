namespace ezHotel
{
    partial class MainForm
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
            this.manageClientsButton = new System.Windows.Forms.Button();
            this.manageReservationsButton = new System.Windows.Forms.Button();
            this.manageRoomsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageClientsButton
            // 
            this.manageClientsButton.Location = new System.Drawing.Point(12, 55);
            this.manageClientsButton.Name = "manageClientsButton";
            this.manageClientsButton.Size = new System.Drawing.Size(260, 70);
            this.manageClientsButton.TabIndex = 0;
            this.manageClientsButton.Text = "Manage clients";
            this.manageClientsButton.UseVisualStyleBackColor = true;
            this.manageClientsButton.Click += new System.EventHandler(this.manageClientsButton_Click);
            // 
            // manageReservationsButton
            // 
            this.manageReservationsButton.Location = new System.Drawing.Point(12, 131);
            this.manageReservationsButton.Name = "manageReservationsButton";
            this.manageReservationsButton.Size = new System.Drawing.Size(260, 70);
            this.manageReservationsButton.TabIndex = 1;
            this.manageReservationsButton.Text = "Manager reservations";
            this.manageReservationsButton.UseVisualStyleBackColor = true;
            // 
            // manageRoomsButton
            // 
            this.manageRoomsButton.Location = new System.Drawing.Point(12, 207);
            this.manageRoomsButton.Name = "manageRoomsButton";
            this.manageRoomsButton.Size = new System.Drawing.Size(260, 70);
            this.manageRoomsButton.TabIndex = 2;
            this.manageRoomsButton.Text = "Manage rooms";
            this.manageRoomsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.manageRoomsButton);
            this.Controls.Add(this.manageReservationsButton);
            this.Controls.Add(this.manageClientsButton);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageClientsButton;
        private System.Windows.Forms.Button manageReservationsButton;
        private System.Windows.Forms.Button manageRoomsButton;
    }
}