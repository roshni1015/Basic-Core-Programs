// See https://aka.ms/new-console-template for more information
using Basic_Core_Programming;

Console.WriteLine("Basic Core Pogram!");
while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)Swapingnumber");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
          swapingnumber swap = new swapingnumber();
          swap.swap();
          break;
        default:
          break;



            }
    }