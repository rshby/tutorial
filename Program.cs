// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using tutorial.Array;
using tutorial.Casting;
using tutorial.Formatting_Output;
using tutorial.String_Function;
using Array = tutorial.Array.Array;

public class Program
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Hello, World!");

      // define variabel dengant tipe data TestDelegate
      // public TestDelegate testDelegateFunction;

      // declare class
      Casting cast = new Casting();
      FormattingOutput formattingOutput = new FormattingOutput();
      StringFunction stringFunction = new StringFunction();
      Array arr = new Array();

      // call main method
      //cast.CastingMain();
      //formattingOutput.FormattingOutputMain();
      // stringFunction.StringFunctionMain();
      arr.ArrayMain();
   }
}


