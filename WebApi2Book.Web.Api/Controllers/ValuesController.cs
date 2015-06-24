using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2Book.Web.Api.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
			Console.WriteLine("{0}", value);
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
			Console.WriteLine("ID: {0}; value: {0}", id, value);
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}