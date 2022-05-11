using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class Guest : IGetFirstLetter
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private List<Allergy> allergies;

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
            this.allergies = allergies;
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

        public bool TryAddAllergy(Allergy allergy)
        {
            foreach (var a in allergies)
            {
                if (a.Name.Equals(allergy.Name))
                {
                    return false;
                }
            }
            this.allergies.Add(allergy);
            return true;
        }

        public string GetFirstLetter()
        {
            return this.FirstName.Substring(0, 1);
        }
    }
}