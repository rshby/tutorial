using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.Casting
{
   public class Casting
   {
      public Casting()
      {

      }

      // create main function untuk class casting
      public void CastingMain()
      {
         // casting -> konversi tipe data
         // casting dari string ke boolean
         bool boolCasting = bool.Parse("true");

         // casting dari string ke int
         int intCasting = int.Parse("100");

         // casting dari string ke double
         double doubleCasting = double.Parse("100");

         // ----- casting ke tipe data string -----
         // casting dari double ke string
         string doubleStr = doubleCasting.ToString();

         Console.WriteLine($"data : {doubleStr.GetType()}");

         // casting dari double ke int
         double dblNum = 12.345;
         Console.WriteLine($"hasil convert dari double ke int : {(int)dblNum}"); // convert menggunakan (tipe_data_tujuan)data

         int intNum = 10;
         Int64 longNum = intNum;
         Console.WriteLine($"longnun = {longNum}, tipe data = {longNum.GetType()}");

         // string formatting
         string testFormatting = $"{longNum}";
         Console.WriteLine($"contoh formating : {testFormatting}, tipe datanya = {testFormatting.GetType()}");
      }
   }
}
