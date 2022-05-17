using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class Guest
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private List<Allergy> allergies;
        private List<Order> orders;

        public Guest(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }
        public Guest(string firstName, string lastName, DateTime dateOfBirth, List<Allergy> allergies)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Allergies = allergies;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        public List<Allergy> Allergies
        {
            get => allergies;
            set => allergies = value;
        }

        public List<Order> Orders
        {
            get => orders;
            set => orders = value;
        }

        public bool AddOrder(Order order)
        {
            Orders.Add(order);
            return true;
        }
        public bool TryAddAllergy(Allergy allergy)
        {
            if (Allergies.Any(a => a.Name.Equals(allergy.Name)))
            {
                return false;
            }
            this.Allergies.Add(allergy);
            return true;
        }
    }
}