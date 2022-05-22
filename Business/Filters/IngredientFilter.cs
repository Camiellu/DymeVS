using System.Collections.Generic;
using Business.Models;

namespace Business.Filter
{
    public class IngredientFilter : IFilterPossibility
    {
        private List<Ingredient> ingredients;

        public IngredientFilter(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public bool Filter(Dish dish)
        {

            foreach (var i in dish.Ingredients)
            {
                foreach (var ingredient in this.ingredients)
                {
                    if (i == ingredient)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}