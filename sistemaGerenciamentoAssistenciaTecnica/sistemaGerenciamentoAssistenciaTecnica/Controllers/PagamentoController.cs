using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistemaGerenciamentoAssistenciaTecnica.Model;
using sistemaGerenciamentoAssistenciaTecnica.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : BaseController<Pagamento>
    {
        public PagamentoController(IRepositoryBase<Pagamento> repositoryBase) : base(repositoryBase) { }
    }
}
