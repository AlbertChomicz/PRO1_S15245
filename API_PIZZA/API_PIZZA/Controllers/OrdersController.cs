using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class OrdersController : ControllerBase
    {

        private _2019SBDContext _context;

        public OrdersController(_2019SBDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getOrders()
        {
            return Ok(_context.AchOrder.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult getOrders(int id)
        {
            var order = _context.AchOrder.FirstOrDefault(e => e.IdOrder == id);

            if (order == null)
            { return NotFound(); }

            return Ok(order);
        }



        [HttpPost]
        public IActionResult Create(AchOrder newItem)
        {


            var newId = _context.AchOrder.OrderByDescending(i => i.IdOrder).FirstOrDefault().IdOrder + 1;
            newItem.IdOrder = newId;


            _context.AchOrder.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchOrder updated_item)
        {



            var item = _context.AchOrder.Count(e => e.IdOrder == item_id);

            if (item == 0)
            {
                return NotFound();
            }

            _context.AchOrder.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

        }

        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchOrder.FirstOrDefault(e => e.IdOrder == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchOrder.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }


    }
}