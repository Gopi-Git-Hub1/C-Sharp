using System;
// ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException
class program
{
static void Main(string[] args)
{
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.\n"+e);
}
finally
{
  Console.WriteLine("The 'try catch' is finished.");
}
}
}
