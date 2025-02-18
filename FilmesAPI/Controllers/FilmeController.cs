using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {
        private static List<Filme> filmes = new();

        [HttpPost]
        public void PostFilme(Filme filme)
        {
            filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filme> GetFilme()
        {
            return filmes;
        }
    }
}
