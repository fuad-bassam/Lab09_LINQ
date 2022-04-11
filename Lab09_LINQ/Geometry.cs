using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_LINQ
{
    public class Geometry
    {
        public string type { get; set; }


       
    public List<decimal> coordinates { get; set; }


        public override string ToString()
        {
            return " { \n type: " + type + "\n coordinates: \n    " + coordinates[0] + "\n    " + coordinates[1]+"\n }";


                }

    }
}
