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
        public Guest guest { get; set; }
        public MenuForm()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {

        }

        // Actions when form closes
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }


        // Actions when loading form
        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblGuestInfo.Text = $"Welkom {guest.FirstName}!";
            foreach (var m in Restaurant.Menus)
            {
                comboSelectMenu.Items.Add(m.ToString());
            }

            foreach (var m in Restaurant.Menus)
            {
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

        private void btnConfirmFilters_Click(object sender, EventArgs e)
        {
            List<Dish> dishes = new List<Dish>();
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (Ingredient i in checkedIngredientFilter.CheckedItems)
            {
                ingredients.Add(i);
            }
            listDishes.Items.Clear();
            foreach (var m in Restaurant.Menus)
            {
                if (comboSelectMenu.SelectedIndex > -1 && m.Name.Equals(comboSelectMenu.SelectedItem.ToString()))
                {
                    foreach (var d in m.Dishes)
                    {
                        listDishes.Items.Add(d.ToString());
                    }
                }
            }
        }
    }
}
