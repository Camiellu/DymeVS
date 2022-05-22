using System.Collections.Generic;
using Business.DataAccess;

namespace Business.Models
{
    public class Restaurant
    {
        private string name;
        private List<Guest> guests;
        private List<Menu> menus;
        private List<Order> orders;
        private int nameDiscount;
        private int birthdayDiscount;


        public Restaurant(IRestaurantRepository restaurantRepository)
        {
            this.name = restaurantRepository
        }
        public Restaurant(string name, List<Guest> guests, List<Menu> menus, int nameDiscount, int birthdayDiscount)
        {
            this.Name = name;
            this.Guests = guests;
            this.Menus = menus;
            this.NameDiscount = nameDiscount;
            this.BirthdayDiscount = birthdayDiscount;
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

        public int NameDiscount
        {
            get => nameDiscount;
            set => nameDiscount = value;
        }

        public int BirthdayDiscount
        {
            get => birthdayDiscount;
            set => birthdayDiscount = value;
        }

        public void AddGuest(Guest guest)
        {
            this.guests.Add(guest);
        }
        public void AddMenu(Menu menu)
        {
            this.menus.Add(menu);
        }
        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }
    }
}