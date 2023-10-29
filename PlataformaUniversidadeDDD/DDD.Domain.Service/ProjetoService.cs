using DDD.Domain.PicContext;
using DDD.Infra.SQLServer.Interfaces;

namespace DDD.Domain.Service
{
    public class ProjetoService
    {

        readonly IPosGraduacaoRepository _posGraduacaoRepository;
        readonly IProjetoRepository _projetoRepository;
        readonly IPesquisadorRepository _pesquisadorRepository;

        public ProjetoService ( IPosGraduacaoRepository posGraduacaoRepository, IProjetoRepository projetoRepository
            , IPesquisadorRepository pesquisadorRepository)
        {
            posGraduacaoRepository = _posGraduacaoRepository;
            pesquisadorRepository = _pesquisadorRepository;
           projetoRepository = _projetoRepository;

        }

     
        public bool cadastrarProjeto(Projeto projeto, int idPesquisador)
        {
            try
            {
                if (projeto.AnosDuracao >= 1)
                {
                    var pesquisador = _pesquisadorRepository.GetPesquisadorById(idPesquisador);
                    if (pesquisador.Titulacao != TitulacaoEnum.POS_GRADUADO)
                    {
                        projeto = _projetoRepository.InsertProjeto(projeto);
                        if (projeto != null)
                        {
                            _posGraduacaoRepository.InsertPosGraduacao(projeto.ProjetoId, idPesquisador);
                        }
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                throw;
            }
           

        }


    }
}
