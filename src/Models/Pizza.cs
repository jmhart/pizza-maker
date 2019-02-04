using System;
using System.Collections.Generic;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }
        public List<PizzaTopping> PizzaToppings { get; set; }

    }
}