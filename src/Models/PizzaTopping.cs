using System;

namespace PizzaApp.Models
{
    public class PizzaTopping
    {
        public Guid PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        public Guid ToppingId { get; set; }
        public Topping Topping { get; set; }

    }
}