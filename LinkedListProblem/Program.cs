using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option\n 1. Add an elements in linked list\n");
            int option=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    AddElementInLikedList list1 = new AddElementInLikedList();
                    list1.Add(56);
                    list1.Add(30);
                    list1.Add(70);
                    list1.Display();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
