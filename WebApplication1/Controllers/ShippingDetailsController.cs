using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Infrastructure;
using WebApplication1.Models.ViewModel;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Text.Json;
using Humanizer;

namespace WebApplication1.Controllers
{
    public class ShippingDetailsController: Controller
    {
        private readonly WebApplication1Context _context;

        public ShippingDetailsController(WebApplication1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.ShippingDetails.ToListAsync());
        }

        public async Task<IActionResult>Create ([Bind("Id,Name,Gender,Item,Quantity,size,Price,ImageFile")] ShippingDetails shippingDetails)
        {
            _context.Add(shippingDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
