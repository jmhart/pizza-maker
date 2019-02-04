using System;
using System.Collections.Generic;

namespace PizzaApp.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public List<PizzaTopping> PizzaToppings { get; set; }
    }
}