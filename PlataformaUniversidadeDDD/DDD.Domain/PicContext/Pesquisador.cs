using DDD.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.PicContext
{
    public enum TitulacaoEnum
    {
        MESTRE,
        DOUTOR,
        POS_GRADUADO
    }
    public  class Pesquisador : User
    {
        public TitulacaoEnum Titulacao { get; set; }
        public List<Projeto> Projetos { get; set; }
    }
}
