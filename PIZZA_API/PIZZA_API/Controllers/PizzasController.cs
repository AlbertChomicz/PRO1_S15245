using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIZZA_API.Models;

namespace PIZZA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {

        private _2019SBDContext _context;

        public PizzasController(_2019SBDContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult getPizzas()
        {
            return Ok(_context.AchPizza.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult getPizza(int id)
        {
            var pizza = _context.AchPizza.FirstOrDefault(e => e.IdPizza == id);

            if(pizza == null)
            { return NotFound(); }

            return Ok(pizza);

        }
    }
}