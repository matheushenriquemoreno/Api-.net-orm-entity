using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemaGerenciamentoAssistenciaTecnica;
using sistemaGerenciamentoAssistenciaTecnica.Model.Enums;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class StatusPagamento : EntidadeBase
    {
        public int Id { get; set; }

        public virtual Pagamento Pagamento { get; set; }

        public DateTime DataPagamento { get; set; }

        public PagamentoStatus Status { get; set; }
    }
}
