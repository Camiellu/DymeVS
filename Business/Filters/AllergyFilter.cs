using System.Collections.Generic;
using Business.Models;

namespace Business.Filter
{
    public class AllergyFilter : IFilterPossibility
    {
        private List<Allergy> allergies;

        public void AddAllergy(Allergy allergy)
        {
            this.allergies.Add(allergy);
        }

        public bool Filter(Dish dish)
        {

            foreach (var a in dish.Allergies)
            {
                foreach (var allergy in this.allergies)
                {
                    if (a == allergy)
                    {
                        return false;
                    }
                }
            }


            return true;
        }
    }
}