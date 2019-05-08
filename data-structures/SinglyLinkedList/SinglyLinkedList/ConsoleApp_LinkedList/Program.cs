﻿using System;
using System.Collections.Generic;
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
                LList sll = new LList();
                for (int i = 0; i < 6; i++)
                {
					// Demo Append() method
					sll.Append(i + 1);
                }

				// Demo Insert() method
                //myLinkedList.Insert(244);

				// Demo Print() method
                int[] printedVals = sll.Print();
                Console.WriteLine("printedVals: [{0}]", string.Join(", ", printedVals));

				// Demo GetKthNodeFromEnd()
                Node kthValFromEnd = sll.GetKthNodeFromEnd(2);
                Console.WriteLine($"Value of kthValFromEnd: {kthValFromEnd.Value}\n");

				// Reverse array of values before printing it to console (because nodes were inserted at *front* of list)
				//Console.WriteLine("REVERSE printedVals TO SHOW NODES IN ORDER IN WHICH THEY WERE ADDED");
				//Array.Reverse(printedVals);

				// Demo reversing of linked list
				Console.WriteLine("REVERSE LINKED LIST");
				sll.Reverse();
				printedVals = sll.Print();
				Console.WriteLine("printedVals: [{0}]", string.Join(", ", printedVals));
				Console.WriteLine($"HEAD.Value: {sll.Head.Value}");
				Console.WriteLine($"HEAD.Next.Value: {sll.Head.Next.Value}");
			}
			catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
	}
}
