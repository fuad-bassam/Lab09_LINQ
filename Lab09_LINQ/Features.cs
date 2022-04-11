using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_LINQ
{
    public class Features
    {
        public string type { get; set; }

        public Geometry Geometry { get; set; }

        public Properties Properties { get; set; }


        public override string ToString()
        {
            return "\n { \n type: " + type + "\n Geometry: \n" + Geometry + "\n Properties: \n" + Properties+"\n }";
        }
    }
}
