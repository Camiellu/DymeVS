using System;
using System.Collections.Generic;
using Business.GetDiscount;

namespace Business.Models
{
    public class Order
    {
        private List<Dish> dishes;
        private double totalPrice;
        private double finalPrice;
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

        public double FinalPrice
        {
            get => finalPrice;
            set => finalPrice = value;
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


        public void CalculateDiscount(List<IGetDiscount> discountCalculators)
        {
            double totalDiscount = 0;
            foreach (var discountCalculator in discountCalculators)
            {
                totalDiscount += discountCalculator.GetDiscount();
            }
            Discount = totalDiscount;
            FinalPrice = TotalPrice - Discount;
        }
    }
}