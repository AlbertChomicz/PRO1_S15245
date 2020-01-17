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
    public class IngredientsController : ControllerBase
    {

        private _2019SBDContext _context;

        public IngredientsController(_2019SBDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getIngredients()
        {
            return Ok(_context.AchIngredient.ToList());
        }

        [HttpGet("{item_id:int}")]
        public IActionResult getIngredient(int item_id)
        {
            var ingredient = _context.AchIngredient.FirstOrDefault(e => e.IdIngredient == item_id);

            if (ingredient == null)
            { return NotFound(); }

            return Ok(ingredient);


        }


        [HttpPost]
        public IActionResult Create(AchIngredient newItem)
        {
        
           var newId = _context.AchIngredient.OrderByDescending(i => i.IdIngredient).FirstOrDefault().IdIngredient +1;
            newItem.IdIngredient = newId;

            _context.AchIngredient.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchIngredient updated_item)
        {

            if (_context.AchIngredient.Count(e => e.IdIngredient == item_id) == 0)
            {
                return NotFound();
            }

            _context.AchIngredient.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

        }

        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchIngredient.FirstOrDefault(e => e.IdIngredient == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchIngredient.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }




    }
}