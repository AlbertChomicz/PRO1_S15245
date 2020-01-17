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
    public class Pizza_CompositionController : ControllerBase
    {

        private _2019SBDContext _context;

        public Pizza_CompositionController(_2019SBDContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public IActionResult getPizzas_Composition()
        {
            return Ok(_context.AchPizzaComposition.ToList());
        }




        [HttpGet("{pizza_id:int}")]
        public IActionResult getPizzas_Composition(int pizza_id)
        {

            var pizzas_composition = _context.AchPizzaComposition.Where(e => e.AchPizzaIdPizza == pizza_id).ToList();


            if (pizzas_composition == null)
            { return NotFound(); }

            return Ok(pizzas_composition);

        }


        [HttpPost]
        public IActionResult Create(AchPizzaComposition newItem)
        {
            var newId = _context.AchPizzaComposition.OrderByDescending(i => i.PizzaCompositionId).FirstOrDefault().PizzaCompositionId + 1;
            newItem.PizzaCompositionId = newId;


            _context.AchPizzaComposition.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchPizzaComposition updated_item)
        {

            if (_context.AchPizzaComposition.Count(e => e.PizzaCompositionId == item_id) == 0)
            {
                return NotFound();
            }

            _context.AchPizzaComposition.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

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