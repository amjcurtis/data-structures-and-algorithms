using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_LinkedList.Classes
{
    public class LList
    {
        // Add head property
        public Node Head { get; set; }

        // Amanda prefers it this way
        public Node Current { get; set; }


        /// <summary>
        /// Adds new node with input value to beginning of linked list
        /// </summary>
        /// <param name="value">int value</param>
        public void Insert(int value)
        {
            // Point Current node to Head to make sure we're starting at beginning of list
            Current = Head;
            
            // Instantiate new node
            Node nodeToInsert = new Node(value);

            // Set new node's Next to point to Head
            nodeToInsert.Next = Head;

            // Point Head to inserted node
            Head = nodeToInsert;

            // Assign Current to Head again now that Head has been updated
            Current = Head;
        }


        /// <summary>
        /// Traverses singly linked list and return whether input value is found in list
        /// </summary>
        /// <param name="value">int value</param>
        /// <returns>boolean depending on whether value exists in a node in list</returns>
        public bool Includes(int value)
        {
            // Start at beginning of list
            Current = Head;

            // Traverse list if list contains multiple nodes
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }

            // Catches case where list contains only single node
            if (Current.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Traverses singly linked list and returns int array of all nodes' values
        /// </summary>
        /// <returns>int array</returns>
        public int[] Print()
        {
            // Counter that tracks number of while loop interations 
            int count = 0;

            Current = Head;

            // Loop through list first time to find list's length
            while (Current.Next != null)
            {
                // Can get/save node value here somehow to avoid having to loop through list a second time?

                count++;
                Current = Current.Next;
            }

            // Saves value of last node to insert into array later
            int valueOfLastNode = Current.Value;

            // Initialize array to store int values of nodes
            // Length is number of nodes whose Next isn't null + last node
            int[] arrayOfAllIntValues = new int[count + 1];
            
            // Reset Current before next loop through link
            Current = Head;

            // Populates array with values from all but last node (i.e. nodes whose Next wasn't null)
            for (int i = 0; i < count; i++)
            {
                arrayOfAllIntValues[i] = Current.Value;
                Current = Current.Next;
            }

            // Adds last value in linked list to last position in array
            arrayOfAllIntValues[arrayOfAllIntValues.Length - 1] = valueOfLastNode;

            return arrayOfAllIntValues;
        }
    }
}
