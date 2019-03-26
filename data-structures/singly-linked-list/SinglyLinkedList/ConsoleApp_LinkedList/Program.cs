using System;
using ConsoleApp_LinkedList.Classes;

namespace ConsoleApp_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Node newNode = new Node();
            //newNode.Value = 10;

            LList myLinkedList = new LList();
            for (int i = 0; i < 6; i++)
            {
                myLinkedList.Insert(i * 3);
            }

            bool listIncludesVal = myLinkedList.Includes(12);

            Console.WriteLine($"listIncludesVal: {listIncludesVal}");

            int[] printedVals = myLinkedList.Print();

            // Reverse array of values before printing it to console
            // Running this on own separate line b/c couldn't save to variable (return type conflict)
            Array.Reverse(printedVals);

            Console.WriteLine("printedVals: {0}", string.Join(", ", printedVals));

            Console.ReadLine();
        }
    }
}
