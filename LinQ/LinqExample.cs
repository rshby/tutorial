using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.LinQ
{
   public class LinqExample
   {
      // create constructor
      public LinqExample()
      {
      }

      // function main
      public void LinqMain()
      {
         // create list of int
         List<int> myNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

         // get Min
         Console.WriteLine(myNumbers);
         Console.WriteLine($"nilai minimal dari List<int> nyNumbers : {myNumbers.Min<int>()}");

         Console.WriteLine($"{myNumbers.Where(x => x % 2 == 0).ToList()}");

         // get bilangan genap dari List<int> myNumbers
         Console.WriteLine();
         Console.WriteLine("print myNumber where even(genap) :");
         foreach (var number in myNumbers.Where(x => x % 2 == 0).ToList())
         {
            Console.WriteLine(number);
         }

         // get maximal
         Console.WriteLine();
         int max = (int)myNumbers.Max<int>();
         Console.WriteLine($"nilai maksimal dari List<int> myNumbers : {max}");

         // get jumlah total (SUM)
         int sum = (int)myNumbers.Sum();
         Console.WriteLine($"sum dari List<int> myNumbers : {sum}");

         int sumGenap = (int)myNumbers.Where<int>(x => x % 2 == 0).Sum(); // get sum untuk bilangan genap
         Console.WriteLine($"sum bilangan genap dari List<int> myNumbers : {sumGenap}");

         // get Count
         Console.WriteLine();
         int count = (int)myNumbers.Count();
         Console.WriteLine($"count dari List<int> myNumbers : {count}");

         int countGenap = (int)myNumbers.Where(x => x % 2 == 0).Count(); // get count untuk bilangan genap dari List<int> myNumbers
         Console.WriteLine($"count dari bilangan genap List<int> myNumbers : {countGenap}");

         // get Average
         Console.WriteLine();
         double average = (double)myNumbers.Average();
         Console.WriteLine($"average dari List<int> myNumbers : {average}");

         double averageGenap = (double)myNumbers.Where(x => x % 2 == 0).Average(); // get average bilangan genap dari List<int> myNumbers
         Console.WriteLine($"average bilangan genap dari List<int> myNumbers : {averageGenap}");
      }
   }
}
