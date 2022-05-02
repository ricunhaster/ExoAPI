using ExoAPI.WebAPI.Contexts;
using ExoAPI.WebAPI.Models;

namespace ExoAPI.WebAPI.Repositories
{
    public class ExoRepository
    {
        private readonly ExoContexts _context;

        public ExoRepository(ExoContexts contexts)
        {
            _context = contexts;
        }

        public List<ExoProjeto> Listar()
        {
            return _context.Projects.ToList();
        }
    }

}
