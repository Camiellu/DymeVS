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
        public Restaurant restaurant {get; set;}
        public Guest guest { get; set; }
        public IngredientFilter ingredientFilter { get; set;}
        public AllergyFilter allergyFilter { get; set; }
        public Menu menu { get; set; }

        public void GetRestaurant(RestaurantManager restaurantManager)
        {
            restaurant = restaurantManager.GetRestaurant();
        }

        public string GetRestaurantName()
        {
            return restaurant.Name;
        }
        public List<Menu> GetRestaurantMenus()
        {
            return restaurant.Menus;
        }

        public void AddGuest(string firstName, string lastName, DateTime dateOfBirth, List<Allergy> allergies)
        {   
            Guest guest = new Guest(firstName, lastName, dateOfBirth, allergies))
            restaurant.AddGuest(guest);
            this.guest = guest;
        }

        public List<IFilterPossibility> GetFilters(List<IngredientFilter> ingredientFilters)
        {

            List<IFilterPossibility> filterPossibilities = new List<IFilterPossibility>();
            List<AllergyFilter> allergyFilters = new List<AllergyFilter>();
            
            
            return filterPossibilities;
        }

        public IngredientFilter GetIngredientFilter(List<Ingredient> ingredients)
        {
            this.ingredientFilter = new IngredientFilter();
            foreach (Ingredient ingredient in ingredients)
            {
                this.ingredientFilter.AddIngredient(ingredient);
            }
            return this.ingredientFilter;
        }
        public AllergyFilter GetAllergyFilter()
        {
            this.allergyFilter = new AllergyFilter();
            foreach (Allergy allergy in this.guest.Allergies)
            {
                this.allergyFilter.AddAllergy(allergy);
            }
            return allergyFilter;
        }
    }
}