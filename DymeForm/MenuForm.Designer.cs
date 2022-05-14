
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
            this.lblFilteredDishes = new System.Windows.Forms.Label();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.lblGetPrice = new System.Windows.Forms.Label();
            this.lblGetDiscount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panelPriceInfo = new System.Windows.Forms.Panel();
            this.lblDiscountInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelPriceInfo.SuspendLayout();
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
            this.checkedIngredientFilter.CheckOnClick = true;
            this.checkedIngredientFilter.FormattingEnabled = true;
            this.checkedIngredientFilter.Location = new System.Drawing.Point(9, 56);
            this.checkedIngredientFilter.Name = "checkedIngredientFilter";
            this.checkedIngredientFilter.Size = new System.Drawing.Size(132, 289);
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
            this.panel1.Size = new System.Drawing.Size(231, 356);
            this.panel1.TabIndex = 4;
            // 
            // btnConfirmFilters
            // 
            this.btnConfirmFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmFilters.Location = new System.Drawing.Point(147, 282);
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
            this.listDishes.Location = new System.Drawing.Point(278, 57);
            this.listDishes.Name = "listDishes";
            this.listDishes.Size = new System.Drawing.Size(120, 225);
            this.listDishes.TabIndex = 5;
            this.listDishes.SelectedIndexChanged += new System.EventHandler(this.listDishes_SelectedIndexChanged);
            // 
            // lblFilteredDishes
            // 
            this.lblFilteredDishes.AutoSize = true;
            this.lblFilteredDishes.Location = new System.Drawing.Point(275, 41);
            this.lblFilteredDishes.Name = "lblFilteredDishes";
            this.lblFilteredDishes.Size = new System.Drawing.Size(60, 13);
            this.lblFilteredDishes.TabIndex = 6;
            this.lblFilteredDishes.Text = "Gerechten:";
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Location = new System.Drawing.Point(404, 57);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(120, 225);
            this.listOrder.TabIndex = 7;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(401, 41);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(55, 13);
            this.lblOrderList.TabIndex = 8;
            this.lblOrderList.Text = "Bestelling:";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeOrder.Location = new System.Drawing.Point(404, 289);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(120, 36);
            this.btnMakeOrder.TabIndex = 9;
            this.btnMakeOrder.Text = "Bereken prijs";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // lblGetPrice
            // 
            this.lblGetPrice.AutoSize = true;
            this.lblGetPrice.Location = new System.Drawing.Point(4, 2);
            this.lblGetPrice.Name = "lblGetPrice";
            this.lblGetPrice.Size = new System.Drawing.Size(80, 13);
            this.lblGetPrice.TabIndex = 10;
            this.lblGetPrice.Text = "Prijs gerechten:";
            // 
            // lblGetDiscount
            // 
            this.lblGetDiscount.AutoSize = true;
            this.lblGetDiscount.Location = new System.Drawing.Point(3, 15);
            this.lblGetDiscount.Name = "lblGetDiscount";
            this.lblGetDiscount.Size = new System.Drawing.Size(61, 13);
            this.lblGetDiscount.TabIndex = 11;
            this.lblGetDiscount.Text = "Uw korting:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 35);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Totaalprijs: ";
            // 
            // panelPriceInfo
            // 
            this.panelPriceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPriceInfo.Controls.Add(this.panel2);
            this.panelPriceInfo.Controls.Add(this.lblGetPrice);
            this.panelPriceInfo.Controls.Add(this.lblTotalPrice);
            this.panelPriceInfo.Controls.Add(this.lblGetDiscount);
            this.panelPriceInfo.Location = new System.Drawing.Point(530, 182);
            this.panelPriceInfo.Name = "panelPriceInfo";
            this.panelPriceInfo.Size = new System.Drawing.Size(200, 100);
            this.panelPriceInfo.TabIndex = 13;
            // 
            // lblDiscountInfo
            // 
            this.lblDiscountInfo.AutoSize = true;
            this.lblDiscountInfo.Location = new System.Drawing.Point(527, 56);
            this.lblDiscountInfo.Name = "lblDiscountInfo";
            this.lblDiscountInfo.Size = new System.Drawing.Size(191, 26);
            this.lblDiscountInfo.TabIndex = 14;
            this.lblDiscountInfo.Text = "Ontvang 5% korting op gerechten met \r\ndezelfde eerste letter als uw voornaam!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(6, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 1);
            this.panel2.TabIndex = 13;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiscountInfo);
            this.Controls.Add(this.panelPriceInfo);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.lblFilteredDishes);
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
            this.panelPriceInfo.ResumeLayout(false);
            this.panelPriceInfo.PerformLayout();
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
        private System.Windows.Forms.Label lblFilteredDishes;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Label lblGetPrice;
        private System.Windows.Forms.Label lblGetDiscount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel panelPriceInfo;
        private System.Windows.Forms.Label lblDiscountInfo;
        private System.Windows.Forms.Panel panel2;
    }
}