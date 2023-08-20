using Microsoft.AspNetCore.Mvc;
using test.Data;

namespace test.Components
{
    public class JustArrived : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public JustArrived(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View( _context.Products.Where(p=> p.IsArrived==true).ToList());
        }
    }
}
