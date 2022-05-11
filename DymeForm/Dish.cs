using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class Dish : IGetFirstLetter 
    {
        private string name;
        private double price;
        private string description;
        private List<Allergy> allergies;
        private List<Ingredient> ingredients;

        public Dish(string name, double price, string description, List<Allergy> allergies, List<Ingredient> ingredients)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Allergies = allergies;
            this.Ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"- {Name} | {Math.Round(this.price, 2)}";
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public List<Allergy> Allergies
        {
            get => allergies;
            set => allergies = value;
        }

        public List<Ingredient> Ingredients
        {
            get => ingredients;
            set => ingredients = value;
        }


        public string GetFirstLetter()
        {
            return this.Name.Substring(0, 1);
        }
        public bool TryAddAllergy(Allergy allergy)
        {
            foreach (var a in Allergies)
            {
                if (a.Name.Equals(allergy.Name))
                {
                    return false;
                }
            }
            this.Allergies.Add(allergy);
            return true;
        }
        public bool TryAddIngredient(Ingredient ingredient)
        {
            foreach (var a in Allergies)
            {
                if (a.Name.Equals(ingredient.Name))
                {
                    return false;
                }
            }
            this.Ingredients.Add(ingredient);
            return true;
        }
    }
}