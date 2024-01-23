using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class MyExceptions:Exception
    {
        public string Field {  get; set; }
        public string Class { get; set; }
        public MyExceptions(string field, string classs) : base("incorrect input data")
        {
            Field = field;
            Class = classs;
        }
    }
}
