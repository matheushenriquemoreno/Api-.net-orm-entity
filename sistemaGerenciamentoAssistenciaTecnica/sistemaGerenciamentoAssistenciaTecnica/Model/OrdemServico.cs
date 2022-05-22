using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class OrdemServico
    {

        public string Id { get; set; }

        public int IdTecnico {get; set;}
        public Tecnico Tecnico { get; set; }
        public int IdEquipamentoCliente { get; set; }
        public EquipamentoCliente EquipamentoCliente { get; set; }



    }
}
