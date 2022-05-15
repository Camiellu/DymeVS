using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class Restaurant
    {
        private string name;
        private List<Guest> guests;
        private List<Menu> menus;

        public Restaurant(string name, List<Guest> guests, List<Menu> menus)
        {
            this.Name = name;
            this.Guests = guests;
            this.Menus = menus;
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

        public bool AddGuest(Guest guest)
        {
            try
            {
                this.guests.Add(guest);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool AddMenu(Menu menu)
        {
            try
            {
                this.menus.Add(menu);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}