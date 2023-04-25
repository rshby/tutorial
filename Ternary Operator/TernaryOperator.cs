using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.Ternary_Operator
{
   public class TernaryOperator
   {
      /*
       * Ternary Operator
       * adalah operasi kondisi (if else) menggukana synatx ? (tanda tanya)
       * Penulisan :
       * condition ? statement_true : statement_false
       */

      // create constructor
      public TernaryOperator()
      {

      }

      // method main
      public void TernaryOperatorMain()
      {
         // create variabel yang digunakan
         int x = 10;
         string result = x <= 10 ? "kurang dari atau sama dengan 10" : "lebih dari 10"; // operasi if else menggunakan ternary
         Console.WriteLine(result);

         // create variabel
         int age = 22;
         bool canDrive = age >= 16 ? true : false; // operasi if else menggunakan ternary
         Console.WriteLine($"umur {age} tahun, apakah sudah boleh mengemudi : {canDrive}");

         // if - else if (Ternary)
         int nilai = 50;
         string grade = nilai >= 95 ? "A" : nilai >= 70 ? "B" : nilai >= 50 ? "C" : "Tidak Lulus";
         Console.WriteLine($"nilai {nilai} mendapat grade : {grade}");
      }
   }
}
