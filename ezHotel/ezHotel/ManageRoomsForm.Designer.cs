namespace ezHotel
{
    partial class ManageRoomsForm
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
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textRoomId = new System.Windows.Forms.TextBox();
            this.textFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRoomType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxOccupied = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoom.Location = new System.Drawing.Point(12, 134);
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.ReadOnly = true;
            this.dataGridRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRoom.Size = new System.Drawing.Size(782, 321);
            this.dataGridRoom.TabIndex = 1;
            this.dataGridRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoom_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room ID";
            // 
            // textRoomId
            // 
            this.textRoomId.Location = new System.Drawing.Point(12, 29);
            this.textRoomId.Name = "textRoomId";
            this.textRoomId.ReadOnly = true;
            this.textRoomId.Size = new System.Drawing.Size(103, 20);
            this.textRoomId.TabIndex = 3;
            // 
            // textFloor
            // 
            this.textFloor.Location = new System.Drawing.Point(12, 74);
            this.textFloor.Name = "textFloor";
            this.textFloor.ReadOnly = true;
            this.textFloor.Size = new System.Drawing.Size(103, 20);
            this.textFloor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Floor";
            // 
            // textRoomType
            // 
            this.textRoomType.Location = new System.Drawing.Point(121, 29);
            this.textRoomType.Name = "textRoomType";
            this.textRoomType.ReadOnly = true;
            this.textRoomType.Size = new System.Drawing.Size(140, 20);
            this.textRoomType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room type";
            // 
            // checkBoxOccupied
            // 
            this.checkBoxOccupied.AutoSize = true;
            this.checkBoxOccupied.Location = new System.Drawing.Point(122, 76);
            this.checkBoxOccupied.Name = "checkBoxOccupied";
            this.checkBoxOccupied.Size = new System.Drawing.Size(72, 17);
            this.checkBoxOccupied.TabIndex = 8;
            this.checkBoxOccupied.Text = "Occupied";
            this.checkBoxOccupied.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(267, 29);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 20);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(267, 74);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 20);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(348, 29);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 20);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(348, 74);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 20);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 467);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.checkBoxOccupied);
            this.Controls.Add(this.textRoomType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRoomId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRoom);
            this.Name = "ManageRoomsForm";
            this.Text = "ManageRoomsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRoomId;
        private System.Windows.Forms.TextBox textFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxOccupied;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button refreshButton;
    }
}