using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class OrdemServico : EntidadeBase
    {
        public int Id { get; set; }
        public virtual Tecnico Tecnico { get; set; }
        public virtual EquipamentoCliente EquipamentoCliente { get; set; }
        public virtual StatusOrdemServico StatusDaOrdem { get; set; }
        public virtual Pagamento PagementoOrdem { get; set; }
        public string DefeitoApresentado { get; set; }
        public string DescricaoServico { get; set; }
        public bool FoiPrecisoInstalarPecas { get; set; }

    }
}
