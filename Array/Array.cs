using System.Globalization;

namespace tutorial.Array
{
   public class Array
   {
      // constructor
      public Array()
      {
      }

      // method main
      public void ArrayMain()
      {
         // create array of int
         int[] favNumbers = new int[3];
         favNumbers[0] = 4; // assign value ke index-0 
         favNumbers[1] = 5; // assign value ke index-1

         // print isi array sesuai dengan index tertentu
         Console.WriteLine("array favNumbers at index-0 is : {0}", favNumbers[0]);

         // print semua isi array yang ada
         Console.Write($"isi array = ");

         int i = 1;
         foreach (var number in favNumbers)
         {
            if (i == favNumbers.Length)
            {
               Console.Write(number);
               break;
            }

            Console.Write(number + ", ");
            i++;
         }
         Console.WriteLine();

         // create array bisa juga dengan cara ini
         int[] arrInt = new int[3] { 1, 2, 4 };

         // print semua isi array yang ada
         Console.Write("isi array dengan new int[] = ");
         foreach (var number in arrInt)
         {
            if (number.Equals(arrInt[arrInt.Length - 1]))
            {
               Console.Write(number.ToString());
               break;
            }

            Console.Write("{0}, ", number.ToString());
         }

         // create array of string
         string[] customers = new[] { "Bob", "Sally", "Sue" }; // create array tanpa menyebutan panjang array

         // print semua isi array of string
         Console.WriteLine();
         for (i = 0; i < (customers.Length); i++)
         {
            if (i.Equals(customers.Length - 1))
            {
               Console.Write(customers[i]);
               break;
            }

            Console.Write($"{customers[i]}, ");
         }

         Console.WriteLine();
         Console.WriteLine($"panjang array of string : {customers.Length}"); // print panjang array
         Console.WriteLine($"value array index ke-2 : {customers[2]}"); // print value isi array index ke-2

         // create array secara langsung, yang penting tipe data isinya sama
         var employees = new[]
         {
            "Mike",
            "Paul",
            "Rick"
         };

         // print semua isi array employees
         Console.WriteLine();
         Console.Write("isi array employees : ");
         for (i = 0; i < employees.Length; i++)
         {
            if (i.Equals(employees.Length - 1))
            {
               Console.Write(employees[i]);
               break;
            }

            Console.Write($"{employees[i]}, ");
         }

         Console.WriteLine();
         Console.WriteLine($"panjang array : {employees.Length}"); // print panjang array employees
         Console.WriteLine($"value array index ke-2 : {employees[2]}"); // print vlaue isi array index ke-2

         // create array tetapi isinya tipe data yang berbeda -> menggunakan object[]
         object[] randomArray = { "reo", 1, true, 12.689 };

         // print semua isi array randomArray
         Console.WriteLine();
         Console.Write("isi array randomArray : ");
         for (i = 0; i < randomArray.Length; i++)
         {
            if (i == randomArray.Length - 1)
            {
               Console.Write(randomArray[i]);
               break;
            }

            Console.Write($"{randomArray[i]}, ");
         }

         // print value isi array index ke-0
         Console.WriteLine();
         Console.WriteLine($"panjang array randomArray : {randomArray.Length}"); // print array size/panjang array randomArray
         Console.WriteLine($"value array randomArray index ke-0 : {randomArray[0]}"); // print value isi array randomArray index ke-0
         Console.WriteLine($"tipe data value array index ke-0 : {randomArray[0].GetType()}"); // print tipe data value array index ke-0
         Console.WriteLine($"tipe data value array index ke-1 : {randomArray[1].GetType()}"); // print tipe data value array index ke-1

         // ------------- array 2 dimensi --------------------------
         string[,] custNames = new string[2, 3] { { "bob", "smith", "jane" }, { "sally", "sour", "choco" } }; // create array 2 dimensi

         // print value isi array index ke 0,0
         Console.WriteLine();
         Console.WriteLine($"value array index ke-[0,0] : {custNames[0, 0]}");
         Console.WriteLine($"value array index ke-[0,0] menggunakan GetValue : {custNames.GetValue(0, 0)}");

         Console.WriteLine($"panjang array 2 dimensi (dimeksi ke-0) : {custNames.GetLength(0)}"); // print panjang array dimensi ke-0
         Console.WriteLine($"panjang array 2 dimensi (dimensi ke-1) : {custNames.GetLength(1)}"); // print panjang array dimensi ke-1

         // print semua isi array
         for (i = 0; i < custNames.GetLength(0); i++)
         {
            for (int j = 0; j < custNames.GetLength(1); j++)
            {
               // cek ketika index dimensi ke-0 dan dimensi ke-1 sudah ada di akhir
               if ((i.Equals(custNames.GetLength(0) - 1)) && j.Equals(custNames.GetLength(1) - 1))
               {
                  Console.Write(custNames[i, j]);
                  break;
               }

               Console.Write(custNames[i, j] + ", ");
            }
         }

         // pass array to a function
         int[] randNumbers = { 1, 4, 9, 2, 5, 7 };
         Console.WriteLine();
         PrintArray(randNumbers, "value array");

         // sort array
         System.Array.Sort(randNumbers); // syntax untuk sorting array
         Console.WriteLine("\narray after sort");
         PrintArray(randNumbers, "array after sort"); // print isi semua array setelah disort/diurutkan

         // reverse array (sorting descending)
         System.Array.Reverse(randNumbers); // sytax untuk reverse array
         Console.WriteLine("\narray after reverse");
         PrintArray(randNumbers, "array after reverse");

         // get index by value in array
         Console.WriteLine("value 1 ada di index ke : {0}", System.Array.IndexOf(randNumbers, 1));

         // create new array of int
         int[] srcArray = { 1, 2, 3 };
         int[] destArray = new int[2];

         int startIdx = 0;

         //System.Array anotherArray = System.Array.CreateInstance(typeof(int), srcArray);
         System.Array.Copy(srcArray, startIdx, destArray, 0, destArray.Length);
         Console.WriteLine("\ndestination array after copy");
         PrintArray(destArray, "destArray");

         // create new array menggunakan syntax CreateInstance
         var anotherArray = System.Array.CreateInstance(typeof(int), 10);
         srcArray.CopyTo(anotherArray, 5); // copy isi array variabel srcArray ke dalam variabel anotherArray, dipaste ke variabel anotherArray mulai index ke-5

         // print isi array anotherArray
         foreach (var number in anotherArray)
         {
            Console.WriteLine($"Copy to : {number}");
         }
      }

      // create fuction to print array use foreach
      public void PrintArray(int[] inputArr, string message)
      {
         foreach (var number in inputArr)
         {
            Console.WriteLine("{0} : {1}", message, number);
         }
      }
   }
}
