using DDD.Domain.PicContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;


namespace DDD.Infra.SQLServer.Repositories
{
    public class ProjetoRepositorySqlServer : IProjetoRepository
    {
        private readonly SqlContext _context;

        public ProjetoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Projeto InsertProjeto(Projeto projeto)
        {
            try
            {
                _context.Projetos.Add(projeto);
                _context.SaveChanges();

 
            }
            catch (Exception ex)
            {
                //log exception

            }

            return projeto;
        }
    }
}
