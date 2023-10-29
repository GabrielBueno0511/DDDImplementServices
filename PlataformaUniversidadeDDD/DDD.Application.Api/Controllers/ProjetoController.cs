using DDD.Application.Service;
using DDD.Domain.PicContext;
using DDD.Domain.SecretariaContext;
using DDD.Domain.Service;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase 
    {
        readonly ApplicationServiceProjeto _projetoService;

        public ProjetoController(ApplicationServiceProjeto applicationProjetoService)
        {
            _projetoService = applicationProjetoService;
        }


        [HttpPost]
        [Route("criarProjeto")]
        public void CreateProjeto( Projeto projeto,  int idPesquisador)
        {
           _projetoService.GerarProjeto(projeto, idPesquisador);

        }
    }



}
