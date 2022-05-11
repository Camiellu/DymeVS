namespace DymeForm
{
    public class Dish : IGetFirstLetter
    {
        private string name;
        private double price;
        private string description;
        // private List<Allergy> allergies;
        // private List<Ingredient> ingredients;

        public Dish(string name, double price, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
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

        public string GetFirstLetter()
        {
            return this.Name.Substring(0, 1);
        }
    }
}