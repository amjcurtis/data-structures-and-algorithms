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

            try
            {
                LList myLinkedList = new LList();
                for (int i = 0; i < 6; i++)
                {
                    myLinkedList.Insert(i + 1);
                }

                myLinkedList.Append(244);

                int[] printedVals = myLinkedList.Print();
                Console.WriteLine("printedVals: [{0}]", string.Join(", ", printedVals));

                Node kthValFromEnd = myLinkedList.GetKthNodeFromEnd(1);
                Console.WriteLine($"Value of kthValFromEnd: {kthValFromEnd.Value}");

                Console.WriteLine($"Length of printedVals: {printedVals.Length}");

                printedVals = myLinkedList.Print();

                // Reverse array of values before printing it to console
                // Running this on own separate line b/c couldn't save to variable (return type conflict)
                //Array.Reverse(printedVals);

                Console.WriteLine("printedVals: [{0}]", string.Join(", ", printedVals));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
	}
}
