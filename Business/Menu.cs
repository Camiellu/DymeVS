using System.Collections.Generic;
using Business.Filter;

namespace Business
{
    public class Menu
    {
        private string name;
        private List<Dish> dishes;

        public Menu(string name, List<Dish> dishes)
        {
            this.Name = name;
            this.Dishes = dishes;
        }

        public override string ToString()
        {
            return this.name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Dish> Dishes
        {
            get => dishes;
            set => dishes = value;
        }

        /*
         * Checks dishes in menu if they contain filtered item, returns filtered list
         */
        public List<Dish> FilterDishes(List<IFilterPossibility> filters)
        {
            List<Dish> filterDishes = new List<Dish>();

            foreach (var dish in Dishes)
            {
                bool addDish = true;
                foreach (var filter in filters)
                {
                    addDish = addDish && filter.Filter(dish);
                }
                if (addDish)
                {
                    filterDishes.Add(dish);
                }
            }
            return filterDishes;
        }
    }
}