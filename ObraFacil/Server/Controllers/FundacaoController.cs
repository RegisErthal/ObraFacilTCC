using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObraFacil.Infra.Contexts;
using ObraFacil.Infra.Entities;

namespace ObraFacil.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FundacaoController : ControllerBase
    {

        private readonly ObraFacilContext _obraFacilContext;

        public FundacaoController(ObraFacilContext obraFacilContext)
        {
            _obraFacilContext = obraFacilContext;
        }


        [HttpGet]
        public async Task<IEnumerable<FundacaoModel>> Get()
        {
          
            try
            {
                var result = await _obraFacilContext.Fundacao.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

      
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
