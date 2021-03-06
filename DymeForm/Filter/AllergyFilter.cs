using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class AllergyFilter : IFilterPossibility
    {
        private List<Allergy> allergies;

        public AllergyFilter(List<Allergy> allergies)
        {
            this.allergies = allergies;
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