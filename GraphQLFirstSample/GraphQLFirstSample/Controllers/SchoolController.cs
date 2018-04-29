using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace GraphQLFirstSample.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/
       [HttpPost]
        public object Index(string query)
        {
            var sc = new MySchema();
                var dict = sc.GraphQL.ExecuteQuery(query);
                return JsonConvert.SerializeObject(dict);
        }

    }
}
