using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MeuPrimeiroMvc.Controllers
{
    [Route("[controller]")]
    public class EquipeController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}