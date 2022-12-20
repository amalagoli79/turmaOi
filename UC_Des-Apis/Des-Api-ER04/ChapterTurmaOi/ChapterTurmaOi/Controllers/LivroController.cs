using ChapterTurmaOi.Models;
using ChapterTurmaOi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChapterTurmaOi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }


        [HttpGet]

        public IActionResult ler()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {


            try
            {

                Livro livroBuscado = _livroRepository.BuscarPorId(id);

                if (livroBuscado == null)
                {
                    return NotFound("Não encontrado");
                }

                return Ok(livroBuscado);
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [Authorize(Roles ="1")]
        [HttpPost]
        public IActionResult Cadastrar(Livro l)
        {
            try
            {
                _livroRepository.Cadastro(l);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);
                return Ok("Livro Removido com sucesso");
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Aterar(int id, Livro l)
        {
            try
            {
                _livroRepository.Alterar (id, l);
                return StatusCode(204);
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //fim-12-12-22

        }

    }
}
