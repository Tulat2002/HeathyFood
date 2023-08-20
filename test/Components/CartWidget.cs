using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test.Infrastructure;
using test.Models;

namespace test.Components
{
    public class CartWidget : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
