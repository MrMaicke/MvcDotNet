using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroMvc.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
