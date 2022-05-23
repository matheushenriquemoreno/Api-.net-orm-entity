using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class OrdemServico
    {

        public string Id { get; set; }
        public Tecnico Tecnico { get; set; }
        public EquipamentoCliente EquipamentoCliente { get; set; }
        public StatusOrdemServico StatusDaOrdem { get; set; }
        public string DefeitoApresentado { get; set; }
        public string DescricaoServico { get; set; }
        public bool FoiPrecisoInstalarPecas { get; set; }

    }
}
