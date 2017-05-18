using RecipeBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecipeBook.Api.Controllers
{
    public class RecipeController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            var recipeNames = new List<string>();
            using (RecipeContext context = new RecipeContext())
            {
                recipeNames = context.Recipies.Select(x => x.Name).ToList();
            }
            return recipeNames;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}