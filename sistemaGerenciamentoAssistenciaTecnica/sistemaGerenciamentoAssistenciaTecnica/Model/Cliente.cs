using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Cliente : Pessoa
    {
        public string Email { get; set; }

        public virtual List<EquipamentoCliente> Equipamentos { get; set; }

        public Cliente()
        {
            Equipamentos = new List<EquipamentoCliente>();
        }
    }
}
