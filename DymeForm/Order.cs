using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class Order
    {
        private List<Dish> dishes;
        private double totalPrice;
        private DateTime dateCreated;

        public Order(List<Dish> dishes, double totalPrice, DateTime dateCreated)
        {
            this.Dishes = dishes;
            this.TotalPrice = totalPrice;
            this.DateCreated = dateCreated;
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
    }
}