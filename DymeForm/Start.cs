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
    public partial class Start : Form
    {
        private static DBConnection dB = new DBConnection();
        public Restaurant Restaurant = dB.GetRestaurant();
        public Start()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welkom bij {Restaurant.Name}!";
            foreach (var m in Restaurant.Menus)
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
            menuForm.Guest = new Guest(firstName, lastName, dateOfBirth, allergies);
            menuForm.Restaurant = Restaurant;
            menuForm.Show();
            this.Hide();
        }



        // Close app on closing form
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }



    }
}
