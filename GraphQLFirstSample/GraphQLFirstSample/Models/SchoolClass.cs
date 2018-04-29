using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace GraphQLFirstSample.Models
{
    public class SchoolClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
       // public List<Teacher> Teachers { get; set; }
    }




    public partial class MyContext
    {
        public List<SchoolClass> SchoolClasses { get; set; }
    }
}