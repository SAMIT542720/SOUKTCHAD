using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOUKTCHAD.Data;
using SOUKTCHAD.Data.Services;
using SOUKTCHAD.Models;

namespace SOUKTCHAD.Controllers
{
    public class PRODUCTController : Controller
    {
        private readonly IPRODUCTSERVICESe _service;
        private readonly AppDbContext _context;
        public PRODUCTController(IPRODUCTSERVICESe service)
        {
            _service = service;
        }
        public PRODUCTController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? catigoryID)
        {
            IQueryable<PRODUCT> products =  _context.PRODUCTS.Include(P => P.CATIGORYID);
            if (catigoryID.HasValue)
            {
                products = products.Where(P=> P.CATIGORYID == catigoryID);
            }
            var productlist = await products.ToListAsync();
            return View(productlist);
        }

    }
}
