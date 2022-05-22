using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class EquipamentoCliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdEquipamento { get; set; }
        public Equipamento Equipamento { get; set; }
        public bool EhConfiguracaoPersonaliazada { get; set; }
        public List<OrdemServico> OrdensServicos { get; set; }

    }
}
