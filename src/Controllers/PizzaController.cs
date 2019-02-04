using Microsoft.AspNetCore.Mvc;
using PizzaApp.Data;
using PizzaApp.Models;

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

        public ActionResult<Pizza> Post(Pizza pizza)
        {
            context.Add(pizza);
            context.SaveChanges();
            return Ok();
        }
    }
}