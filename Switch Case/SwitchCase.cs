using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.Switch_Case
{
   public class SwitchCase
   {
      /* Switch Case
       * Seperti if else tetapi sesuai dengan value variabel yang dibandingkan
       * Penulisan :
       * Switch(variabel):
       * Case 1:
       * break;
       * Case 2:
       * break;
       * Default :
       * Break;
       */

      // create constructor
      public SwitchCase()
      {

      }

      // method main
      public void SwitchCaseMain()
      {
         string gradeAkhir = "E"; // create variabel
         switch (gradeAkhir)
         {
            case "A":
               Console.WriteLine("Memuaskan");
               break;
            case "B":
               Console.WriteLine("Cukup");
               break;
            case "C":
               Console.WriteLine("Kurang Baik");
               break;
            default:
               Console.WriteLine("Tidak Lulus");
               break;
         }
      }
   }
}
