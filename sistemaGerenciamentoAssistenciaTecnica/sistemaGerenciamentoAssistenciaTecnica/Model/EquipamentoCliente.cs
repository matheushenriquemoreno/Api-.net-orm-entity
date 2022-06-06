using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class EquipamentoCliente : EntidadeBase
    {
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Equipamento Equipamento { get; set; }
        public bool EhConfiguracaoPersonaliazada { get; set; }
        public virtual List<OrdemServico> OrdensServicos { get; set; }

    }
}
