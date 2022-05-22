using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Cliente : Pessoa
    {
        public string Email { get; set; }

        public List<EquipamentoCliente> Equipamentos { get; set; }





    }
}
