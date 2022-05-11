namespace DymeForm
{
    public class Ingredient
    {
        private string name;
        private Allergy allergy;

        public Ingredient(string name, Allergy allergy)
        {
            this.Name = name;
            this.Allergy1 = allergy;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Allergy Allergy1
        {
            get => allergy;
            set => allergy = value;
        }
    }
}