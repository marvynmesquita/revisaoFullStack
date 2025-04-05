using Microsoft.AspNetCore.Mvc;
using MinhaApp.Servico;

namespace MinhaApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _alunoServico;

        public AlunoController(IAlunoServico servico)
        {
            _alunoServico = servico;
        }

        [HttpPost]
        public IActionResult Adicionar(AlunoDto alunoDto)
        {
            _alunoServico.Adicionar(alunoDto);
            return Ok("Aluno adicionado com sucesso.");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_alunoServico.Listar());
        }
    }
}
