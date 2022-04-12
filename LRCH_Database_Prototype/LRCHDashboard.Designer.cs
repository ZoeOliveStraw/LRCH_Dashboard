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
            this.labelW4E = new System.Windows.Forms.Label();
            this.labelW3E = new System.Windows.Forms.Label();
            this.labelICE = new System.Windows.Forms.Label();
            this.labelSPE = new System.Windows.Forms.Label();
            this.labelPE = new System.Windows.Forms.Label();
            this.labelEmptyRooms = new System.Windows.Forms.Label();
            this.labelBedsDischarging = new System.Windows.Forms.Label();
            this.labelWard4 = new System.Windows.Forms.Label();
            this.labelWard3 = new System.Windows.Forms.Label();
            this.labelIC = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelOccByRoomType = new System.Windows.Forms.Label();
            this.labelOccByBeds = new System.Windows.Forms.Label();
            this.labelOccByRooms = new System.Windows.Forms.Label();
            this.tabPhysicianPatient = new System.Windows.Forms.TabPage();
            this.labelBedInput = new System.Windows.Forms.Label();
            this.labelFinanceInput = new System.Windows.Forms.Label();
            this.labelPhoneInput = new System.Windows.Forms.Label();
            this.labelSandPInput = new System.Windows.Forms.Label();
            this.labelHCNInput = new System.Windows.Forms.Label();
            this.labelDDInput = new System.Windows.Forms.Label();
            this.labelDAInput = new System.Windows.Forms.Label();
            this.labelLocInput = new System.Windows.Forms.Label();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelPatientBed = new System.Windows.Forms.Label();
            this.labelFinance = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSandP = new System.Windows.Forms.Label();
            this.labelHCN = new System.Windows.Forms.Label();
            this.labelDD = new System.Windows.Forms.Label();
            this.labelDA = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatientInfo = new System.Windows.Forms.Label();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.labelPatients = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPhysicianNo = new System.Windows.Forms.TextBox();
            this.labelPhysicianNo = new System.Windows.Forms.Label();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.dataGridViewBeds = new System.Windows.Forms.DataGridView();
            this.labelOccByRoom = new System.Windows.Forms.Label();
            this.labelOccByBed = new System.Windows.Forms.Label();
            this.labelBedDischarging = new System.Windows.Forms.Label();
            this.labelPInput = new System.Windows.Forms.Label();
            this.labelSPInput = new System.Windows.Forms.Label();
            this.labelICInput = new System.Windows.Forms.Label();
            this.labelW3Input = new System.Windows.Forms.Label();
            this.labelW4Input = new System.Windows.Forms.Label();
            this.labelPEInput = new System.Windows.Forms.Label();
            this.labelSPEInput = new System.Windows.Forms.Label();
            this.labelICEInput = new System.Windows.Forms.Label();
            this.labelW3EInput = new System.Windows.Forms.Label();
            this.labelW4EInput = new System.Windows.Forms.Label();
            this.tabControlNavigation.SuspendLayout();
            this.tabRoomUtil.SuspendLayout();
            this.tabPhysicianPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlNavigation
            // 
            this.tabControlNavigation.Controls.Add(this.tabRoomUtil);
            this.tabControlNavigation.Controls.Add(this.tabPhysicianPatient);
            this.tabControlNavigation.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlNavigation.Location = new System.Drawing.Point(13, 13);
            this.tabControlNavigation.Name = "tabControlNavigation";
            this.tabControlNavigation.SelectedIndex = 0;
            this.tabControlNavigation.Size = new System.Drawing.Size(775, 425);
            this.tabControlNavigation.TabIndex = 0;
            this.tabControlNavigation.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlSelected);
            // 
            // tabRoomUtil
            // 
            this.tabRoomUtil.Controls.Add(this.labelW4EInput);
            this.tabRoomUtil.Controls.Add(this.labelW3EInput);
            this.tabRoomUtil.Controls.Add(this.labelICEInput);
            this.tabRoomUtil.Controls.Add(this.labelSPEInput);
            this.tabRoomUtil.Controls.Add(this.labelPEInput);
            this.tabRoomUtil.Controls.Add(this.labelW4Input);
            this.tabRoomUtil.Controls.Add(this.labelW3Input);
            this.tabRoomUtil.Controls.Add(this.labelICInput);
            this.tabRoomUtil.Controls.Add(this.labelSPInput);
            this.tabRoomUtil.Controls.Add(this.labelPInput);
            this.tabRoomUtil.Controls.Add(this.labelBedDischarging);
            this.tabRoomUtil.Controls.Add(this.labelOccByBed);
            this.tabRoomUtil.Controls.Add(this.labelOccByRoom);
            this.tabRoomUtil.Controls.Add(this.dataGridViewBeds);
            this.tabRoomUtil.Controls.Add(this.labelGeneral);
            this.tabRoomUtil.Controls.Add(this.labelW4E);
            this.tabRoomUtil.Controls.Add(this.labelW3E);
            this.tabRoomUtil.Controls.Add(this.labelICE);
            this.tabRoomUtil.Controls.Add(this.labelSPE);
            this.tabRoomUtil.Controls.Add(this.labelPE);
            this.tabRoomUtil.Controls.Add(this.labelEmptyRooms);
            this.tabRoomUtil.Controls.Add(this.labelBedsDischarging);
            this.tabRoomUtil.Controls.Add(this.labelWard4);
            this.tabRoomUtil.Controls.Add(this.labelWard3);
            this.tabRoomUtil.Controls.Add(this.labelIC);
            this.tabRoomUtil.Controls.Add(this.labelSP);
            this.tabRoomUtil.Controls.Add(this.labelP);
            this.tabRoomUtil.Controls.Add(this.labelOccByRoomType);
            this.tabRoomUtil.Controls.Add(this.labelOccByBeds);
            this.tabRoomUtil.Controls.Add(this.labelOccByRooms);
            this.tabRoomUtil.Location = new System.Drawing.Point(4, 23);
            this.tabRoomUtil.Name = "tabRoomUtil";
            this.tabRoomUtil.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoomUtil.Size = new System.Drawing.Size(767, 398);
            this.tabRoomUtil.TabIndex = 0;
            this.tabRoomUtil.Text = "Room Utilization";
            this.tabRoomUtil.UseVisualStyleBackColor = true;
            // 
            // labelW4E
            // 
            this.labelW4E.AutoSize = true;
            this.labelW4E.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW4E.Location = new System.Drawing.Point(652, 367);
            this.labelW4E.Name = "labelW4E";
            this.labelW4E.Size = new System.Drawing.Size(51, 16);
            this.labelW4E.TabIndex = 22;
            this.labelW4E.Text = "Ward, 4";
            // 
            // labelW3E
            // 
            this.labelW3E.AutoSize = true;
            this.labelW3E.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW3E.Location = new System.Drawing.Point(550, 367);
            this.labelW3E.Name = "labelW3E";
            this.labelW3E.Size = new System.Drawing.Size(51, 16);
            this.labelW3E.TabIndex = 21;
            this.labelW3E.Text = "Ward, 3";
            // 
            // labelICE
            // 
            this.labelICE.AutoSize = true;
            this.labelICE.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICE.Location = new System.Drawing.Point(418, 367);
            this.labelICE.Name = "labelICE";
            this.labelICE.Size = new System.Drawing.Size(88, 16);
            this.labelICE.TabIndex = 20;
            this.labelICE.Text = "Intensive Care";
            // 
            // labelSPE
            // 
            this.labelSPE.AutoSize = true;
            this.labelSPE.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSPE.Location = new System.Drawing.Point(299, 367);
            this.labelSPE.Name = "labelSPE";
            this.labelSPE.Size = new System.Drawing.Size(76, 16);
            this.labelSPE.TabIndex = 19;
            this.labelSPE.Text = "Semiprivate";
            // 
            // labelPE
            // 
            this.labelPE.AutoSize = true;
            this.labelPE.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPE.Location = new System.Drawing.Point(202, 367);
            this.labelPE.Name = "labelPE";
            this.labelPE.Size = new System.Drawing.Size(48, 16);
            this.labelPE.TabIndex = 18;
            this.labelPE.Text = "Private";
            // 
            // labelEmptyRooms
            // 
            this.labelEmptyRooms.AutoSize = true;
            this.labelEmptyRooms.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmptyRooms.Location = new System.Drawing.Point(12, 367);
            this.labelEmptyRooms.Name = "labelEmptyRooms";
            this.labelEmptyRooms.Size = new System.Drawing.Size(194, 16);
            this.labelEmptyRooms.TabIndex = 16;
            this.labelEmptyRooms.Text = "# of Empty Rooms by Room Type:";
            // 
            // labelBedsDischarging
            // 
            this.labelBedsDischarging.AutoSize = true;
            this.labelBedsDischarging.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedsDischarging.Location = new System.Drawing.Point(531, 303);
            this.labelBedsDischarging.Name = "labelBedsDischarging";
            this.labelBedsDischarging.Size = new System.Drawing.Size(167, 16);
            this.labelBedsDischarging.TabIndex = 15;
            this.labelBedsDischarging.Text = "# of Beds Discharging Today:";
            // 
            // labelWard4
            // 
            this.labelWard4.AutoSize = true;
            this.labelWard4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWard4.Location = new System.Drawing.Point(652, 337);
            this.labelWard4.Name = "labelWard4";
            this.labelWard4.Size = new System.Drawing.Size(54, 16);
            this.labelWard4.TabIndex = 9;
            this.labelWard4.Text = "Ward, 4:";
            // 
            // labelWard3
            // 
            this.labelWard3.AutoSize = true;
            this.labelWard3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWard3.Location = new System.Drawing.Point(550, 337);
            this.labelWard3.Name = "labelWard3";
            this.labelWard3.Size = new System.Drawing.Size(54, 16);
            this.labelWard3.TabIndex = 8;
            this.labelWard3.Text = "Ward, 3:";
            // 
            // labelIC
            // 
            this.labelIC.AutoSize = true;
            this.labelIC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIC.Location = new System.Drawing.Point(418, 337);
            this.labelIC.Name = "labelIC";
            this.labelIC.Size = new System.Drawing.Size(91, 16);
            this.labelIC.TabIndex = 7;
            this.labelIC.Text = "Intensive Care:";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSP.Location = new System.Drawing.Point(299, 337);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(79, 16);
            this.labelSP.TabIndex = 6;
            this.labelSP.Text = "Semiprivate:";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.Location = new System.Drawing.Point(202, 337);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(51, 16);
            this.labelP.TabIndex = 5;
            this.labelP.Text = "Private:";
            // 
            // labelOccByRoomType
            // 
            this.labelOccByRoomType.AutoSize = true;
            this.labelOccByRoomType.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccByRoomType.Location = new System.Drawing.Point(49, 337);
            this.labelOccByRoomType.Name = "labelOccByRoomType";
            this.labelOccByRoomType.Size = new System.Drawing.Size(156, 16);
            this.labelOccByRoomType.TabIndex = 2;
            this.labelOccByRoomType.Text = "Occupancy by Room Type: ";
            // 
            // labelOccByBeds
            // 
            this.labelOccByBeds.AutoSize = true;
            this.labelOccByBeds.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccByBeds.Location = new System.Drawing.Point(284, 303);
            this.labelOccByBeds.Name = "labelOccByBeds";
            this.labelOccByBeds.Size = new System.Drawing.Size(163, 16);
            this.labelOccByBeds.TabIndex = 1;
            this.labelOccByBeds.Text = "Overall Occupancy by Beds: ";
            // 
            // labelOccByRooms
            // 
            this.labelOccByRooms.AutoSize = true;
            this.labelOccByRooms.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccByRooms.Location = new System.Drawing.Point(33, 303);
            this.labelOccByRooms.Name = "labelOccByRooms";
            this.labelOccByRooms.Size = new System.Drawing.Size(174, 16);
            this.labelOccByRooms.TabIndex = 0;
            this.labelOccByRooms.Text = "Overall Occupancy by Rooms: ";
            // 
            // tabPhysicianPatient
            // 
            this.tabPhysicianPatient.Controls.Add(this.labelBedInput);
            this.tabPhysicianPatient.Controls.Add(this.labelFinanceInput);
            this.tabPhysicianPatient.Controls.Add(this.labelPhoneInput);
            this.tabPhysicianPatient.Controls.Add(this.labelSandPInput);
            this.tabPhysicianPatient.Controls.Add(this.labelHCNInput);
            this.tabPhysicianPatient.Controls.Add(this.labelDDInput);
            this.tabPhysicianPatient.Controls.Add(this.labelDAInput);
            this.tabPhysicianPatient.Controls.Add(this.labelLocInput);
            this.tabPhysicianPatient.Controls.Add(this.labelNameInput);
            this.tabPhysicianPatient.Controls.Add(this.buttonNotes);
            this.tabPhysicianPatient.Controls.Add(this.textBoxNotes);
            this.tabPhysicianPatient.Controls.Add(this.labelNotes);
            this.tabPhysicianPatient.Controls.Add(this.labelPatientBed);
            this.tabPhysicianPatient.Controls.Add(this.labelFinance);
            this.tabPhysicianPatient.Controls.Add(this.labelPhone);
            this.tabPhysicianPatient.Controls.Add(this.labelSandP);
            this.tabPhysicianPatient.Controls.Add(this.labelHCN);
            this.tabPhysicianPatient.Controls.Add(this.labelDD);
            this.tabPhysicianPatient.Controls.Add(this.labelDA);
            this.tabPhysicianPatient.Controls.Add(this.labelLoc);
            this.tabPhysicianPatient.Controls.Add(this.labelName);
            this.tabPhysicianPatient.Controls.Add(this.labelPatientInfo);
            this.tabPhysicianPatient.Controls.Add(this.listBoxPatients);
            this.tabPhysicianPatient.Controls.Add(this.labelPatients);
            this.tabPhysicianPatient.Controls.Add(this.buttonSearch);
            this.tabPhysicianPatient.Controls.Add(this.textBoxPhysicianNo);
            this.tabPhysicianPatient.Controls.Add(this.labelPhysicianNo);
            this.tabPhysicianPatient.Location = new System.Drawing.Point(4, 23);
            this.tabPhysicianPatient.Name = "tabPhysicianPatient";
            this.tabPhysicianPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhysicianPatient.Size = new System.Drawing.Size(767, 398);
            this.tabPhysicianPatient.TabIndex = 1;
            this.tabPhysicianPatient.Text = "Physician-Patient";
            this.tabPhysicianPatient.UseVisualStyleBackColor = true;
            // 
            // labelBedInput
            // 
            this.labelBedInput.AutoSize = true;
            this.labelBedInput.Location = new System.Drawing.Point(487, 251);
            this.labelBedInput.Name = "labelBedInput";
            this.labelBedInput.Size = new System.Drawing.Size(53, 14);
            this.labelBedInput.TabIndex = 31;
            this.labelBedInput.Text = "template";
            this.labelBedInput.Visible = false;
            // 
            // labelFinanceInput
            // 
            this.labelFinanceInput.AutoSize = true;
            this.labelFinanceInput.Location = new System.Drawing.Point(487, 228);
            this.labelFinanceInput.Name = "labelFinanceInput";
            this.labelFinanceInput.Size = new System.Drawing.Size(53, 14);
            this.labelFinanceInput.TabIndex = 30;
            this.labelFinanceInput.Text = "template";
            this.labelFinanceInput.Visible = false;
            // 
            // labelPhoneInput
            // 
            this.labelPhoneInput.AutoSize = true;
            this.labelPhoneInput.Location = new System.Drawing.Point(487, 205);
            this.labelPhoneInput.Name = "labelPhoneInput";
            this.labelPhoneInput.Size = new System.Drawing.Size(53, 14);
            this.labelPhoneInput.TabIndex = 29;
            this.labelPhoneInput.Text = "template";
            this.labelPhoneInput.Visible = false;
            // 
            // labelSandPInput
            // 
            this.labelSandPInput.AutoSize = true;
            this.labelSandPInput.Location = new System.Drawing.Point(487, 182);
            this.labelSandPInput.Name = "labelSandPInput";
            this.labelSandPInput.Size = new System.Drawing.Size(53, 14);
            this.labelSandPInput.TabIndex = 28;
            this.labelSandPInput.Text = "template";
            this.labelSandPInput.Visible = false;
            // 
            // labelHCNInput
            // 
            this.labelHCNInput.AutoSize = true;
            this.labelHCNInput.Location = new System.Drawing.Point(487, 159);
            this.labelHCNInput.Name = "labelHCNInput";
            this.labelHCNInput.Size = new System.Drawing.Size(53, 14);
            this.labelHCNInput.TabIndex = 27;
            this.labelHCNInput.Text = "template";
            this.labelHCNInput.Visible = false;
            // 
            // labelDDInput
            // 
            this.labelDDInput.AutoSize = true;
            this.labelDDInput.Location = new System.Drawing.Point(487, 136);
            this.labelDDInput.Name = "labelDDInput";
            this.labelDDInput.Size = new System.Drawing.Size(53, 14);
            this.labelDDInput.TabIndex = 26;
            this.labelDDInput.Text = "template";
            this.labelDDInput.Visible = false;
            // 
            // labelDAInput
            // 
            this.labelDAInput.AutoSize = true;
            this.labelDAInput.Location = new System.Drawing.Point(487, 113);
            this.labelDAInput.Name = "labelDAInput";
            this.labelDAInput.Size = new System.Drawing.Size(53, 14);
            this.labelDAInput.TabIndex = 25;
            this.labelDAInput.Text = "template";
            this.labelDAInput.Visible = false;
            // 
            // labelLocInput
            // 
            this.labelLocInput.AutoSize = true;
            this.labelLocInput.Location = new System.Drawing.Point(487, 89);
            this.labelLocInput.Name = "labelLocInput";
            this.labelLocInput.Size = new System.Drawing.Size(53, 14);
            this.labelLocInput.TabIndex = 24;
            this.labelLocInput.Text = "template";
            this.labelLocInput.Visible = false;
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(487, 66);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(53, 14);
            this.labelNameInput.TabIndex = 23;
            this.labelNameInput.Text = "template";
            this.labelNameInput.Visible = false;
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(391, 304);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonNotes.TabIndex = 22;
            this.buttonNotes.Text = "Submit";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Visible = false;
            this.buttonNotes.Click += new System.EventHandler(this.SubmitNotesClick);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(490, 274);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(225, 104);
            this.textBoxNotes.TabIndex = 21;
            this.textBoxNotes.Visible = false;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(379, 274);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(102, 14);
            this.labelNotes.TabIndex = 20;
            this.labelNotes.Text = "Additional Notes: ";
            this.labelNotes.Visible = false;
            // 
            // labelPatientBed
            // 
            this.labelPatientBed.AutoSize = true;
            this.labelPatientBed.Location = new System.Drawing.Point(448, 251);
            this.labelPatientBed.Name = "labelPatientBed";
            this.labelPatientBed.Size = new System.Drawing.Size(33, 14);
            this.labelPatientBed.TabIndex = 19;
            this.labelPatientBed.Text = "Bed: ";
            this.labelPatientBed.Visible = false;
            // 
            // labelFinance
            // 
            this.labelFinance.AutoSize = true;
            this.labelFinance.Location = new System.Drawing.Point(387, 228);
            this.labelFinance.Name = "labelFinance";
            this.labelFinance.Size = new System.Drawing.Size(94, 14);
            this.labelFinance.TabIndex = 18;
            this.labelFinance.Text = "Financial Status: ";
            this.labelFinance.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(388, 205);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(93, 14);
            this.labelPhone.TabIndex = 17;
            this.labelPhone.Text = "Phone Number: ";
            this.labelPhone.Visible = false;
            // 
            // labelSandP
            // 
            this.labelSandP.AutoSize = true;
            this.labelSandP.Location = new System.Drawing.Point(394, 182);
            this.labelSandP.Name = "labelSandP";
            this.labelSandP.Size = new System.Drawing.Size(87, 14);
            this.labelSandP.TabIndex = 16;
            this.labelSandP.Text = "Sex/Pronouns: ";
            this.labelSandP.Visible = false;
            // 
            // labelHCN
            // 
            this.labelHCN.AutoSize = true;
            this.labelHCN.Location = new System.Drawing.Point(444, 159);
            this.labelHCN.Name = "labelHCN";
            this.labelHCN.Size = new System.Drawing.Size(37, 14);
            this.labelHCN.TabIndex = 15;
            this.labelHCN.Text = "HCN: ";
            this.labelHCN.Visible = false;
            // 
            // labelDD
            // 
            this.labelDD.AutoSize = true;
            this.labelDD.Location = new System.Drawing.Point(383, 136);
            this.labelDD.Name = "labelDD";
            this.labelDD.Size = new System.Drawing.Size(98, 14);
            this.labelDD.TabIndex = 14;
            this.labelDD.Text = "Date Discharged: ";
            this.labelDD.Visible = false;
            // 
            // labelDA
            // 
            this.labelDA.AutoSize = true;
            this.labelDA.Location = new System.Drawing.Point(392, 113);
            this.labelDA.Name = "labelDA";
            this.labelDA.Size = new System.Drawing.Size(89, 14);
            this.labelDA.TabIndex = 13;
            this.labelDA.Text = "Date Admitted: ";
            this.labelDA.Visible = false;
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Location = new System.Drawing.Point(423, 89);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(58, 14);
            this.labelLoc.TabIndex = 12;
            this.labelLoc.Text = "Location: ";
            this.labelLoc.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(437, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 14);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name: ";
            this.labelName.Visible = false;
            // 
            // labelPatientInfo
            // 
            this.labelPatientInfo.AutoSize = true;
            this.labelPatientInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientInfo.Location = new System.Drawing.Point(487, 10);
            this.labelPatientInfo.Name = "labelPatientInfo";
            this.labelPatientInfo.Size = new System.Drawing.Size(130, 16);
            this.labelPatientInfo.TabIndex = 10;
            this.labelPatientInfo.Text = "Patient Information";
            this.labelPatientInfo.Visible = false;
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.ItemHeight = 14;
            this.listBoxPatients.Location = new System.Drawing.Point(20, 66);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(306, 312);
            this.listBoxPatients.TabIndex = 9;
            this.listBoxPatients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PatientDoubleClick);
            // 
            // labelPatients
            // 
            this.labelPatients.AutoSize = true;
            this.labelPatients.Location = new System.Drawing.Point(17, 50);
            this.labelPatients.Name = "labelPatients";
            this.labelPatients.Size = new System.Drawing.Size(49, 14);
            this.labelPatients.TabIndex = 8;
            this.labelPatients.Text = "Patients";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(235, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "View Patients";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonClickViewPatients);
            // 
            // textBoxPhysicianNo
            // 
            this.textBoxPhysicianNo.Location = new System.Drawing.Point(128, 11);
            this.textBoxPhysicianNo.Name = "textBoxPhysicianNo";
            this.textBoxPhysicianNo.Size = new System.Drawing.Size(100, 21);
            this.textBoxPhysicianNo.TabIndex = 6;
            // 
            // labelPhysicianNo
            // 
            this.labelPhysicianNo.AutoSize = true;
            this.labelPhysicianNo.Location = new System.Drawing.Point(17, 14);
            this.labelPhysicianNo.Name = "labelPhysicianNo";
            this.labelPhysicianNo.Size = new System.Drawing.Size(105, 14);
            this.labelPhysicianNo.TabIndex = 5;
            this.labelPhysicianNo.Text = "Physician Number:";
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneral.Location = new System.Drawing.Point(11, 261);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(198, 21);
            this.labelGeneral.TabIndex = 28;
            this.labelGeneral.Text = "General Bed Information";
            // 
            // dataGridViewBeds
            // 
            this.dataGridViewBeds.AllowUserToAddRows = false;
            this.dataGridViewBeds.AllowUserToDeleteRows = false;
            this.dataGridViewBeds.AllowUserToResizeColumns = false;
            this.dataGridViewBeds.AllowUserToResizeRows = false;
            this.dataGridViewBeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBeds.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeds.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBeds.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewBeds.Name = "dataGridViewBeds";
            this.dataGridViewBeds.ReadOnly = true;
            this.dataGridViewBeds.Size = new System.Drawing.Size(733, 222);
            this.dataGridViewBeds.TabIndex = 29;
            // 
            // labelOccByRoom
            // 
            this.labelOccByRoom.AutoSize = true;
            this.labelOccByRoom.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccByRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOccByRoom.Location = new System.Drawing.Point(202, 303);
            this.labelOccByRoom.Name = "labelOccByRoom";
            this.labelOccByRoom.Size = new System.Drawing.Size(41, 16);
            this.labelOccByRoom.TabIndex = 30;
            this.labelOccByRoom.Text = "label1";
            // 
            // labelOccByBed
            // 
            this.labelOccByBed.AutoSize = true;
            this.labelOccByBed.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccByBed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOccByBed.Location = new System.Drawing.Point(442, 303);
            this.labelOccByBed.Name = "labelOccByBed";
            this.labelOccByBed.Size = new System.Drawing.Size(41, 16);
            this.labelOccByBed.TabIndex = 31;
            this.labelOccByBed.Text = "label1";
            // 
            // labelBedDischarging
            // 
            this.labelBedDischarging.AutoSize = true;
            this.labelBedDischarging.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedDischarging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBedDischarging.Location = new System.Drawing.Point(696, 303);
            this.labelBedDischarging.Name = "labelBedDischarging";
            this.labelBedDischarging.Size = new System.Drawing.Size(41, 16);
            this.labelBedDischarging.TabIndex = 32;
            this.labelBedDischarging.Text = "label1";
            // 
            // labelPInput
            // 
            this.labelPInput.AutoSize = true;
            this.labelPInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPInput.Location = new System.Drawing.Point(251, 337);
            this.labelPInput.Name = "labelPInput";
            this.labelPInput.Size = new System.Drawing.Size(41, 16);
            this.labelPInput.TabIndex = 33;
            this.labelPInput.Text = "label1";
            // 
            // labelSPInput
            // 
            this.labelSPInput.AutoSize = true;
            this.labelSPInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSPInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSPInput.Location = new System.Drawing.Point(373, 337);
            this.labelSPInput.Name = "labelSPInput";
            this.labelSPInput.Size = new System.Drawing.Size(41, 16);
            this.labelSPInput.TabIndex = 34;
            this.labelSPInput.Text = "label1";
            // 
            // labelICInput
            // 
            this.labelICInput.AutoSize = true;
            this.labelICInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelICInput.Location = new System.Drawing.Point(504, 337);
            this.labelICInput.Name = "labelICInput";
            this.labelICInput.Size = new System.Drawing.Size(41, 16);
            this.labelICInput.TabIndex = 35;
            this.labelICInput.Text = "label1";
            // 
            // labelW3Input
            // 
            this.labelW3Input.AutoSize = true;
            this.labelW3Input.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW3Input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelW3Input.Location = new System.Drawing.Point(603, 337);
            this.labelW3Input.Name = "labelW3Input";
            this.labelW3Input.Size = new System.Drawing.Size(41, 16);
            this.labelW3Input.TabIndex = 36;
            this.labelW3Input.Text = "label1";
            // 
            // labelW4Input
            // 
            this.labelW4Input.AutoSize = true;
            this.labelW4Input.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW4Input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelW4Input.Location = new System.Drawing.Point(705, 337);
            this.labelW4Input.Name = "labelW4Input";
            this.labelW4Input.Size = new System.Drawing.Size(41, 16);
            this.labelW4Input.TabIndex = 37;
            this.labelW4Input.Text = "label1";
            // 
            // labelPEInput
            // 
            this.labelPEInput.AutoSize = true;
            this.labelPEInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPEInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPEInput.Location = new System.Drawing.Point(251, 367);
            this.labelPEInput.Name = "labelPEInput";
            this.labelPEInput.Size = new System.Drawing.Size(41, 16);
            this.labelPEInput.TabIndex = 38;
            this.labelPEInput.Text = "label1";
            // 
            // labelSPEInput
            // 
            this.labelSPEInput.AutoSize = true;
            this.labelSPEInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSPEInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSPEInput.Location = new System.Drawing.Point(373, 367);
            this.labelSPEInput.Name = "labelSPEInput";
            this.labelSPEInput.Size = new System.Drawing.Size(41, 16);
            this.labelSPEInput.TabIndex = 39;
            this.labelSPEInput.Text = "label1";
            // 
            // labelICEInput
            // 
            this.labelICEInput.AutoSize = true;
            this.labelICEInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICEInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelICEInput.Location = new System.Drawing.Point(504, 367);
            this.labelICEInput.Name = "labelICEInput";
            this.labelICEInput.Size = new System.Drawing.Size(41, 16);
            this.labelICEInput.TabIndex = 40;
            this.labelICEInput.Text = "label1";
            // 
            // labelW3EInput
            // 
            this.labelW3EInput.AutoSize = true;
            this.labelW3EInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW3EInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelW3EInput.Location = new System.Drawing.Point(603, 367);
            this.labelW3EInput.Name = "labelW3EInput";
            this.labelW3EInput.Size = new System.Drawing.Size(41, 16);
            this.labelW3EInput.TabIndex = 41;
            this.labelW3EInput.Text = "label1";
            // 
            // labelW4EInput
            // 
            this.labelW4EInput.AutoSize = true;
            this.labelW4EInput.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW4EInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelW4EInput.Location = new System.Drawing.Point(705, 367);
            this.labelW4EInput.Name = "labelW4EInput";
            this.labelW4EInput.Size = new System.Drawing.Size(41, 16);
            this.labelW4EInput.TabIndex = 42;
            this.labelW4EInput.Text = "label1";
            // 
            // FormLRCHPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.tabControlNavigation);
            this.Name = "FormLRCHPrototype";
            this.Text = "Lakeridge Community Hospital Manager";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControlNavigation.ResumeLayout(false);
            this.tabRoomUtil.ResumeLayout(false);
            this.tabRoomUtil.PerformLayout();
            this.tabPhysicianPatient.ResumeLayout(false);
            this.tabPhysicianPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeds)).EndInit();
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
        private System.Windows.Forms.Label labelOccByRoomType;
        private System.Windows.Forms.Label labelWard4;
        private System.Windows.Forms.Label labelWard3;
        private System.Windows.Forms.Label labelIC;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelBedsDischarging;
        private System.Windows.Forms.Label labelEmptyRooms;
        private System.Windows.Forms.Label labelW4E;
        private System.Windows.Forms.Label labelW3E;
        private System.Windows.Forms.Label labelICE;
        private System.Windows.Forms.Label labelSPE;
        private System.Windows.Forms.Label labelPE;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatientInfo;
        private System.Windows.Forms.Label labelDA;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelDD;
        private System.Windows.Forms.Label labelBedInput;
        private System.Windows.Forms.Label labelFinanceInput;
        private System.Windows.Forms.Label labelPhoneInput;
        private System.Windows.Forms.Label labelSandPInput;
        private System.Windows.Forms.Label labelHCNInput;
        private System.Windows.Forms.Label labelDDInput;
        private System.Windows.Forms.Label labelDAInput;
        private System.Windows.Forms.Label labelLocInput;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelPatientBed;
        private System.Windows.Forms.Label labelFinance;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSandP;
        private System.Windows.Forms.Label labelHCN;
        private System.Windows.Forms.DataGridView dataGridViewBeds;
        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.Label labelOccByRoom;
        private System.Windows.Forms.Label labelBedDischarging;
        private System.Windows.Forms.Label labelOccByBed;
        private System.Windows.Forms.Label labelW4Input;
        private System.Windows.Forms.Label labelW3Input;
        private System.Windows.Forms.Label labelICInput;
        private System.Windows.Forms.Label labelSPInput;
        private System.Windows.Forms.Label labelPInput;
        private System.Windows.Forms.Label labelICEInput;
        private System.Windows.Forms.Label labelSPEInput;
        private System.Windows.Forms.Label labelPEInput;
        private System.Windows.Forms.Label labelW4EInput;
        private System.Windows.Forms.Label labelW3EInput;
    }
}

