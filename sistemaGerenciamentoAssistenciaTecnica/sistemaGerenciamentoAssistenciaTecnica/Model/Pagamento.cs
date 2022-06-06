using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Pagamento : EntidadeBase
    {
        public int Id { get; set; }

        public string TipoDoPagamento { get; set; }

        public double ValorDoServico { get; set; }

        public virtual StatusPagamento Status { get; set; }

        public virtual OrdemServico OrdemServico { get; set; }
    }
}
