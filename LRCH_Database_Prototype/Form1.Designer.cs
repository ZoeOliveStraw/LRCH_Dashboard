namespace LRCH_Database_Prototype
{
    partial class Form1
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
            this.tabControl1.SuspendLayout();
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
            this.tabPhysicianPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPhysicianPatient.Name = "tabPhysicianPatient";
            this.tabPhysicianPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhysicianPatient.Size = new System.Drawing.Size(767, 399);
            this.tabPhysicianPatient.TabIndex = 1;
            this.tabPhysicianPatient.Text = "Physician-Patient";
            this.tabPhysicianPatient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRoomUtil;
        private System.Windows.Forms.TabPage tabPhysicianPatient;
    }
}

