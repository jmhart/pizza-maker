using Microsoft.AspNetCore.Mvc;
using PizzaApp.Data;
using PizzaApp.Models;

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

        public ActionResult<Topping> Post(Topping topping)
        {
            context.Add(topping);
            context.SaveChanges();

            return Ok();
        }
    }
}