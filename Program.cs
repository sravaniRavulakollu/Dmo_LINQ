using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.SqlTypes;

namespace Demo_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Implemetation inc#");

            //Data Source
            int[] scores = new int[] { 10, 20, 30, 40, 50 };
            string[] fruits = new string []{ "apple", "bananna", "grapes " };

            //expression

            //IEnumerable <int> ScoreQuery=
            //from score in scores
            //  where score > 34
            //orderby score descending
            // select score;

            //query

            IEnumerable<string> FruitsQuery =
                from fruit in fruits
                where fruit is"bananna" or "grapes"
                select fruit;

            foreach(var item in FruitsQuery)
            {
                Console.WriteLine("Values:{0}\n", item);
            }




            //foreach (int  item in ScoreQuery)
            //{
              //  Console.WriteLine("Values:{0}\n", item);
            //}
                       
        }
    }
}
