using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PizzaApp.Data;
using PizzaApp.Models;
using src.Controllers.Dtos;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaContext context;
        public PizzaController(PizzaContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<PizzaDto>> Post(PizzaDto pizzaDto)
        {
            var pizza = new Pizza()
            {
                Id = pizzaDto.Id,
                Size = pizzaDto.Size,
                Crust = pizzaDto.Crust,
                Cheese = pizzaDto.Cheese,
                Sauce = pizzaDto.Sauce,
                PizzaToppings = pizzaDto.Toppings.Select(t => new PizzaTopping()
                {
                    PizzaId = pizzaDto.Id,
                    ToppingId = t.Id
                })
                .ToList()
            };

            await context.AddAsync(pizza);
            await context.SaveChangesAsync();

            return Created()
        }
    }
}