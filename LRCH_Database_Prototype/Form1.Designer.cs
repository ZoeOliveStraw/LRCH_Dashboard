namespace LRCH_Database_Prototype
{
    partial class FormLRCHPrototype
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRoomUtil = new System.Windows.Forms.TabPage();
            this.tabPhysicianPatient = new System.Windows.Forms.TabPage();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.labelPatients = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPhysicianNo = new System.Windows.Forms.TextBox();
            this.labelPhysicianNo = new System.Windows.Forms.Label();
            this.labelOccByRooms = new System.Windows.Forms.Label();
            this.labelOccByBeds = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabRoomUtil.SuspendLayout();
            this.tabPhysicianPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRoomUtil);
            this.tabControl1.Controls.Add(this.tabPhysicianPatient);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRoomUtil
            // 
            this.tabRoomUtil.Controls.Add(this.labelOccByBeds);
            this.tabRoomUtil.Controls.Add(this.labelOccByRooms);
            this.tabRoomUtil.Location = new System.Drawing.Point(4, 22);
            this.tabRoomUtil.Name = "tabRoomUtil";
            this.tabRoomUtil.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoomUtil.Size = new System.Drawing.Size(767, 399);
            this.tabRoomUtil.TabIndex = 0;
            this.tabRoomUtil.Text = "Room Utilization";
            this.tabRoomUtil.UseVisualStyleBackColor = true;
            // 
            // tabPhysicianPatient
            // 
            this.tabPhysicianPatient.Controls.Add(this.listBoxPatients);
            this.tabPhysicianPatient.Controls.Add(this.labelPatients);
            this.tabPhysicianPatient.Controls.Add(this.buttonSearch);
            this.tabPhysicianPatient.Controls.Add(this.textBoxPhysicianNo);
            this.tabPhysicianPatient.Controls.Add(this.labelPhysicianNo);
            this.tabPhysicianPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPhysicianPatient.Name = "tabPhysicianPatient";
            this.tabPhysicianPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhysicianPatient.Size = new System.Drawing.Size(767, 399);
            this.tabPhysicianPatient.TabIndex = 1;
            this.tabPhysicianPatient.Text = "Physician-Patient";
            this.tabPhysicianPatient.UseVisualStyleBackColor = true;
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.Location = new System.Drawing.Point(20, 66);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(306, 316);
            this.listBoxPatients.TabIndex = 9;
            // 
            // labelPatients
            // 
            this.labelPatients.AutoSize = true;
            this.labelPatients.Location = new System.Drawing.Point(20, 49);
            this.labelPatients.Name = "labelPatients";
            this.labelPatients.Size = new System.Drawing.Size(45, 13);
            this.labelPatients.TabIndex = 8;
            this.labelPatients.Text = "Patients";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(235, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "View Patients";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxPhysicianNo
            // 
            this.textBoxPhysicianNo.Location = new System.Drawing.Point(118, 11);
            this.textBoxPhysicianNo.Name = "textBoxPhysicianNo";
            this.textBoxPhysicianNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhysicianNo.TabIndex = 6;
            // 
            // labelPhysicianNo
            // 
            this.labelPhysicianNo.AutoSize = true;
            this.labelPhysicianNo.Location = new System.Drawing.Point(17, 14);
            this.labelPhysicianNo.Name = "labelPhysicianNo";
            this.labelPhysicianNo.Size = new System.Drawing.Size(95, 13);
            this.labelPhysicianNo.TabIndex = 5;
            this.labelPhysicianNo.Text = "Physician Number:";
            // 
            // labelOccByRooms
            // 
            this.labelOccByRooms.AutoSize = true;
            this.labelOccByRooms.Location = new System.Drawing.Point(6, 12);
            this.labelOccByRooms.Name = "labelOccByRooms";
            this.labelOccByRooms.Size = new System.Drawing.Size(154, 13);
            this.labelOccByRooms.TabIndex = 0;
            this.labelOccByRooms.Text = "Overall Occupancy by Rooms: ";
            // 
            // labelOccByBeds
            // 
            this.labelOccByBeds.AutoSize = true;
            this.labelOccByBeds.Location = new System.Drawing.Point(6, 37);
            this.labelOccByBeds.Name = "labelOccByBeds";
            this.labelOccByBeds.Size = new System.Drawing.Size(145, 13);
            this.labelOccByBeds.TabIndex = 1;
            this.labelOccByBeds.Text = "Overall Occupancy by Beds: ";
            // 
            // FormLRCHPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLRCHPrototype";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRoomUtil.ResumeLayout(false);
            this.tabRoomUtil.PerformLayout();
            this.tabPhysicianPatient.ResumeLayout(false);
            this.tabPhysicianPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRoomUtil;
        private System.Windows.Forms.TabPage tabPhysicianPatient;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Label labelPatients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPhysicianNo;
        private System.Windows.Forms.Label labelPhysicianNo;
        private System.Windows.Forms.Label labelOccByBeds;
        private System.Windows.Forms.Label labelOccByRooms;
    }
}

