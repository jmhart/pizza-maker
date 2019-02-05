using System.Collections.Generic;
using System.Linq;
using PizzaApp.Models;

namespace src.Controllers.Dtos
{
    public class PizzaDto
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }
        public IEnumerable<ToppingDto> Toppings { get; set; }

    }

}