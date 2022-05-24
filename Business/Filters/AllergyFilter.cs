﻿using System.Collections.Generic;
using Business.Models;

namespace Business.Filters
{
    public class AllergyFilter : IFilterPossibility
    {
        private List<Allergy> allergies;

        public AllergyFilter(List<Allergy> allergies)
        {
            this.allergies = allergies;
        }

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