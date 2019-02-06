using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PizzaDto>> Get(int id)
        {
            var pizza = await context.Pizzas
                .Include(p => p.PizzaToppings)
                    .ThenInclude(pt => pt.Topping)
                .Select(p => new PizzaDto()
                {
                    Id = p.Id,
                    Size = p.Size,
                    Crust = p.Crust,
                    Cheese = p.Cheese,
                    Sauce = p.Sauce,
                    Toppings = p.PizzaToppings.Select(pt => new ToppingDto()
                    {
                        Id = pt.ToppingId,
                        Name = pt.Topping.Name,
                        Category = pt.Topping.Category
                    })
                })
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        [HttpGet]
        public async Task<ActionResult<List<PizzaDto>>> Get()
        {
            var pizzas = await context.Pizzas
                .Include(p => p.PizzaToppings)
                    .ThenInclude(pt => pt.Topping)
                .Select(p => new PizzaDto()
                {
                    Id = p.Id,
                    Size = p.Size,
                    Crust = p.Crust,
                    Cheese = p.Cheese,
                    Sauce = p.Sauce,
                    Toppings = p.PizzaToppings.Select(pt => new ToppingDto()
                    {
                        Id = pt.Topping.Id,
                        Name = pt.Topping.Name,
                        Category = pt.Topping.Category
                    })
                })
                .ToListAsync();

            return pizzas;
        }

        [HttpPost]
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
                }).ToList()
            };

            await context.AddAsync(pizza);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}