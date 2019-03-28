using System;
using ConsoleApp_LinkedList.Classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate singly linked list   
            LList list1 = new LList();
            for (int i = 0; i < 6; i++)
            {
                list1.Append(i + 1);
            }

            int[] list1NodeValues = list1.Print();
            Console.WriteLine("list1NodeValues: {0}", string.Join(", ", list1NodeValues));

            LList list2 = new LList();
            //for (int i = 0; i < 3; i++)
            //{
            //    list2.Append(i + 11);
            //}

            int[] list2NodeValues = list2.Print();
            Console.WriteLine("list2NodeValues: {0}", string.Join(", ", list2NodeValues));
            
            LList zippedList = MergeLists(list1, list2);

            Console.WriteLine($"zippedList.Head.Value: {zippedList.Head.Value}");

            int[] printedZippedList = zippedList.Print();
            Console.WriteLine("printedZippedList: {0}", string.Join(", ", printedZippedList));
            
            Console.ReadLine();
        }

        /// <summary>
        /// Merges two linked lists together with nodes from the lists in alternating order
        /// </summary>
        /// <param name="list1">first linked list argument</param>
        /// <param name="list2">second linked list argument</param>
        /// <returns></returns>
        public static LList MergeLists(LList list1, LList list2)
        {
            // Return null if either list is empty
            if (list1.Head == null && list2.Head == null)
            {
                Console.WriteLine("Sorry, both the lists you input are empty!");
                return null;
            }
            else if (list1.Head == null && list2.Head != null)
            {
                return list2;
            }
            else if (list1.Head != null && list2.Head == null)
            {
                return list1;
            }
         
            // Set Current node of each list to its respective Head
            Node Current1 = list1.Head;
            Node Current2 = list2.Head;

            while (Current1.Next != null && Current2.Next != null)
            {
                Node temp1 = Current1.Next;
                Node temp2 = Current2.Next;

                Current1.Next = Current2;
                Current2.Next = temp1;

                Current1 = temp1;
                Current2 = temp2;
            }

            if (Current1.Next == null)
            {
                Current1.Next = Current2;
            }
            else
            {
                Current2.Next = Current1.Next;
                Current1.Next = Current2;
            }

            return list1;
        }
    }
}
