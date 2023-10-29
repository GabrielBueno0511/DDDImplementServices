using DDD.Domain.PicContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class PesquisadorRepositorySqlServe : IPesquisadorRepository
    {
        private readonly SqlContext _context;

        public PesquisadorRepositorySqlServe(SqlContext context)
        {
            _context = context;
        }

        public Pesquisador GetPesquisadorById(int id)
        {
                return _context.Pesquisadores.Find(id);
        }

    }
}
