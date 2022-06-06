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
    public abstract class BaseController<T>  : ControllerBase where T : EntidadeBase
    {

        private readonly IRepositoryBase<T> _repostory;
        private IRepositoryBase<Tecnico> repositoryBase;

        public BaseController(IRepositoryBase<T> repositoryBase)
        {
            _repostory = repositoryBase;
        }

        protected BaseController(IRepositoryBase<Tecnico> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }

        [HttpGet]
        public IActionResult BuscaTodos()
        {
            return Ok(_repostory.BuscaTodos().ToList());
        }

        [HttpGet("{id}")]
        public IActionResult BuscaPeloId( int id)
        {
            var entidade = _repostory.BuscaPeloId(id);

            if (entidade is null) return NotFound();

            return Ok(entidade);
        }

        [HttpPost]
        public IActionResult Add([FromBody] T entidade)
        {
            _repostory.Adicionar(entidade);

            return Ok(entidade);
        }
        
        [HttpPut]
        public IActionResult Atualiza([FromBody] T entidade)
        {
            if (!VerificaSeEntidadeExiste(entidade.Id)) return NotFound();


            _repostory.Atualizar(entidade);

            return Ok(entidade);
        }

        [HttpDelete("{id}")]
        public IActionResult Deleta(int id)
        {

           if (!VerificaSeEntidadeExiste(id)) return NotFound();

            _repostory.Remover(_repostory.BuscaPeloId(id));

            return Ok();
        }

        private bool VerificaSeEntidadeExiste(int id)
        {
            var entidade = _repostory.BuscaPeloId(id);

            if (entidade is null) return false;

            return true;
        }
    }
}
