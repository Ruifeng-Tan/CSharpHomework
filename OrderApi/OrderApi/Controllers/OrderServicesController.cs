using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderServicesController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrderServicesController(OrderContext context)
        {
            _context = context;
        }

        // GET: api/OrderServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderService>>> GetOrderService()
        {
            return await _context.OrderServices.ToListAsync();
        }

        // GET: api/OrderServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderService>> GetOrderService(int id)
        {
            var orderService = await _context.OrderServices.FindAsync(id);

            if (orderService == null)
            {
                return NotFound();
            }

            return orderService;
        }

        // PUT: api/OrderServices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderService(int id, OrderService orderService)
        {
            if (id != orderService.OrderServiceID)
            {
                return BadRequest();
            }

            _context.Entry(orderService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderServiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderServices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OrderService>> PostOrderService(OrderService orderService)
        {
            _context.OrderServices.Add(orderService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderService", new { id = orderService.OrderServiceID }, orderService);
        }

        // DELETE: api/OrderServices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderService>> DeleteOrderService(int id)
        {
            var orderService = await _context.OrderServices.FindAsync(id);
            if (orderService == null)
            {
                return NotFound();
            }

            _context.OrderServices.Remove(orderService);
            await _context.SaveChangesAsync();

            return orderService;
        }

        private bool OrderServiceExists(int id)
        {
            return _context.OrderServices.Any(e => e.OrderServiceID == id);
        }
    }
}
