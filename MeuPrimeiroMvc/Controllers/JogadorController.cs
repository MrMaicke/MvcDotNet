using Microsoft.AspNetCore.Mvc;
using MeuPrimeiroMvc.Contexts;
using MeuPrimeiroMvc.Models;

namespace MeuPrimeiroMvc.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        // Criando uma referência (instância) sobre a comunicação do meu banco de dados
        ProjetoTesteContext _context = new();
 
        public IActionResult Index()
        {
            var listaJogadores = _context.Jogadors.ToList();
 
            // Passar a tela (em forma de memoria) os dados das Jogadores cadastradas
            ViewBag.listaJogadores = listaJogadores;
 
            return View();
        }
 
        [Route("cadastrar")]
        public IActionResult CadastroJogador(Jogador Jogador)
        {
            _context.AddAsync(Jogador);
            //registrear alteracoes no banco de daods
           
            _context.SaveChanges();
 
            return RedirectToAction("Index");
        }
    }
}