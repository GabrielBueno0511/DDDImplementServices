﻿using DDD.Domain.PicContext;
using DDD.Domain.SecretariaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IPosGraduacaoRepository
    {
        public PosGraduacao InsertPosGraduacao(int idProjeto, int idPesquisador);
    }
}
