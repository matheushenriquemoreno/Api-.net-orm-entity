using sistemaGerenciamentoAssistenciaTecnica.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Tecnico : Pessoa
    {
        public string Sexo { get; set; }
        public StatusTecnico Status { get; set; }
        public List<Especialidades> Especialidades { get; set; }

        public List<OrdemServico> OrdensServicos { get; set; }

        public Tecnico()
        {
            Especialidades = new List<Especialidades>();
        }
    }
}
