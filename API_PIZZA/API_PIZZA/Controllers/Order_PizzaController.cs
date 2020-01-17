using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_PIZZA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PIZZA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Order_PizzaController : ControllerBase
    {



        private _2019SBDContext _context;

        public Order_PizzaController(_2019SBDContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult get()
        {
            return Ok(_context.AchOrderPizza.ToList());
        }


        [HttpGet("{id:int}")]
        public IActionResult getByOrderID(int id)
        {
            var pizzas = _context.AchOrderPizza.Where(e => e.AchOrderIdOrder == id).ToList();
            if (pizzas == null)
            { return NotFound(); }
            return Ok(pizzas);

        }

        [HttpPost]
        public IActionResult Create(AchOrderPizza newItem)
        {

            var newId = _context.AchOrderPizza.OrderByDescending(i => i.IdOrderPizza).FirstOrDefault().IdOrderPizza + 1;
            newItem.IdOrderPizza = newId;

            _context.AchOrderPizza.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchPizzaComposition.FirstOrDefault(e => e.PizzaCompositionId == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchPizzaComposition.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }




        [HttpDelete("all/{pizza_id:int}")]
        public IActionResult DeleteAll(int pizza_id)
        {
            var list = _context.AchPizzaComposition.Where(e => e.AchPizzaIdPizza == pizza_id).ToList();


            if (list.Count() == 0)
            {
                return NotFound();
            }

            list.ForEach(e => _context.AchPizzaComposition.Remove(e));
            _context.SaveChanges();
            return Ok(list);

        }



    }
}