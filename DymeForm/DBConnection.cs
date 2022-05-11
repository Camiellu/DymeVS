using System;
using System.Collections.Generic;

namespace DymeForm
{
    public class DBConnection
    {
        public Restaurant Restaurant()
        {
            Restaurant restaurant = new Restaurant("JoMaRe", Guests());
            return restaurant;
        }

        public List<Guest> Guests()
        {
            Guest guest1 = new Guest("Marco", "Meulenbroeks", new DateTime(11-11-1990));
            Guest guest2 = new Guest("John", "Wijnen", new DateTime(11 - 11 - 1990));
            Guest guest3 = new Guest("René", "de Louw", new DateTime(11 - 11 - 1990));
            List<Guest> guests = new List<Guest> {guest1};
            return guests;
        }

        public List<>
    }
}