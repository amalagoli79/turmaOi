

using ChapterTurmaOi.Contexts;
using ChapterTurmaOi.Models;

namespace ChapterTurmaOi.Repositories
{
    public class LivroRepository
    {
        private readonly Sqlcontext _context;
        public LivroRepository(Sqlcontext context)
        {
            _context = context;

        }

        public List<Livro> Listar()
        {

            return _context.Livros.ToList();
        }



    }
}
