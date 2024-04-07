using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsletterWebApi.Context;
using NewsletterWebApi.Model;
using NewsletterWebApi.Result;

namespace NewsletterWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewsletterDb _context;

        public NewsController(NewsletterDb context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _context.Newsletters.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _context.Newsletters.FindAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Newsletter newslatter)
        {
            newslatter.CreatedDate = DateTime.Now;
            await _context.Newsletters.AddAsync(newslatter);
            await _context.SaveChangesAsync();
            var result = new ResultModel()
            {
                Message = "Newslatter added is succesful"
            };
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Newsletter newslatter)
        {
            _context.Newsletters.Update(newslatter);
            await _context.SaveChangesAsync();

            var result = new ResultModel()
            {
                Message = "Newslatter updated is succesful"
            };
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.Newsletters.FindAsync(id);
            _context.Newsletters.Remove(result);
            await _context.SaveChangesAsync();

            var resultModel = new ResultModel()
            {
                Message = "Newslatter deleted is succesful"
            };
            return Ok(resultModel);
        }
    }
}
