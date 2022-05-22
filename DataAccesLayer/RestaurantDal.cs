using System.Collections.Generic;
using Business;
using Business.DataAccess;
using Business.Models;

namespace DataAccessLayer
{
    public class RestaurantRepositoryDto : IRestaurantRepository
    {
        private string name;
        private List<Guest> guests;
        private List<Menu> menus;
        private List<Order> orders;
        private int nameDiscount;
        private int birthdayDiscount;
        public RestaurantRepositoryDto ()
        {
          
        }

        
    }
}