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
    public class ClienteController : BaseController<Cliente>
    {
        public ClienteController(IRepositoryBase<Cliente> repositoryBase) : base(repositoryBase) { }
    }
}
