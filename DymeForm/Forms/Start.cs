using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;
using Business.BusinessLogic;
using DataAccesLayer;

namespace GUI.Forms
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
            foreach (string name in controller.SetAllergyList())
            {
                if (!checkboxSelectAllergy.Items.Contains(name))
                {
                    checkboxSelectAllergy.Items.Add(name);
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
            List<string> allergyNames = new List<string>();
            foreach (string allergyName in checkboxSelectAllergy.CheckedItems)
            {
                allergyNames.Add(allergyName);
            }
            MenuForm menuForm = new MenuForm();
            controller.AddGuest(firstName, lastName, dateOfBirth, allergyNames);
            menuForm.Controller = this.controller;
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
