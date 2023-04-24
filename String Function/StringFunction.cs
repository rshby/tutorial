using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.String_Function
{
   public class StringFunction
   {
      // create cunstroctor
      public StringFunction()
      {

      }

      // method main
      public void StringFunctionMain()
      {
         string randString = "this is a string";
         Console.WriteLine(randString);

         // panjang karakter string
         Console.WriteLine("string length = {0}", randString.Length);
         Console.WriteLine($"string length = {randString.Length}"); // menggunakan string formatting

         // cek apakah string contains karakter/string -> hasil true/false
         Console.WriteLine("string contain is = {0}", randString.Contains("is"));

         // cek index karakter/string
         Console.WriteLine("index of 'is' = {0}", randString.IndexOf("is")); // hasil = 2, maksudnya kata kedua

         // remove string from specific index
         Console.WriteLine("string remove = {0}", randString.Remove(10, 6));

         // add string at specific index
         Console.WriteLine("add string from specific index = {0}", randString.Insert(10, "short"));

         // replace string
         Console.WriteLine("replace string = {0}", randString.Replace("string", "sentences"));

         // compare string
         Console.WriteLine("compare B to A = {0}", String.Compare("B", "A", StringComparison.OrdinalIgnoreCase));

         // string equals -> hasil true/false
         Console.WriteLine("stirng equals = {0}", String.Equals("A", "a", StringComparison.CurrentCultureIgnoreCase));

         // string padding left
         Console.WriteLine("padding left = {0}", randString.PadLeft(30, '*'));

         // string padding right
         Console.WriteLine("padding right = {0}", randString.PadRight(30, '*'));

         // trim -> menghapus spasi di awall dah akhir text
         Console.WriteLine("string trim = {0}", "   hello world     ".Trim());

         // uppercase -> membuah menjadi hufur besar semua
         Console.WriteLine("string uppercase = {0}", randString.ToUpper());

         // lowercase - > membuat menjadi huruf kecil semua
         Console.WriteLine("string lowercase = {0}", (randString.ToUpper()).ToLower());

         // string format
         string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
         Console.WriteLine(newString);
      }
   }
}
