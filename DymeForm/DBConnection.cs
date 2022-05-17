using System;
using System.Collections.Generic;


namespace DymeForm
{
    public class DBConnection
    {

        public Restaurant GetRestaurant()
        {

            // Dummy ingredients
            Ingredient kip = new Ingredient("Kip");
            Ingredient vis = new Ingredient("Vis");
            Ingredient rund = new Ingredient("Rund");
            Ingredient varken = new Ingredient("Varken");
            Ingredient ui = new Ingredient("Ui");
            Ingredient knoflook = new Ingredient("Knoflook");
            Ingredient koriander = new Ingredient("Koriander");
            Ingredient rijst = new Ingredient("Rijst");
            Ingredient aardappel = new Ingredient("Aardappel");
            Ingredient melk = new Ingredient("Melk");

            // Dummy allergies
            Allergy gluten = new Allergy("Gluten");
            Allergy lactose = new Allergy("Lactose");
            Allergy schaal = new Allergy("Schaal/schelpdieren");
            Allergy noten = new Allergy("Noten");
            Allergy ei = new Allergy("Ei");
            Allergy soja = new Allergy("Soja");

            // Dummy Dishes
            Dish carpaccio = new Dish("Carpaccio", 12.50, "Carpaccio met truffel, parmezaan en pijnboompit", new List<Allergy> { lactose }, new List<Ingredient> { rund, knoflook });
            Dish tomatensoep = new Dish("Tomatensoep", 6.50, "Tomatensoep met ballen", new List<Allergy> { lactose }, new List<Ingredient> { varken, ui });
            Dish sate = new Dish("Saté", 17.00, "Kipsaté met satésaus, kroepoek, rijst en atjar", new List<Allergy> { schaal, noten }, new List<Ingredient> { kip, ui, knoflook, rijst });
            Dish zalm = new Dish("Zalm", 21.50, "Zalmfilet met witte asperges, hollandaise en krieltjes", new List<Allergy> { ei }, new List<Ingredient> { vis, ui, aardappel });
            Dish burger = new Dish("Dymeburger", 18.50, "Indische burger van rund met rendang en cheddar", new List<Allergy> { gluten, soja }, new List<Ingredient> { koriander, rund });
            Dish dame = new Dish("Dame Blanche", 8.00, "Vanille ijs met slagroom en chocoladesaus", new List<Allergy> { lactose }, new List<Ingredient> { melk });
            Dish kaasplank = new Dish("Kaasplankje", 11.25, "4 soorten kaas met appelstroop en noten", new List<Allergy> { lactose, noten }, new List<Ingredient> { melk });

            // Dummy menus
            Menu voor = new Menu("Voorgerechten", new List<Dish> { carpaccio, tomatensoep });
            Menu hoofd = new Menu("Hoofdgerechten", new List<Dish> { sate, zalm, burger });
            Menu dessert = new Menu("Desserts", new List<Dish> { dame, kaasplank });

            // Dummy Guests
            Guest guest1 = new Guest("Marco", "Meulenbroeks", new DateTime(1990 - 11 - 11), new List<Allergy> { gluten });
            Guest guest2 = new Guest("John", "Wijnen", new DateTime(1990 - 11 - 11));
            Guest guest3 = new Guest("René", "de Louw", new DateTime(1990 - 11 - 11), new List<Allergy> { schaal });


            List<Menu> menus = new List<Menu> { voor, hoofd, dessert };
            List<Guest> guests = new List<Guest> { guest1, guest2, guest3 };
            int discount = 5;
            Restaurant restaurant = new Restaurant("Dyme", guests, menus, discount);
            return restaurant;
        }

        public List<Ingredient> GetIngredients()
        {
            Ingredient kip = new Ingredient("Kip");
            Ingredient vis = new Ingredient("Vis");
            Ingredient rund = new Ingredient("Rund");
            Ingredient varken = new Ingredient("Varken");
            Ingredient ui = new Ingredient("Ui");
            Ingredient knoflook = new Ingredient("Knoflook");
            Ingredient koriander = new Ingredient("Koriander");
            Ingredient rijst = new Ingredient("Rijst");
            Ingredient aardappel = new Ingredient("Aardappel");
            Ingredient melk = new Ingredient("Melk");
            List<Ingredient> ingredients = new List<Ingredient>
                {kip, vis, rund, varken, ui, knoflook, koriander, rijst, aardappel, melk};
            return ingredients;
        }
        //public List<Dish> GetDishes()
        //{
        //    List<Dish> dishes = new List<Dish> { carpaccio, tomatensoep, sate, zalm, burger, dame, kaasplank };
        //    return dishes;
        //}

        public List<Allergy> GetAllergies()
        {
            Allergy gluten = new Allergy("Gluten");
            Allergy lactose = new Allergy("Lactose");
            Allergy schaal = new Allergy("Schaal/schelpdieren");
            Allergy noten = new Allergy("Noten");
            Allergy ei = new Allergy("Ei");
            Allergy soja = new Allergy("Soja");
            List<Allergy> allergies = new List<Allergy> { gluten, lactose, schaal, noten, ei, soja };
            return allergies;
        }

    }
}