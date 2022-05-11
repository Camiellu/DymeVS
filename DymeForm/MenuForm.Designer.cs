
namespace DymeForm
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.comboSelectMenu = new System.Windows.Forms.ComboBox();
            this.lblSelectMenu = new System.Windows.Forms.Label();
            this.lblGuestInfo = new System.Windows.Forms.Label();
            this.checkedIngredientFilter = new System.Windows.Forms.CheckedListBox();
            this.lblIngredientFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmFilters = new System.Windows.Forms.Button();
            this.listDishes = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboSelectMenu
            // 
            this.comboSelectMenu.FormattingEnabled = true;
            this.comboSelectMenu.Location = new System.Drawing.Point(9, 16);
            this.comboSelectMenu.Name = "comboSelectMenu";
            this.comboSelectMenu.Size = new System.Drawing.Size(135, 21);
            this.comboSelectMenu.TabIndex = 0;
            // 
            // lblSelectMenu
            // 
            this.lblSelectMenu.AutoSize = true;
            this.lblSelectMenu.Location = new System.Drawing.Point(6, 0);
            this.lblSelectMenu.Name = "lblSelectMenu";
            this.lblSelectMenu.Size = new System.Drawing.Size(105, 13);
            this.lblSelectMenu.TabIndex = 1;
            this.lblSelectMenu.Text = "Selecteer een menu:";
            // 
            // lblGuestInfo
            // 
            this.lblGuestInfo.AutoSize = true;
            this.lblGuestInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestInfo.Location = new System.Drawing.Point(12, 9);
            this.lblGuestInfo.Name = "lblGuestInfo";
            this.lblGuestInfo.Size = new System.Drawing.Size(46, 18);
            this.lblGuestInfo.TabIndex = 0;
            this.lblGuestInfo.Text = "label1";
            // 
            // checkedIngredientFilter
            // 
            this.checkedIngredientFilter.FormattingEnabled = true;
            this.checkedIngredientFilter.Location = new System.Drawing.Point(9, 56);
            this.checkedIngredientFilter.Name = "checkedIngredientFilter";
            this.checkedIngredientFilter.Size = new System.Drawing.Size(135, 289);
            this.checkedIngredientFilter.TabIndex = 2;
            // 
            // lblIngredientFilter
            // 
            this.lblIngredientFilter.AutoSize = true;
            this.lblIngredientFilter.Location = new System.Drawing.Point(6, 40);
            this.lblIngredientFilter.Name = "lblIngredientFilter";
            this.lblIngredientFilter.Size = new System.Drawing.Size(135, 13);
            this.lblIngredientFilter.TabIndex = 3;
            this.lblIngredientFilter.Text = "Selecteer ingredientenfilter:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConfirmFilters);
            this.panel1.Controls.Add(this.lblSelectMenu);
            this.panel1.Controls.Add(this.lblIngredientFilter);
            this.panel1.Controls.Add(this.comboSelectMenu);
            this.panel1.Controls.Add(this.checkedIngredientFilter);
            this.panel1.Location = new System.Drawing.Point(15, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 356);
            this.panel1.TabIndex = 4;
            // 
            // btnConfirmFilters
            // 
            this.btnConfirmFilters.Location = new System.Drawing.Point(150, 282);
            this.btnConfirmFilters.Name = "btnConfirmFilters";
            this.btnConfirmFilters.Size = new System.Drawing.Size(75, 63);
            this.btnConfirmFilters.TabIndex = 4;
            this.btnConfirmFilters.Text = "Bevestig";
            this.btnConfirmFilters.UseVisualStyleBackColor = true;
            this.btnConfirmFilters.Click += new System.EventHandler(this.btnConfirmFilters_Click);
            // 
            // listDishes
            // 
            this.listDishes.FormattingEnabled = true;
            this.listDishes.Location = new System.Drawing.Point(278, 44);
            this.listDishes.Name = "listDishes";
            this.listDishes.Size = new System.Drawing.Size(120, 355);
            this.listDishes.TabIndex = 5;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listDishes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGuestInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Dyme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSelectMenu;
        private System.Windows.Forms.Label lblSelectMenu;
        private System.Windows.Forms.Label lblGuestInfo;
        private System.Windows.Forms.CheckedListBox checkedIngredientFilter;
        private System.Windows.Forms.Label lblIngredientFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listDishes;
        private System.Windows.Forms.Button btnConfirmFilters;
    }
}