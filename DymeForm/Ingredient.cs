namespace DymeForm
{
    public class Ingredient 
    {
        private string name;

        public Ingredient(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}