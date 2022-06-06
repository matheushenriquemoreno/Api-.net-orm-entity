using sistemaGerenciamentoAssistenciaTecnica.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class StatusOrdemServico : EntidadeBase
    {
        public int Id { get; set; }

        public  OrdemServicoStatus Status { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public virtual OrdemServico Ordem { get; set; }

    }
}
