namespace DymeForm
{
    public class Menu
    {
        private string name;
        //private List<Dish> dishes;

        public Menu(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}