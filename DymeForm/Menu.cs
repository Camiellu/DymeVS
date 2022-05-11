using System.Collections.Generic;

namespace DymeForm
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
    }
}