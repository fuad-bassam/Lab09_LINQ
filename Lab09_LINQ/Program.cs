using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lab09_LINQ
{
    class Program
    {


        public static Data callJson(string address)
        {

            Data data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(address));

            return data;

        }


        static void Main(string[] args)
        {

            Data dd = callJson(@"../../../../data.json");

            /// questions 1
            Console.WriteLine("////////////////////////////////////////////////////////// Questions 1");

            Console.WriteLine(dd.ToString());

            /// questions 2
            Console.WriteLine("////////////////////////////////////////////////////////// Questions 2");

            List<Features> list = dd.features.Select(s => s).Where(s => s.Properties.neighborhood != "").ToList();


            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("the number of neighborhood = " + list.Count);

            //// question 3
            Console.WriteLine("////////////////////////////////////////////////////////// Questions 3");

            List<Features> linqDuplicates = list.GroupBy(x => x.Properties.neighborhood).Select(x => x.First()).ToList();

            foreach (var item in linqDuplicates)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("the number of neighborhood = " + linqDuplicates.Count);




            /// questions 4



            Console.WriteLine("////////////////////////////////////////////////////////// Questions 4");
            List<Features> allQuery = dd.features.Select(s => s).Where(s => s.Properties.neighborhood != "").GroupBy(x => x.Properties.neighborhood).Select(x => x.First()).ToList();

            foreach (var item in allQuery)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("the number of neighborhood = " + allQuery.Count);



            // questions 5
            Console.WriteLine("////////////////////////////////////////////////////////// Questions 5");

            var queryVersion = (from s in dd.features
                                where s.Properties.neighborhood != ""
                                select s).ToList();


            foreach (var item in queryVersion)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("the number of neighborhood = " + queryVersion.Count);



            #region JToken

            //List<Features> list = dd.features.Select(s => s).ToList();
            //Console.WriteLine();
            // var distinctList = dd.GroupBy(x => x.).DistinctBy(x => x.ObjectID).ToList();

            // list.Distinct(x => x.);
            // var x =dd.features.Select(s => s).Distinct(x => x.Properties.neighborhood);


            // var distinct = list.Distinct(i => i.);


            //foreach (Features item in x)
            //{
            //    Console.WriteLine(item);

            //}


            //Console.WriteLine(dd.features.Count());

            //////////////////////////////////////////////////////////////

            //using (StreamReader reader = File.OpenText(@"../../../../data.json"))
            //{
            //    //  JToken o = JToken.ReadFrom(new JsonTextReader(reader));
            //    JToken o = JToken.ReadFrom(new JsonTextReader(reader));
            //    //  IList<string> storeNames = o["features"].Select(s => s.SelectToken("type[0]")).ToList();
            //    // List<string> storeNames = o["features"].Select(s => s.SelectToken("properties.").ToString()).ToList();
            //   //  var storeNames = o.
            //   //Select(s => s.ToString()).ToList();

            //    //JsonConvert.DeserializeObject(o);

            //    //foreach (var item in storeNames)
            //    //{
            //    //    Console.WriteLine(item);
            //    //}

            //   // o.SelectToken("features").;
            //    //      Console.WriteLine("Hello World!" + o.ToObject<JObject>().);

            //    // do stuff
            //}
            #endregion



            Console.ReadKey();

        }
    }
}
