using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class GetDishDiscount : IGetDiscount
    {
        private List<Dish> dishes;

        public GetDishDiscount(List<Dish> dishes)
        {
            this.dishes = dishes;
        }

        public double GetDiscount(Guest guest)
        {
            double totalDiscount = 0;
            string guestFirstLetter = guest.FirstName.Substring(0, 1);
            foreach (var d in dishes)
            {
                if (d.Name.Substring(0, 1).ToUpper().Equals(guestFirstLetter.ToUpper()))
                {
                    totalDiscount += Math.Round((d.Price / 100) * 5, 2);
                }
            }

            return totalDiscount;
        }
    }
}