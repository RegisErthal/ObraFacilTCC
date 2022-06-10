using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObraFacil.Infra.Contexts;
using ObraFacil.Shared.Models;
using ObraFacil.Shared;


namespace ObraFacil.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ObraFacilContext _obraFacilContext;

        public ClientController(ObraFacilContext obraFacilContext)
        {
            _obraFacilContext = obraFacilContext;
        }

        [HttpGet]
        public async Task<IEnumerable<ClientModel>> Get()
        {
            var clientsEntiy = await _obraFacilContext.Clients.ToListAsync();
            return clientsEntiy.ConvertAll(x => new ClientModel { Name = x.Name, Age = x.Age, Id = x.Id });
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