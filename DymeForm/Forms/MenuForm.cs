using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;
using GUI.Forms;

namespace GUI
{
    public partial class MenuForm : Form
    {
        public BusinessController Controller { get; set; }


        public MenuForm()
        {
            InitializeComponent();

        }

        /*
         * Loads dishes when ingredient is selected
         */
        private void checkedIngredientFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishList();
        }

        /*
         * Actions when loading form
         */
        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblGuestInfo.Text = $"Welkom {Controller.Guest.FirstName}!";
            // Load menus and ingredients 
            FillMenus();

        }

        /*
          * Actions when form closes
          */
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        /*
         * Adds dish to order list when dish is selected
         */
        private void listDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOrder.Items.Add(listDishes.SelectedItem);
        }

        /*
         * Removes dish fromorder list when dish is selected
         */
        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOrder.Items.Remove(listOrder.SelectedItem);
        }


        /*
         * Button to calculate and make the order
         */
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            List<string> dishes = new List<string>();
            foreach (string dish in listOrder.Items)
            {
                dishes.Add(dish);
            }
            Controller.AddOrder(dishes);
            lblGetPrice.Text = $"Prijs gerechten: {Controller.Order.TotalPrice.ToString("c2")}";
            lblGetDiscount.Text = $"Uw korting: {Controller.Order.Discount.ToString("c2")}";
            lblTotalPrice.Text = $"Totaalprijs: {Controller.Order.FinalPrice.ToString("c2")}";

        }


        /*
         * Loads dish list when menu changed
         */
        private void comboSelectMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishList();
            FillIngredients();
        }


        /*
         * Fills the menu and ingredient listbox
         */
        private void FillMenus()
        {
            comboSelectMenu.Items.Clear();

            foreach (var m in Controller.GetRestaurantMenus())
            {
                comboSelectMenu.Items.Add(m.Name);
            }
        }

        /*
         * Fills ingredient listbox
         */
        private void FillIngredients()
        {
            foreach (var ingredientName in Controller.GetDishIngredientNames())
            {
                if (!checkedIngredientFilter.Items.Contains(ingredientName))
                {
                    checkedIngredientFilter.Items.Add(ingredientName);
                }
            }
        }

        /*
         * Fills dish list with applied filters
         */
        private void LoadDishList()
        {
            if (comboSelectMenu.SelectedIndex > -1)
            {
                List<string> ingredientFilters = new List<string>();
                listDishes.Items.Clear();
                foreach (string ingredientName in checkedIngredientFilter.CheckedItems)
                {
                    ingredientFilters.Add(ingredientName);
                }

                Controller.GetSelectedMenu(comboSelectMenu.SelectedItem.ToString());
                foreach (var dishName in Controller.FilterDishes(ingredientFilters))
                {
                    listDishes.Items.Add(dishName);
                }
            }
            else
            {
                MessageBox.Show("U moet een menu selecteren!");
            }
        }

    }
}
