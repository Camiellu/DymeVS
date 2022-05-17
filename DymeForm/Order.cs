using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class Order
    {
        private List<Dish> dishes;
        private double totalPrice;
        private double endPrice;
        private double discount;
        private DateTime dateCreated;
        private Guest guest;

        public Order(List<Dish> dishes, double totalPrice, DateTime dateCreated, Guest guest)
        {
            this.Dishes = dishes;
            this.TotalPrice = totalPrice;
            this.DateCreated = dateCreated;
            this.guest = guest;
        }

        public List<Dish> Dishes
        {
            get => dishes;
            set => dishes = value;
        }

        public double TotalPrice
        {
            get => totalPrice;
            set => totalPrice = value;
        }

        public DateTime DateCreated
        {
            get => dateCreated;
            set => dateCreated = value;
        }

        public double EndPrice
        {
            get => endPrice;
            set => endPrice = value;
        }

        public double Discount
        {
            get => discount;
            set => discount = value;
        }

        public Guest Guest
        {
            get => guest;
            set => guest = value;
        }


        public void CalculateDiscount(IGetDiscount discountCalculator)
        {
            Discount = discountCalculator.GetDiscount(Guest);
            EndPrice = TotalPrice - Discount;
        }
    }
}