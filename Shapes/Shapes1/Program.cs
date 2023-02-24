// See https://aka.ms/new-console-template for more information
using Shapes1;

static void Main(string[] args)
{
    Class1 sh1 = new Class1();
    Console.Write(sh1.GetSize());

    Class1 sh2 = new Class1(12);
    Console.Write(sh2.GetSize());

}