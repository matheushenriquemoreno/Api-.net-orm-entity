﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Model
{
    public class Pessoa : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }
    }
}
