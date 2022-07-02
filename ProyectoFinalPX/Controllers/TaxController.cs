using Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenFinalPX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ITax service;
        private readonly IDbConnection connection;
        public TaxController(ITax publicidad, IDbConnection dbconnection)
        {
            this.service = publicidad;
            this.connection = dbconnection;
        }

        // GET: api/<CajaController>
        [HttpGet]
        public List<tbl_taxModel> Get()
        {
            return service.GetTaxes(connection);
        }
        /*
        // GET api/<CajaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CajaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
        // PUT api/<CajaController>/5
        public List<tbl_taxModel> Put(int id)
        {
            return service.EditTax(connection, id);
        }
        /*
        // DELETE api/<CajaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
