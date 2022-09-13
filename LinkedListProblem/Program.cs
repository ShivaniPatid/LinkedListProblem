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
            Console.WriteLine("Choose a option\n 1. Add an elements in linked list\n 4. Insert an element in between linked list\n 5. Delete a first element in linked list ");
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
                case 4:
                    InsertElementInLinkedList list2 = new InsertElementInLinkedList();
                    list2.Add(56);
                    list2.Add(70);
                    list2.InsertInBetween(30, 2);
                    list2.Display();
                    break;
                case 5:
                    DeleteFirstElementInLinkedList list3 = new DeleteFirstElementInLinkedList();
                    list3.Add(56);
                    list3.Add(30);
                    list3.Add(70);
                    Console.WriteLine("{0} is a deleted in the linked list ",list3.DeleteFirstNode());
                    Console.WriteLine("Element in linked list : ");
                    list3.Display();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
