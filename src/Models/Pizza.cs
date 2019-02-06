using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Crust { get; set; }

        [Required]
        public string Cheese { get; set; }

        [Required]
        public string Sauce { get; set; }
        public List<PizzaTopping> PizzaToppings { get; set; }

    }
}