using Business.BusinessLogic;
using Business.Models;
using Business.DataAccess;
using Business.Filter;
using Business.GetDiscount;
using System.Collections.Generic;
using System;

namespace Business
{
    public class BusinessController
    {
        public Restaurant Restaurant { get; set; }
        public Guest Guest { get; set; }
        public IngredientFilter IngredientFilter { get; set; }
        public AllergyFilter AllergyFilter { get; set; }
        public Menu Menu { get; set; }
        public Order Order { get; set; }

        /*
         * Sets the restaurant of the program
         */
        public void GetRestaurant(RestaurantManager restaurantManager)
        {
            Restaurant = restaurantManager.GetRestaurant();
            Menu = Restaurant.Menus[0];
        }

        /*
         * Returns restaurant name
         */
        public string GetRestaurantName()
        {
            return Restaurant.Name;
        }
        /*
         * Returns the menu names of the restaurant
         */
        public List<Menu> GetRestaurantMenus()
        {
            return Restaurant.Menus;
        }

        /*
         * Adds new guest to the restaurant
         */
        public void AddGuest(string firstName, string lastName, DateTime dateOfBirth, List<string> allergyNames)
        {

            Guest guest = new Guest(firstName, lastName, dateOfBirth, ConvertAllergies(allergyNames));
            Restaurant.AddGuest(guest);
            this.Guest = guest;
        }

        /*
         * Set the selected filters
         */
        public List<IFilterPossibility> GetFilters(List<string> ingredientFilters)
        {

            List<IFilterPossibility> filterPossibilities = new List<IFilterPossibility> { GetAllergyFilter(), GetIngredientFilter(ingredientFilters) };

            return filterPossibilities;
        }

        /*
         * Sets the ingredient filters
         */
        public IngredientFilter GetIngredientFilter(List<string> ingredientNames)
        {
            this.IngredientFilter = new IngredientFilter(GetIngredients(ingredientNames));

            return this.IngredientFilter;
        }

        /*
         * Sets the allergy filters
         */
        public AllergyFilter GetAllergyFilter()
        {
            this.AllergyFilter = new AllergyFilter(this.Guest.Allergies);
            return AllergyFilter;
        }

        /*
         * Sets the selected menu
         */
        public bool GetSelectedMenu(string menuName)
        {
            foreach (var menu in Restaurant.Menus)
            {
                if (menu.Name == menuName)
                {
                    this.Menu = menu;
                    return true;
                }
            }

            return false;
        }

        /*
         * Returns the filtered dishes
         */
        public List<string> FilterDishes(List<string> ingredientNames)
        {
            List<string> filteredDishes = new List<string>();
            foreach (Dish dish in this.Menu.FilterDishes(GetFilters(ingredientNames)))
            {
                filteredDishes.Add(dish.Name);
            }
            return filteredDishes;
        }

        /*
         * Sets dish names to dishes
         */
        public List<Dish> ConvertDishes(List<string> dishNames)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (var menu in GetRestaurantMenus())
            {
                foreach (var dish in menu.Dishes)
                {
                    foreach (var dishName in dishNames)
                    {
                        if (dishName.Equals(dish.Name))
                        {
                            dishes.Add(dish);
                        }
                    }
                }
            }

            return dishes;
        }

        /*
         * Gets all the allergies available in this restaurant
         */
        public List<Allergy> GetAllergiesList()
        {
            List<Allergy> allergyList = new List<Allergy>();
            foreach (var menu in GetRestaurantMenus())
            {
                foreach (var dish in menu.Dishes)
                {
                    foreach (var allergy in dish.Allergies)
                    {
                        allergyList.Add(allergy);
                    }
                }
            }
            return allergyList;
        }
        /*
         * Sets allergy names to allergies
         */
        public List<Allergy> ConvertAllergies(List<string> allergyNames)
        {
            List<Allergy> allergyList = new List<Allergy>();
            foreach (string allergyName in allergyNames)
            {
                foreach (var allergy in GetAllergiesList())
                {
                    if (allergyName.Equals(allergy.Name))
                    {
                        allergyList.Add(allergy);
                    }
                }
            }

            return allergyList;
        }

        /*
         * Method to convert the allergy selection with all the available allergies
         */
        public List<string> SetAllergyList()
        {
            List<string> allergyNames = new List<string>();
            foreach (var allergy in GetAllergiesList())
            {
                allergyNames.Add(allergy.Name);
            }

            return allergyNames;
        }

        /*
         * Gets all dish names in menu
         */
        //public List<string> GetMenuDishes()
        //{
        //    List<string> dishNames = new List<string>();
        //    foreach (Dish dish in this.Menu.Dishes)
        //    {
        //        dishNames.Add(dish.Name);
        //    }

        //    return dishNames;
        //}

        /*
        * Gets all ingredients in dish
        */
        public List<Ingredient> GetIngredients(List<string> ingredientNames)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (var dish in Menu.Dishes)
            {
                foreach (var ingredient in dish.Ingredients)
                {

                    if (ingredientNames.Contains(ingredient.Name))
                    {
                        ingredients.Add(ingredient);
                    }

                }

            }
            return ingredients;
        }
        /*
         * Gets all ingredient names in dishes
         */
        public List<string> GetDishIngredientNames()
        {
            List<string> ingredientNames = new List<string>();
            foreach (var menu in Restaurant.Menus)
            {
                foreach (var dish in menu.Dishes)
                {
                    foreach (var ingredient in dish.Ingredients)
                    {
                        if (!ingredientNames.Contains(ingredient.Name))
                        {
                            ingredientNames.Add(ingredient.Name);
                        }
                    }
                }
            }
            
            return ingredientNames;
        }

        /*
         * Adds order to restaurant and calculates discount
         */
        public void AddOrder(List<string> dishes)
        {
            List<Dish> dishList = ConvertDishes(dishes);
            double totalPrice = 0;
            foreach (var dish in dishList)
            {
                totalPrice += dish.Price;
            }
            Order = new Order(dishList, totalPrice, DateTime.Now, Guest);
            List<IGetDiscount> getDiscounts = new List<IGetDiscount>
                {new GetBirthdayDiscount(Order, Restaurant.BirthdayDiscount), new GetNameDiscount(Order, Restaurant.NameDiscount)};
            Order.CalculateDiscount(getDiscounts);
        }

        public double GetOrderTotalPrice()
        {
            return Order.TotalPrice;
        }

        public double GetOrderDiscount()
        {
            
            return Order.Discount;
        }

        public double GetOrderFinalPrice()
        {
            return Order.FinalPrice;
        }
    }
}