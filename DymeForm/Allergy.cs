using System.Collections.Generic;

namespace DymeForm
{
    public class Allergy
    {
        private string name;
        private List<Ingredient> ingredients;

        public Allergy(string name, List<Ingredient> ingredients)
        {
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Ingredient> Ingredients
        {
            get => ingredients;
            set => ingredients = value;
        }
    }
}