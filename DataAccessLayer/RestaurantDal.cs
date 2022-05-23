using System.Collections.Generic;
using Business;
using Business.DataAccess;
using Business.Models;

namespace DataAccessLayer
{
    public class RestaurantDal : IRestaurantRepository
    {

        public Restaurant GetRestaurant()
        {
            DBConnection dB = new DBConnection();
            return dB.GetRestaurant();
        }
    }
}