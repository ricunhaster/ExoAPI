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

        public ExoProjeto BuscarPorId(int id)
        {
            return _context.Projects.Find(id);
        }

        public void Cadastrar(ExoProjeto projeto)
        {
            _context.Add(projeto);

            _context.SaveChanges();
        }

        public void Atualizar(int id, ExoProjeto projeto)
        {
            ExoProjeto projetoBuscado = _context.Projects.Find(id);

            if (projetoBuscado != null)
            {
                projetoBuscado.Titulo =projeto.Titulo;
                projetoBuscado.Status = projeto.Status;
                projetoBuscado.Requisitos = projeto.Requisitos;
                projetoBuscado.DataInicio = projeto.DataInicio;
            }

            _context.Projects.Update(projetoBuscado);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            ExoProjeto projetoBuscado = _context.Projects.Find(id);

            _context.Projects.Remove(projetoBuscado);

            _context.SaveChanges();


        }


    }



}
