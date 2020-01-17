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
    public class AdditiveController : ControllerBase
    {

        private _2019SBDContext _context;

        public AdditiveController(_2019SBDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getAdditives()
        {
            return Ok(_context.AchAdditive.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult getAdditive(int id)
        {
            var additive = _context.AchAdditive.FirstOrDefault(e => e.IdAdditive == id);

            if (additive == null)
            { return NotFound(); }

            return Ok(additive);

        }



        [HttpPost]
        public IActionResult Create(AchAdditive newItem)
        {

            var newId = _context.AchAdditive.OrderByDescending(i => i.IdAdditive).FirstOrDefault().IdAdditive + 1;
            newItem.IdAdditive = newId;


            _context.AchAdditive.Add(newItem);
            _context.SaveChanges();
            return StatusCode(201, newItem);
        }


        [HttpPut("{item_id:int}")]
        public IActionResult Update(int item_id, AchAdditive updated_item)
        {



            var item = _context.AchAdditive.Count(e => e.IdAdditive == item_id);

            if (item == 0)
            {
                return NotFound();
            }

            _context.AchAdditive.Attach(updated_item);
            _context.Entry(updated_item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(updated_item);

        }

        [HttpDelete("{item_id:int}")]
        public IActionResult Delete(int item_id)
        {

            var temp_item = _context.AchAdditive.FirstOrDefault(e => e.IdAdditive == item_id);

            if (temp_item == null)
            {
                return NotFound();
            }

            _context.AchAdditive.Remove(temp_item);
            _context.SaveChanges();
            return Ok(temp_item);
        }




    }
}