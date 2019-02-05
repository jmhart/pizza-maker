using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Data;
using PizzaApp.Models;
using src.Controllers.Dtos;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private readonly PizzaContext context;
        public ToppingsController(PizzaContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public ActionResult<Topping> Post(Topping topping)
        {
            context.Add(topping);
            context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ToppingDto>> Get()
        {
            return context.Toppings.Select(t => new ToppingDto()
            {
                Id = t.Id,
                Name = t.Name,
                Category = t.Category
            })
            .ToList();
        }
    }
}