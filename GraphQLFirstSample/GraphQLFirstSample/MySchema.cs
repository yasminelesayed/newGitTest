using GraphQL.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraphQLFirstSample
{
    public class MySchema
    {
        public GraphQL<MyContext> GraphQL;
         public MySchema()
      {
          var dbContext = new MyContext();
          dbContext.teachers = new List<Models.Teacher>{
         new Models.Teacher ()
         {
             Id=1,
             Name="maha"
         },
          new Models.Teacher ()
         {
             Id=2,
             Name="yasmine"
         }
         };

          var schema = GraphQL<MyContext>.CreateDefaultSchema(() => dbContext);
            schema.AddType<GraphQLFirstSample.Models.Teacher>().AddAllFields();

            schema.AddListField("teachers", (db) => db.teachers.AsQueryable());
            schema.Complete();
            GraphQL = new GraphQL<MyContext>(schema);
      }
     
    }
}