// See https://aka.ms/new-console-template for more information

using CLRLib;

Console.WriteLine("Hello, World!");
var newClass1 = new Class1();
try
{
    newClass1.Test(0);
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}
