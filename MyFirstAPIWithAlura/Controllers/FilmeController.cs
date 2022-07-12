using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPIWithAlura.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme(Filme filme)
        {
            filmes.Add(filme);
            System.Console.WriteLine(filme.Titulo);
        }
    }
}