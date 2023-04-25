using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.Async_Await
{
   public class AsyncAwait
   {
      // create constructor
      public AsyncAwait() 
      { 
      }
      
      // method main
      public async Task AsyncAwaitMain()
      {
         // test async
         Console.WriteLine("test async start");

         // run with async
         Task taskFunc = Task.Run(() =>
         {
            TestAsync();
         });

         Console.WriteLine("running in program main");

         Task.Delay(1000).Wait();

         Console.WriteLine("program done 0");
         
         await taskFunc;

         Console.WriteLine("program done");

         Task[] tasks = System.Array.Empty<Task>(); // create array of Task (array kosong)

         var t1 = DoStuffAsync(1); // jalankan function DoStuffAsync secara asynchronus
         var t2 = DoStuffAsync(2); // jalankan function DoStuffAsync secara asynchronus

         await Task.WhenAll(new[] { t1, t2 }); // tunggu semua task done
      }

      // create function with async
      public void TestAsync()
      {
         for(int i=0; i<10; i++)
         {
            Console.WriteLine(i);
         }
      }

      // create function with async
      public async Task DoStuffAsync(int number)
      {
         await Task.Delay(3000); // tunggu 3 detik
         Console.WriteLine($"{number} done!"); // print ke console
      }
   }
}
