using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Workshops.Infrastructure;
using Workshops.Models;

namespace Workshops.Controllers;

public sealed class HomeController : Controller
{
    public async Task<IActionResult> Index([FromServices] DatabaseContext context)
    {
        var items = await context.Workshops.AsNoTracking().Select(x => new WorkshopViewModel(x.Name, x.Date)).ToListAsync();
        return View(items);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
