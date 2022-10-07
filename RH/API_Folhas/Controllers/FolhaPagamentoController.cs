using System.Collections.Generic;
using System.Linq;
using API_Folhas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Folhas.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaPagamentoController : ControllerBase
    {
    private readonly DataContext _context;

    public FolhaPagamentoController(DataContext context) => _context = context;

    private static List<FolhaPagamento> folhaPagamentos = new List<FolhaPagamento>();

    [Route("cadastrar")]
    [HttpPost]
    public IActionResult Cadastrar([FromBody] FolhaPagamento folhaPagamento)

        {
            _context.FolhaPagamento.Add(folhaPagamento);
            _context.SaveChanges();
            return Created("", folhaPagamento);  
        }

    [Route("listar")]
    [HttpGet]
    public IActionResult Listar() => Ok(_context.FolhaPagamento.Include(FolhaPagamento => FolhaPagamento.Funcionario).ToList());   

    [Route("buscar/{cpf}")]
    [HttpGet]
    public IActionResult Buscar([FromRoute] string cpf)
        {
            Funcionario folhaPagamento = _context.Funcionarios.FirstOrDefault(f => f.Cpf.Equals(cpf));
            
            return folhaPagamento != null ? Ok(folhaPagamento) : NotFound();
        }


    }
}