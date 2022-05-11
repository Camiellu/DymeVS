namespace DymeForm
{
    public class Ingredient : IFilterPossibility
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

        public bool Filter(IFilterPossibility i)
        {
            throw new System.NotImplementedException();
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}