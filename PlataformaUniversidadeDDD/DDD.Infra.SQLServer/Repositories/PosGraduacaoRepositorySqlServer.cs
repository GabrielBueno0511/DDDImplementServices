using DDD.Domain.PicContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class PosGraduacaoRepositorySqlServer : IPosGraduacaoRepository
    {
        private readonly SqlContext _context;

        public PosGraduacaoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public PosGraduacao InsertPosGraduacao(int ProjetoId, int idPesquisador)
        {
 
            var posGraduacao = new PosGraduacao
            {
                pesquisadorID = idPesquisador,
                ProjetoId = ProjetoId
            };

            try
            {

                _context.PosGraduacoes.Add(posGraduacao);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                var msg = ex.InnerException;
                throw;
            }

            return posGraduacao;
        }
    }
}
