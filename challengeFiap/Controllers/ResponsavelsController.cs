using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using challengeFiap.src.Models;
using challengeFiap.src.Data;

[Route("api/[controller]")]
[ApiController]
public class ResponsavelsController : ControllerBase
{
    private readonly AppDbContext _context;
    public ResponsavelsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Responsavel

    /// <summary>
    /// Relatorio responsavel
    /// </summary>
    /// <response code="200">Busca feita com sucesso</response>
    /// <returns>Relatorio: </returns>
    [HttpGet]
    [Route("relatorio/responsavel")]
    public async Task<ActionResult<IEnumerable<Responsavel>>> GetAllResponsavel()
    {
        var responsavelRelatorio = await _context.Responsavel.ToListAsync();
        return Ok(responsavelRelatorio);
    }

    // GET: api/Responsavel/5

    /// <summary>
    /// Relatorio de responsavel feito pelo id
    /// </summary>
    /// <param name="id_responsavel">Buscar pelo id: </param>
    /// <response code="200">Busca feita com sucesso</response>
    /// <response code="404">Id não encontrado</response>
    /// <returns>Relatorio: </returns>
    [HttpGet]
    [Route("relatorio/responsavel/{id_responsavel:int}")]
    public async Task<ActionResult<Responsavel>> GetResponsavel(int id_responsavel)
    {
        try
        {
            var responsavel = await _context.Responsavel.FindAsync(id_responsavel);

            if (responsavel == null)
            {
                return NotFound("Id responsavel não encontrado");
            }

            return Ok(responsavel);
        }
        catch (Exception ex) 
        {
            return BadRequest($"Erro em buscar: {ex.Message}");
        }
        
    }

    // PUT: api/Responsavel/5

    /// <summary>
    /// Atualizar dados reponsavel
    /// </summary>
    /// <param name="id_responsavel">Id para pode atualizar</param>
    /// <param name="responsavel">Dados para serem inseridos</param>
    ///  <response code="204">Responsavel atualizado</response>
    /// <response code="400">Erro na requisição</response>
    /// <response code="404">Responsavel não encontrado</response>
    /// <returns>Atualizar: </returns>
    [HttpPut]
    [Route("atualizar/responsavel/{id_responsavel:int}")]
    public async Task<IActionResult> PutResponsavel(int id_responsavel, Responsavel responsavel)
    {
        if (id_responsavel != responsavel.Id_responsavel)
        {
            return BadRequest("Id responsavel está incorreto");
        }

        try
        {
            var cpfExiste = await _context.Responsavel
                .FirstOrDefaultAsync(
                c => c.Cpf_responsavel == responsavel.Cpf_responsavel && c.Id_responsavel != id_responsavel);
            if (cpfExiste != null)
            {
                return BadRequest("Cpf já esta sendo utilizando");
            }
            _context.Entry(responsavel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ResponsavelExists(id_responsavel))
            {
                return NotFound("Id responsavel nao achando");
            }
            else
            {
                throw;
            }
        }catch(Exception ex)
        {
            return BadRequest($"Erro em atualizar responsavel: {ex.Message}");
        }
    }
    private bool ResponsavelExists(int id_responsavel)
    {
        return _context.Responsavel.FirstOrDefault(e => e.Id_responsavel == id_responsavel) != null;
    }

    // POST: api/Responsavel

    /// <summary>
    /// Criar responsavel
    /// </summary>
    /// <param name="responsavel">Criação de dados de endereço responsavel </param>
    /// <response code="201">Responsavel criado com sucesso.</response>
    /// <response code="400">Erro na validação.</response>
    /// <returns>Criação responsavel</returns>
    [HttpPost]
    [Route("criar/responsavel")]
    public async Task<ActionResult<Responsavel>> PostResponsavel(Responsavel responsavel)
    {
        try
        {
            var cpfExiste = await 
                _context.Responsavel
                .FirstOrDefaultAsync(a => a.Cpf_responsavel == responsavel.Cpf_responsavel);
            if (cpfExiste == null)
            {
                _context.Responsavel.Add(responsavel);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetResponsavel", new { id_responsavel = responsavel.Id_responsavel }, responsavel);
            }else
            {
                return BadRequest("Cpf já existente");
            }
        }catch(Exception ex)
        {
            return BadRequest($"Erro encontrado: {ex.Message}");
        }
    }

    // DELETE: api/Responsavel/5

    /// <summary>
    /// Remove dados de responsavel
    /// </summary>
    /// <param name="id_responsavel">Id para pode remover: </param>
    /// <response code="204">Responsavel removido com sucesso.</response>
    /// <response code="404">Responsavel não encontrado.</response>
    /// <response code="400">Erro ao processar.</response>
    /// <returns>Deletado: </returns>
    [HttpDelete]
    [Route("deleta/responsavel/{id_responsavel:int}")]
    public async Task<IActionResult> DeleteResponsavel(int id_responsavel)
    {
        try
        {
            var responsavel = await _context.Responsavel.FindAsync(id_responsavel);
            if (responsavel == null)
            {
                return NotFound("Id nao encontrado");
            }

            _context.Responsavel.Remove(responsavel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro em deletar: {ex.Message}");
        }
    }

 
}
