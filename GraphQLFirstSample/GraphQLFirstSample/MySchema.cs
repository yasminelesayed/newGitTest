using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GraphQLFirstSample.Models;
using GraphQL.Net;

namespace GraphQLFirstSample
{
    public class MySchema
    {
        public GraphQL<MyContext> GraphQL;
        public MySchema()
        {
            var dbContext = new MyContext();
            dbContext.SchoolClasses = new List<Models.SchoolClass>
            {
                new Models.SchoolClass()
                {
                    ClassId = 1,
                    ClassName = "English"
                },
                new Models.SchoolClass()
                {
                    ClassId = 2,
                    ClassName = "Maths"
                }
            };

            var schema = GraphQL<MyContext>.CreateDefaultSchema(() => dbContext);
            schema.AddType<GraphQLFirstSample.Models.SchoolClass>().AddAllFields();

            schema.AddListField("SchoolClasses", (db) => db.SchoolClasses.AsQueryable());
            schema.Complete();
            GraphQL = new GraphQL<MyContext>(schema);
        }

    }
}