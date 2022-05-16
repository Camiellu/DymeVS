using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class Restaurant
    {
        private string name;
        private List<Guest> guests;
        private List<Menu> menus;
        private List<Order> orders;

        public Restaurant(string name, List<Guest> guests, List<Menu> menus, List<Order> orders)
        {
            this.Name = name;
            this.Guests = guests;
            this.Menus = menus;
            this.Orders = orders;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Guest> Guests
        {
            get => guests;
            set => guests = value;
        }

        public List<Menu> Menus
        {
            get => menus;
            set => menus = value;
        }
        public List<Order> Orders
        {
            get => orders;
            set => orders = value;
        }

        public void AddGuest(Guest guest)
        {
            this.guests.Add(guest);
        }
        public void AddMenu(Menu menu)
        {
            this.menus.Add(menu);
        }
        public void AddOrder(Order order, Guest guest)
        {
            
        }
    }
}