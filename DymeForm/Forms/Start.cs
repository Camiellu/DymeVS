using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Business.BusinessLogic;
using Business.Models;
using DataAccesLayer;

namespace GUI
{
    public partial class Start : Form
    {
        BusinessController controller = new BusinessController();
        RestaurantManager restaurantManager = new RestaurantManager(new RestaurantDal());

        public Start()
        {
            InitializeComponent();
            controller.GetRestaurant(restaurantManager);
            lblWelcome.Text = $"Welkom bij {controller.GetRestaurantName()}!";
            foreach (var m in controller.GetRestaurantMenus())
            {
                foreach (var d in m.Dishes)
                {
                    foreach (var a in d.Allergies)
                    {
                        if (!checkboxSelectAllergy.Items.Contains(a))
                        {
                            checkboxSelectAllergy.Items.Add(a);
                        }
                    }
                }
            }
        }

        /*
         * Button to save guest and head to next form
         */
        private void btnEnterGuest_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            List<Allergy> allergies = new List<Allergy>();
            foreach (Allergy a in checkboxSelectAllergy.CheckedItems)
            {
                allergies.Add(a);
            }
            MenuForm menuForm = new MenuForm();
            controller.AddGuest(firstName, lastName, dateOfBirth, allergies);
            menuForm.controller = this.controller;
            menuForm.Show();
            this.Hide();
        }

        /*
         * Close app on closing form
         */
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
