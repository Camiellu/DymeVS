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
        private static DBConnection dB = new DBConnection();
        public Restaurant Restaurant { get; set; }
        public Guest Guest { get; set; }
        public List<Ingredient> CheckedIngredients = new List<Ingredient>();

        public MenuForm()
        {
            InitializeComponent();

        }




        private void btnConfirmFilters_Click(object sender, EventArgs e)
        {
            // Check if a menu is selected
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

        // Actions when loading form
        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblGuestInfo.Text = $"Welkom {Guest.FirstName}!";
            FillMenuAndIngredients();
            // Load menus and ingredients 

        }

        // Actions when form closes
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void listDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOrder.Items.Add(listDishes.SelectedItem);
        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOrder.Items.Remove(listOrder.SelectedItem);
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            double price = 0;
            foreach (Dish dish in listOrder.Items)
            {
                dishes.Add(dish);
                price += dish.Price;

            }

            lblGetPrice.Text = $"Prijs gerechten: €{Math.Round(price, 3)}";
            IGetDiscount getDiscount = new GetDishDiscount(dishes);
            double totalDiscount = getDiscount.GetDiscount(Guest);
            lblGetDiscount.Text = $"Uw korting: €{totalDiscount}";
            double endPrice = Math.Round(price - totalDiscount, 3);
            lblTotalPrice.Text = $"Totaalprijs: €{endPrice}";

            Order order = new Order(dishes, endPrice, DateTime.Now);
        }
    }
}
