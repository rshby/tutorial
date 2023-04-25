// See https://aka.ms/new-console-template for more information
using tutorial.Async_Await;
using tutorial.Casting;
using tutorial.Formatting_Output;
using tutorial.LinQ;
using tutorial.String_Function;
using tutorial.Switch_Case;
using tutorial.Ternary_Operator;
using Array = tutorial.Array.Array;

public class Program
{
   static async Task Main(string[] args)
   {
      Console.WriteLine("Hello, World!");

      // define variabel dengant tipe data TestDelegate
      // public TestDelegate testDelegateFunction;

      // declare class
      Casting cast = new Casting();
      FormattingOutput formattingOutput = new FormattingOutput();
      StringFunction stringFunction = new StringFunction();
      Array arr = new Array();
      TernaryOperator ternaryOperator = new TernaryOperator();
      SwitchCase switchCase = new SwitchCase();
      AsyncAwait asyncAwait = new AsyncAwait();
      LinqExample linqExample = new LinqExample();

      // call main method
      //cast.CastingMain();
      //formattingOutput.FormattingOutputMain();
      // stringFunction.StringFunctionMain();
      // arr.ArrayMain();
      // ternaryOperator.TernaryOperatorMain();
      // switchCase.SwitchCaseMain();
      // await asyncAwait.AsyncAwaitMain();
      linqExample.LinqMain();
   }
}


