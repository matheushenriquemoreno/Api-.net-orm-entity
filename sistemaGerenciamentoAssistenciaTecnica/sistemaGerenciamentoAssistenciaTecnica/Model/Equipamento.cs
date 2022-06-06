using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Equipamento : EntidadeBase 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhEquipamentoPersonalizado { get; set; }

        public virtual List<EquipamentoCliente> Clientes { get; set; }
    }
}
