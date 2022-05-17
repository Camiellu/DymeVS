using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class GetNameDiscount : IGetDiscount
    {
        private Order order;
        private int nameDiscountPercentage;

        public GetNameDiscount(Order order, int nameDiscountPercentage)
        {
            this.order = order;
            this.nameDiscountPercentage = nameDiscountPercentage;
        }

        public double GetDiscount()
        {
            double totalDiscount = 0;
            string guestFirstLetter = order.Guest.FirstName.Substring(0, 1);
            foreach (var d in order.Dishes)
            {
                if (d.Name.Substring(0, 1).ToUpper().Equals(guestFirstLetter.ToUpper()))
                {
                    totalDiscount += (d.Price / 100) * nameDiscountPercentage;
                }
            }

            return totalDiscount;
        }
    }
}