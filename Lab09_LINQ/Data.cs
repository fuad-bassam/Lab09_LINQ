using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_LINQ
{
   public class Data 
    {
       
        public string type { get; set; }


        public List<Features> features { get; set; }

        public int count { get; set; }


        public override string ToString()
        {
            String s = null;

            foreach (var item in features)
            {
                s += item;
                count+=1;
            }


            return "{ \n type: " + type + "\n features: " + s+"\n }";
        }


    }
}
