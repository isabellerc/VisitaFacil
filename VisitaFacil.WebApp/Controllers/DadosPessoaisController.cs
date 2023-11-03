using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;

//como estava antes:
//[Route("api/dadospessoais")]
//[ApiController]
//public class DadosPessoaisController : ControllerBase
//{
//    private readonly Contexto _context;

//    public DadosPessoaisController(Contexto context)
//    {
//        _context = context;
//    }

//    [HttpPost]
//    public async Task<IActionResult> SalvarDadosPessoais([FromBody] DadosPessoais dados)
//    {
//        if (ModelState.IsValid)
//        {
//            // Valide e salve os dados no banco de dados usando o Entity Framework Core
//            _context.DadosPessoais.Add(dados);
//            await _context.SaveChangesAsync();
//            return Ok();
//        }
//        else
//        {
//            return BadRequest(ModelState);
//        }
//    }
//}

//[ApiController]
//[Route("api/dadospessoais")]
public class DadosPessoaisController : ControllerBase
{
    //[HttpPost]
    //public IActionResult Post([FromForm] DadosPessoais dadosPessoais)

    //{
    //    if (ModelState.IsValid) // Certifique-se de que os dados são válidos
    //    {
    //        try
    //        {
    //            using (var contexto = new Contexto()) // Substitua 'SeuDbContext' pelo seu contexto do Entity Framework
    //            {
    //                contexto.Add(dadosPessoais); // Adicione os dados ao contexto
    //                contexto.SaveChanges(); // Salve as mudanças no banco de dados
    //            }

    //            return Ok("Dados pessoais salvos com sucesso.");
    //        }
    //        catch (Exception ex)
    //        {
    //            return BadRequest($"Erro ao salvar os dados pessoais: {ex.Message}");
    //        }
    //    }

    //    return BadRequest("Dados pessoais inválidos.");
    //}

    private Contexto db = new Contexto();
    [HttpPost]
    public IActionResult Post(DadosPessoais dadosPessoais)
    {
        db.DadosPessoais.Add(dadosPessoais);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
}

//public class DadosPessoais
//{
//    public string Nome { get; set; }
//    public string Cpf { get; set; }
//    public DateTime DataNascimento { get; set; }
//    public string Endereco { get; set; }
//    public string Telefone1 { get; set; }
//    public string Telefone2 { get; set; }
//    public string Email { get; set; }
//    public string Senha { get; set; }
//}

