using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class GetBirthdayDiscount : IGetDiscount
    {
        private Order order;
        private double discount;

        public GetBirthdayDiscount(Order order, double discount)
        {
            this.order = order;
            this.discount = discount;
        }

        public double GetDiscount()
        {
            double birthdayDiscount = 0;
            if (order.DateCreated.Day == order.Guest.DateOfBirth.Day &&
                order.DateCreated.Month == order.Guest.DateOfBirth.Month)
            {
                birthdayDiscount = (order.TotalPrice / 100) * discount;
            }

            return birthdayDiscount;
        }
    }
}