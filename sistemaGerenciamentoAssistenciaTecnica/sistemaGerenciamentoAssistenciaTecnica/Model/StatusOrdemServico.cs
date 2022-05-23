using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class StatusOrdemServico
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }
        public OrdemServico Ordem { get; set; }

    }
}
