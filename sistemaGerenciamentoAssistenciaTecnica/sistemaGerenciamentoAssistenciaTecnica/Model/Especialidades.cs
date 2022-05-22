using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Especialidades
    {
        [Key]
        public int Id { get; set; }

        public string NomeEspecialidade { get; set; }

        public string Descricao { get; set; }

        public List<Tecnico> TecnicosEspecialidade {get; set;}

        public Especialidades()
        {
            TecnicosEspecialidade = new List<Tecnico>();
        }
    }
}
