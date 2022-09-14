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
            Console.WriteLine("Choose a option\n 1. Add an elements in linked list\n 4. Insert an element in between linked list\n 5. Delete a first element in linked list\n 6. Delete last element in the linked list\n 7. Search linked list to find node");
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
                    InsertElementInLinkedList list4 = new InsertElementInLinkedList();
                    list4.Add(56);
                    list4.Add(70);
                    list4.InsertInBetween(30, 2);
                    list4.Display();
                    break;
                case 5:
                    DeleteFirstElementInLinkedList list5 = new DeleteFirstElementInLinkedList();
                    list5.Add(56);
                    list5.Add(30);
                    list5.Add(70);
                    list5.DeleteFirstNode();
                    Console.WriteLine("After deleted the first element in linked list : ");
                    list5.Display();
                    break;
                case 6:
                    DeleteLastElementInLinkedList list6 = new DeleteLastElementInLinkedList();
                    list6.Add(56);
                    list6.Add(30);
                    list6.Add(70);
                    list6.DeleteLastNode();
                    Console.WriteLine("Before deleted the first element in linked list : ");
                    list6.Display();
                    break;
                case 7:
                    SearchNodeInLinkedList list7 = new SearchNodeInLinkedList();
                    list7.Add(56);
                    list7.Add(30);
                    list7.Add(70);
                    list7.Search(30);
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
