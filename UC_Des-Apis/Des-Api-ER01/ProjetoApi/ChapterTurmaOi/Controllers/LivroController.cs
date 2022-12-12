using ChapterTurmaOi.Models;
using ChapterTurmaOi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ChapterTurmaOi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                Livro LivroBuscado = _livroRepository.BuscarPorId(id);

                if (LivroBuscado == null)
                {
                    return NotFound();
                }

                return Ok(LivroBuscado);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Casdastrar(Livro l)
        {
            try
            {
                _livroRepository.Cadastrar(l);
                return StatusCode(201);
                //return Ok("Livro cadastrado com sucesso");
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _livroRepository.Deletar(id);
                return Ok("Livro removido com sucesso");
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]

        public IActionResult Altera(int id, Livro l)
        {

            try
            {
                _livroRepository.Alterar(id, l);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }

    }
}