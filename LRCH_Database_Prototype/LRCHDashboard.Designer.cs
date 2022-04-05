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
            this.tabControlNavigation = new System.Windows.Forms.TabControl();
            this.tabRoomUtil = new System.Windows.Forms.TabPage();
            this.textBoxW4E = new System.Windows.Forms.TextBox();
            this.textBoxW3E = new System.Windows.Forms.TextBox();
            this.textBoxICE = new System.Windows.Forms.TextBox();
            this.textBoxSPE = new System.Windows.Forms.TextBox();
            this.textBoxPE = new System.Windows.Forms.TextBox();
            this.labelW4E = new System.Windows.Forms.Label();
            this.labelW3E = new System.Windows.Forms.Label();
            this.labelICE = new System.Windows.Forms.Label();
            this.labelSPE = new System.Windows.Forms.Label();
            this.labelPE = new System.Windows.Forms.Label();
            this.textBoxBedDischarging = new System.Windows.Forms.TextBox();
            this.labelEmptyRooms = new System.Windows.Forms.Label();
            this.labelBedsDischarging = new System.Windows.Forms.Label();
            this.textBoxW4 = new System.Windows.Forms.TextBox();
            this.textBoxW3 = new System.Windows.Forms.TextBox();
            this.textBoxIC = new System.Windows.Forms.TextBox();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelWard4 = new System.Windows.Forms.Label();
            this.labelWard3 = new System.Windows.Forms.Label();
            this.labelIC = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxOccByBed = new System.Windows.Forms.TextBox();
            this.textBoxOccByRoom = new System.Windows.Forms.TextBox();
            this.labelOccByRoomType = new System.Windows.Forms.Label();
            this.labelOccByBeds = new System.Windows.Forms.Label();
            this.labelOccByRooms = new System.Windows.Forms.Label();
            this.tabPhysicianPatient = new System.Windows.Forms.TabPage();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.labelPatients = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPhysicianNo = new System.Windows.Forms.TextBox();
            this.labelPhysicianNo = new System.Windows.Forms.Label();
            this.tabControlNavigation.SuspendLayout();
            this.tabRoomUtil.SuspendLayout();
            this.tabPhysicianPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlNavigation
            // 
            this.tabControlNavigation.Controls.Add(this.tabRoomUtil);
            this.tabControlNavigation.Controls.Add(this.tabPhysicianPatient);
            this.tabControlNavigation.Location = new System.Drawing.Point(13, 13);
            this.tabControlNavigation.Name = "tabControlNavigation";
            this.tabControlNavigation.SelectedIndex = 0;
            this.tabControlNavigation.Size = new System.Drawing.Size(775, 425);
            this.tabControlNavigation.TabIndex = 0;
            this.tabControlNavigation.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlSelected);
            // 
            // tabRoomUtil
            // 
            this.tabRoomUtil.Controls.Add(this.textBoxW4E);
            this.tabRoomUtil.Controls.Add(this.textBoxW3E);
            this.tabRoomUtil.Controls.Add(this.textBoxICE);
            this.tabRoomUtil.Controls.Add(this.textBoxSPE);
            this.tabRoomUtil.Controls.Add(this.textBoxPE);
            this.tabRoomUtil.Controls.Add(this.labelW4E);
            this.tabRoomUtil.Controls.Add(this.labelW3E);
            this.tabRoomUtil.Controls.Add(this.labelICE);
            this.tabRoomUtil.Controls.Add(this.labelSPE);
            this.tabRoomUtil.Controls.Add(this.labelPE);
            this.tabRoomUtil.Controls.Add(this.textBoxBedDischarging);
            this.tabRoomUtil.Controls.Add(this.labelEmptyRooms);
            this.tabRoomUtil.Controls.Add(this.labelBedsDischarging);
            this.tabRoomUtil.Controls.Add(this.textBoxW4);
            this.tabRoomUtil.Controls.Add(this.textBoxW3);
            this.tabRoomUtil.Controls.Add(this.textBoxIC);
            this.tabRoomUtil.Controls.Add(this.textBoxSP);
            this.tabRoomUtil.Controls.Add(this.textBoxP);
            this.tabRoomUtil.Controls.Add(this.labelWard4);
            this.tabRoomUtil.Controls.Add(this.labelWard3);
            this.tabRoomUtil.Controls.Add(this.labelIC);
            this.tabRoomUtil.Controls.Add(this.labelSP);
            this.tabRoomUtil.Controls.Add(this.labelP);
            this.tabRoomUtil.Controls.Add(this.textBoxOccByBed);
            this.tabRoomUtil.Controls.Add(this.textBoxOccByRoom);
            this.tabRoomUtil.Controls.Add(this.labelOccByRoomType);
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
            // textBoxW4E
            // 
            this.textBoxW4E.Location = new System.Drawing.Point(682, 188);
            this.textBoxW4E.Name = "textBoxW4E";
            this.textBoxW4E.ReadOnly = true;
            this.textBoxW4E.Size = new System.Drawing.Size(45, 20);
            this.textBoxW4E.TabIndex = 27;
            this.textBoxW4E.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxW3E
            // 
            this.textBoxW3E.Location = new System.Drawing.Point(580, 188);
            this.textBoxW3E.Name = "textBoxW3E";
            this.textBoxW3E.ReadOnly = true;
            this.textBoxW3E.Size = new System.Drawing.Size(45, 20);
            this.textBoxW3E.TabIndex = 26;
            this.textBoxW3E.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxICE
            // 
            this.textBoxICE.Location = new System.Drawing.Point(478, 188);
            this.textBoxICE.Name = "textBoxICE";
            this.textBoxICE.ReadOnly = true;
            this.textBoxICE.Size = new System.Drawing.Size(45, 20);
            this.textBoxICE.TabIndex = 25;
            this.textBoxICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSPE
            // 
            this.textBoxSPE.Location = new System.Drawing.Point(346, 188);
            this.textBoxSPE.Name = "textBoxSPE";
            this.textBoxSPE.ReadOnly = true;
            this.textBoxSPE.Size = new System.Drawing.Size(45, 20);
            this.textBoxSPE.TabIndex = 24;
            this.textBoxSPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPE
            // 
            this.textBoxPE.Location = new System.Drawing.Point(227, 188);
            this.textBoxPE.Name = "textBoxPE";
            this.textBoxPE.ReadOnly = true;
            this.textBoxPE.Size = new System.Drawing.Size(45, 20);
            this.textBoxPE.TabIndex = 23;
            this.textBoxPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelW4E
            // 
            this.labelW4E.AutoSize = true;
            this.labelW4E.Location = new System.Drawing.Point(631, 191);
            this.labelW4E.Name = "labelW4E";
            this.labelW4E.Size = new System.Drawing.Size(45, 13);
            this.labelW4E.TabIndex = 22;
            this.labelW4E.Text = "Ward, 4";
            // 
            // labelW3E
            // 
            this.labelW3E.AutoSize = true;
            this.labelW3E.Location = new System.Drawing.Point(529, 191);
            this.labelW3E.Name = "labelW3E";
            this.labelW3E.Size = new System.Drawing.Size(45, 13);
            this.labelW3E.TabIndex = 21;
            this.labelW3E.Text = "Ward, 3";
            // 
            // labelICE
            // 
            this.labelICE.AutoSize = true;
            this.labelICE.Location = new System.Drawing.Point(397, 191);
            this.labelICE.Name = "labelICE";
            this.labelICE.Size = new System.Drawing.Size(75, 13);
            this.labelICE.TabIndex = 20;
            this.labelICE.Text = "Intensive Care";
            // 
            // labelSPE
            // 
            this.labelSPE.AutoSize = true;
            this.labelSPE.Location = new System.Drawing.Point(278, 191);
            this.labelSPE.Name = "labelSPE";
            this.labelSPE.Size = new System.Drawing.Size(62, 13);
            this.labelSPE.TabIndex = 19;
            this.labelSPE.Text = "Semiprivate";
            // 
            // labelPE
            // 
            this.labelPE.AutoSize = true;
            this.labelPE.Location = new System.Drawing.Point(181, 191);
            this.labelPE.Name = "labelPE";
            this.labelPE.Size = new System.Drawing.Size(40, 13);
            this.labelPE.TabIndex = 18;
            this.labelPE.Text = "Private";
            // 
            // textBoxBedDischarging
            // 
            this.textBoxBedDischarging.Location = new System.Drawing.Point(166, 80);
            this.textBoxBedDischarging.Name = "textBoxBedDischarging";
            this.textBoxBedDischarging.ReadOnly = true;
            this.textBoxBedDischarging.Size = new System.Drawing.Size(100, 20);
            this.textBoxBedDischarging.TabIndex = 17;
            this.textBoxBedDischarging.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelEmptyRooms
            // 
            this.labelEmptyRooms.AutoSize = true;
            this.labelEmptyRooms.Location = new System.Drawing.Point(6, 191);
            this.labelEmptyRooms.Name = "labelEmptyRooms";
            this.labelEmptyRooms.Size = new System.Drawing.Size(169, 13);
            this.labelEmptyRooms.TabIndex = 16;
            this.labelEmptyRooms.Text = "# of Empty Rooms by Room Type:";
            // 
            // labelBedsDischarging
            // 
            this.labelBedsDischarging.AutoSize = true;
            this.labelBedsDischarging.Location = new System.Drawing.Point(6, 83);
            this.labelBedsDischarging.Name = "labelBedsDischarging";
            this.labelBedsDischarging.Size = new System.Drawing.Size(148, 13);
            this.labelBedsDischarging.TabIndex = 15;
            this.labelBedsDischarging.Text = "# of Beds Discharging Today:";
            // 
            // textBoxW4
            // 
            this.textBoxW4.Location = new System.Drawing.Point(682, 158);
            this.textBoxW4.Name = "textBoxW4";
            this.textBoxW4.ReadOnly = true;
            this.textBoxW4.Size = new System.Drawing.Size(45, 20);
            this.textBoxW4.TabIndex = 14;
            this.textBoxW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxW3
            // 
            this.textBoxW3.Location = new System.Drawing.Point(580, 158);
            this.textBoxW3.Name = "textBoxW3";
            this.textBoxW3.ReadOnly = true;
            this.textBoxW3.Size = new System.Drawing.Size(45, 20);
            this.textBoxW3.TabIndex = 13;
            this.textBoxW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxIC
            // 
            this.textBoxIC.Location = new System.Drawing.Point(478, 158);
            this.textBoxIC.Name = "textBoxIC";
            this.textBoxIC.ReadOnly = true;
            this.textBoxIC.Size = new System.Drawing.Size(45, 20);
            this.textBoxIC.TabIndex = 12;
            this.textBoxIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSP
            // 
            this.textBoxSP.Location = new System.Drawing.Point(346, 158);
            this.textBoxSP.Name = "textBoxSP";
            this.textBoxSP.ReadOnly = true;
            this.textBoxSP.Size = new System.Drawing.Size(45, 20);
            this.textBoxSP.TabIndex = 11;
            this.textBoxSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(227, 158);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ReadOnly = true;
            this.textBoxP.Size = new System.Drawing.Size(45, 20);
            this.textBoxP.TabIndex = 10;
            this.textBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWard4
            // 
            this.labelWard4.AutoSize = true;
            this.labelWard4.Location = new System.Drawing.Point(631, 161);
            this.labelWard4.Name = "labelWard4";
            this.labelWard4.Size = new System.Drawing.Size(45, 13);
            this.labelWard4.TabIndex = 9;
            this.labelWard4.Text = "Ward, 4";
            // 
            // labelWard3
            // 
            this.labelWard3.AutoSize = true;
            this.labelWard3.Location = new System.Drawing.Point(529, 161);
            this.labelWard3.Name = "labelWard3";
            this.labelWard3.Size = new System.Drawing.Size(45, 13);
            this.labelWard3.TabIndex = 8;
            this.labelWard3.Text = "Ward, 3";
            // 
            // labelIC
            // 
            this.labelIC.AutoSize = true;
            this.labelIC.Location = new System.Drawing.Point(397, 161);
            this.labelIC.Name = "labelIC";
            this.labelIC.Size = new System.Drawing.Size(75, 13);
            this.labelIC.TabIndex = 7;
            this.labelIC.Text = "Intensive Care";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(278, 161);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(62, 13);
            this.labelSP.TabIndex = 6;
            this.labelSP.Text = "Semiprivate";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(181, 161);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(40, 13);
            this.labelP.TabIndex = 5;
            this.labelP.Text = "Private";
            // 
            // textBoxOccByBed
            // 
            this.textBoxOccByBed.Location = new System.Drawing.Point(166, 46);
            this.textBoxOccByBed.Name = "textBoxOccByBed";
            this.textBoxOccByBed.ReadOnly = true;
            this.textBoxOccByBed.Size = new System.Drawing.Size(100, 20);
            this.textBoxOccByBed.TabIndex = 4;
            this.textBoxOccByBed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOccByRoom
            // 
            this.textBoxOccByRoom.Location = new System.Drawing.Point(166, 9);
            this.textBoxOccByRoom.Name = "textBoxOccByRoom";
            this.textBoxOccByRoom.ReadOnly = true;
            this.textBoxOccByRoom.Size = new System.Drawing.Size(100, 20);
            this.textBoxOccByRoom.TabIndex = 3;
            this.textBoxOccByRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOccByRoomType
            // 
            this.labelOccByRoomType.AutoSize = true;
            this.labelOccByRoomType.Location = new System.Drawing.Point(35, 161);
            this.labelOccByRoomType.Name = "labelOccByRoomType";
            this.labelOccByRoomType.Size = new System.Drawing.Size(140, 13);
            this.labelOccByRoomType.TabIndex = 2;
            this.labelOccByRoomType.Text = "Occupancy by Room Type: ";
            // 
            // labelOccByBeds
            // 
            this.labelOccByBeds.AutoSize = true;
            this.labelOccByBeds.Location = new System.Drawing.Point(6, 49);
            this.labelOccByBeds.Name = "labelOccByBeds";
            this.labelOccByBeds.Size = new System.Drawing.Size(145, 13);
            this.labelOccByBeds.TabIndex = 1;
            this.labelOccByBeds.Text = "Overall Occupancy by Beds: ";
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
            this.labelPatients.Location = new System.Drawing.Point(17, 50);
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
            this.buttonSearch.Click += new System.EventHandler(this.buttonClickViewPatients);
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
            // FormLRCHPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.tabControlNavigation);
            this.Name = "FormLRCHPrototype";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControlNavigation.ResumeLayout(false);
            this.tabRoomUtil.ResumeLayout(false);
            this.tabRoomUtil.PerformLayout();
            this.tabPhysicianPatient.ResumeLayout(false);
            this.tabPhysicianPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNavigation;
        private System.Windows.Forms.TabPage tabRoomUtil;
        private System.Windows.Forms.TabPage tabPhysicianPatient;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Label labelPatients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxPhysicianNo;
        private System.Windows.Forms.Label labelPhysicianNo;
        private System.Windows.Forms.Label labelOccByBeds;
        private System.Windows.Forms.Label labelOccByRooms;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxOccByBed;
        private System.Windows.Forms.TextBox textBoxOccByRoom;
        private System.Windows.Forms.Label labelOccByRoomType;
        private System.Windows.Forms.Label labelWard4;
        private System.Windows.Forms.Label labelWard3;
        private System.Windows.Forms.Label labelIC;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.TextBox textBoxW4;
        private System.Windows.Forms.TextBox textBoxW3;
        private System.Windows.Forms.TextBox textBoxIC;
        private System.Windows.Forms.TextBox textBoxSP;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelBedsDischarging;
        private System.Windows.Forms.Label labelEmptyRooms;
        private System.Windows.Forms.TextBox textBoxBedDischarging;
        private System.Windows.Forms.TextBox textBoxW4E;
        private System.Windows.Forms.TextBox textBoxW3E;
        private System.Windows.Forms.TextBox textBoxICE;
        private System.Windows.Forms.TextBox textBoxSPE;
        private System.Windows.Forms.TextBox textBoxPE;
        private System.Windows.Forms.Label labelW4E;
        private System.Windows.Forms.Label labelW3E;
        private System.Windows.Forms.Label labelICE;
        private System.Windows.Forms.Label labelSPE;
        private System.Windows.Forms.Label labelPE;
    }
}

