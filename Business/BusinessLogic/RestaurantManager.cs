using System.Runtime.InteropServices;
using Business.DataAccess;
using Business.Models;

namespace Business.BusinessLogic
{
    public class RestaurantManager 
    {
        private IRestaurantRepository restaurantRepository;

        public RestaurantManager(IRestaurantRepository restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

        public Restaurant GetRestaurant()
        {
            return this.restaurantRepository.GetRestaurant();
        }
    }
}