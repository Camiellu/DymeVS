using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DymeForm
{
    public partial class MenuForm : Form
    {
        public Restaurant Restaurant { get; set; }
        public Guest Guest { get; set; }
        public List<Ingredient> CheckedIngredients = new List<Ingredient>();

        public MenuForm()
        {
            InitializeComponent();

        }

        /*
         * Button to add selected ingredients to filter list
         */
        private void btnConfirmFilters_Click(object sender, EventArgs e)
        {
            LoadDishList();
        }

        /*
         * Actions when loading form
         */
        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblGuestInfo.Text = $"Welkom {Guest.FirstName}!";
            // Load menus and ingredients 
            FillMenuAndIngredients();

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
            List<Dish> dishes = new List<Dish>();
            double totalPrice = 0;
            foreach (Dish dish in listOrder.Items)
            {
                dishes.Add(dish);
                totalPrice += dish.Price;

            }

            Order order = new Order(dishes, totalPrice, DateTime.Now, Guest);
            lblGetPrice.Text = $"Prijs gerechten: {order.TotalPrice.ToString("c2")}";

            IGetDiscount nameDiscountCalculator = new GetNameDiscount(order, Restaurant.NameDiscount);
            IGetDiscount birthdayDiscountCalculator = new GetBirthdayDiscount(order, Restaurant.BirthdayDiscount);
            List<IGetDiscount> discountCalculators = new List<IGetDiscount> { nameDiscountCalculator, birthdayDiscountCalculator };
            order.CalculateDiscount(discountCalculators);
            lblGetDiscount.Text = $"Uw korting: {order.Discount.ToString("c2")}";

            lblTotalPrice.Text = $"Totaalprijs: {order.FinalPrice.ToString("c2")}";

        }


        /*
         * Loads dish list when menu changed
         */
        private void comboSelectMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishList();
        }


        /*
         * Method to fill the menu and ingredient list upon loading
         */
        private void FillMenuAndIngredients()
        {
            comboSelectMenu.Items.Clear();
            checkedIngredientFilter.Items.Clear();
            foreach (var m in Restaurant.Menus)
            {
                comboSelectMenu.Items.Add(m);
                foreach (var d in m.Dishes)
                {
                    foreach (var i in d.Ingredients)
                    {
                        if (!checkedIngredientFilter.Items.Contains(i))
                        {
                            checkedIngredientFilter.Items.Add(i);
                        }
                    }
                }
            }
        }

        /*
         * Method to load the dish list with selected filters
         */
        private void LoadDishList()
        {
            if (comboSelectMenu.SelectedIndex > -1)
            {
                listDishes.Items.Clear();
                CheckedIngredients.Clear();
                foreach (Ingredient i in checkedIngredientFilter.CheckedItems)
                {
                    CheckedIngredients.Add(i);
                }

                AllergyFilter allergyFilter = new AllergyFilter(Guest.Allergies);
                IngredientFilter ingredientFilter = new IngredientFilter(CheckedIngredients);
                List<IFilterPossibility> filters = new List<IFilterPossibility> { allergyFilter, ingredientFilter };
                Menu menu = (Menu)comboSelectMenu.SelectedItem;
                foreach (var dish in menu.FilterDishes(filters))
                {
                    listDishes.Items.Add(dish);
                }
            }
            else
            {
                MessageBox.Show("U moet een menu selecteren!");
            }
        }
    }
}
