
namespace GUI
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnEnterGuest = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.checkboxSelectAllergy = new System.Windows.Forms.CheckedListBox();
            this.lblSelectAllergy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnterGuest
            // 
            this.btnEnterGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterGuest.Location = new System.Drawing.Point(110, 198);
            this.btnEnterGuest.Name = "btnEnterGuest";
            this.btnEnterGuest.Size = new System.Drawing.Size(100, 23);
            this.btnEnterGuest.TabIndex = 0;
            this.btnEnterGuest.Text = "Enter";
            this.btnEnterGuest.UseVisualStyleBackColor = true;
            this.btnEnterGuest.Click += new System.EventHandler(this.btnEnterGuest_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 128);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(46, 104);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Voornaam:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(37, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Achternaam:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(21, 161);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(83, 13);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Geboortedatum:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(150, 35);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(152, 22);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welkom bij Dyme!";
            // 
            // checkboxSelectAllergy
            // 
            this.checkboxSelectAllergy.FormattingEnabled = true;
            this.checkboxSelectAllergy.Location = new System.Drawing.Point(256, 101);
            this.checkboxSelectAllergy.Name = "checkboxSelectAllergy";
            this.checkboxSelectAllergy.Size = new System.Drawing.Size(136, 109);
            this.checkboxSelectAllergy.TabIndex = 9;
            this.checkboxSelectAllergy.ThreeDCheckBoxes = true;
            // 
            // lblSelectAllergy
            // 
            this.lblSelectAllergy.AutoSize = true;
            this.lblSelectAllergy.Location = new System.Drawing.Point(256, 82);
            this.lblSelectAllergy.Name = "lblSelectAllergy";
            this.lblSelectAllergy.Size = new System.Drawing.Size(74, 13);
            this.lblSelectAllergy.TabIndex = 10;
            this.lblSelectAllergy.Text = "Uw allergieën:";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.lblSelectAllergy);
            this.Controls.Add(this.checkboxSelectAllergy);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnEnterGuest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Dyme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGuest;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.CheckedListBox checkboxSelectAllergy;
        private System.Windows.Forms.Label lblSelectAllergy;
    }
}

