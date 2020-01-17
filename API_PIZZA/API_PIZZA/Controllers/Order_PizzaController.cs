using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_PIZZA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchOrderPizza updated_item)
        {

            var item = _context.AchOrderPizza.Count(e => e.IdOrderPizza == item_id);
            updated_item.IdOrderPizza = item_id;

            if (item == 0)
            {
                return NotFound();
            }

            _context.AchOrderPizza.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);
        }



        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchOrderPizza.FirstOrDefault(e => e.IdOrderPizza == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchOrderPizza.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }




        [HttpDelete("all/{order_id:int}")]
        public IActionResult DeleteAllbyorderID (int order_id)
        {
            var list = _context.AchOrderPizza.Where(e => e.AchOrderIdOrder == order_id).ToList();


            if (list.Count() == 0)
            {
                return NotFound();
            }

            list.ForEach(e => _context.AchOrderPizza.Remove(e));
            _context.SaveChanges();
            return Ok(list);

        }



    }
}