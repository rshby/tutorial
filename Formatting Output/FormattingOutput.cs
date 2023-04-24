using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.Formatting_Output
{
   public class FormattingOutput
   {
      // constructor
      public FormattingOutput()
      {

      }

      // method main
      public void FormattingOutputMain()
      {
         // print mata uang
         Console.WriteLine("Currency : {0:c}", 23.44);

         // padding left 0
         Console.WriteLine("pad left with zeros : {0:d4}", 23);

         // 3 angka di belakang koma
         Console.WriteLine("3 decimals : {0:f3}", 23.555555);

         // 
         Console.WriteLine("commas : {0:n4}", 2300);
      }
   }
}
