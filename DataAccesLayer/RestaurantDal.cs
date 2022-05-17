using Business;

namespace DataAccesLayer
{
    public class RestaurantDto : IGetRestaurant
    {
        public Restaurant Restaurant { get; set; }

        public RestaurantDto ()
        {
            DBConnection dB = new DBConnection();
            Restaurant = dB.GetRestaurant();
        }

        public Restaurant GetRestaurant()
        {
            DBConnection dB = new DBConnection();
            Restaurant = dB.GetRestaurant();
            return Restaurant;
        }
    }
}