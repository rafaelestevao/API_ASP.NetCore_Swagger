using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiSwaggerTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {


        public class Funcionario
        {
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string telefone { get; set; }
        }


        // GET api/values
        [HttpGet]
        public Funcionario Get()
        {
            //return new string[] { "value1", "value2" };
            return new Funcionario() { Nome = "Rafael Estevão", Endereco = "Rua armelindo cruz, 322", Cidade = "São Paulo", Estado = "SP", telefone = "11-0000-0000" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
