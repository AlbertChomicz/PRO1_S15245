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
    public class Order_AdditivesController : ControllerBase
    {




        private _2019SBDContext _context;

        public Order_AdditivesController(_2019SBDContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult get()
        {
            return Ok(_context.AchOrderAdditive.ToList());
        }


        [HttpGet("{id:int}")]
        public IActionResult getByOrderID(int id)
        {
            var pizzas = _context.AchOrderAdditive.Where(e => e.AchOrderIdOrder == id).ToList();
            if (pizzas == null)
            { return NotFound(); }
            return Ok(pizzas);

        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchOrderAdditive updated_item)
        {

            var item = _context.AchOrderAdditive.Count(e => e.IdOrderAddiive == item_id);
            

            if (item == 0)
            {
                return NotFound();
            }

            updated_item.IdOrderAddiive = item_id;
            _context.AchOrderAdditive.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

        }



        [HttpPost]
        public IActionResult Create(AchOrderAdditive newItem)
        {

            var newId = _context.AchOrderAdditive.OrderByDescending(i => i.IdOrderAddiive).FirstOrDefault().IdOrderAddiive + 1;
            newItem.IdOrderAddiive = newId;

            _context.AchOrderAdditive.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchOrderAdditive.FirstOrDefault(e => e.IdOrderAddiive == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchOrderAdditive.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }




        [HttpDelete("all/{order_id:int}")]
        public IActionResult DeleteAllbyorderID(int order_id)
        {
            var list = _context.AchOrderAdditive.Where(e => e.AchOrderIdOrder == order_id).ToList();


            if (list.Count() == 0)
            {
                return NotFound();
            }

            list.ForEach(e => _context.AchOrderAdditive.Remove(e));
            _context.SaveChanges();
            return Ok(list);

        }


    }
}