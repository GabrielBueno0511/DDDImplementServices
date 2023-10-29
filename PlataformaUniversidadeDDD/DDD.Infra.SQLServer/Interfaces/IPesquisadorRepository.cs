using DDD.Domain.PicContext;


namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IPesquisadorRepository
    {
        public Pesquisador GetPesquisadorById(int id);
    }

}
