namespace Business
{
    public class RestaurantManager
    {
        public Restaurant GetRestaurant(IGetRestaurant repository)
        {
            return repository.GetRestaurant();
        }
    }
}