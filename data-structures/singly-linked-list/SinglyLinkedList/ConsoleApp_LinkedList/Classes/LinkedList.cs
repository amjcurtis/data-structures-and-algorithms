using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_LinkedList.Classes
{
    public class LList
    {
        // Add Head property
        public Node Head { get; set; }

        // Add Current property
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


        /// <summary>
        /// Appends new node to end of linked list
        /// </summary>
        /// <param name="value">int value</param>
        public void Append(int value)
        {
            Current = Head;

            Node nodeToInsert = new Node(value);

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = nodeToInsert;
        }


        /// <summary>
        /// Inserts new node before specified existing node
        /// </summary>
        /// <param name="existingNodeValue">int for value of node to insert new node before</param>
        /// <param name="newNodeValue">int for value of new node</param>
        /// <returns>boolean</returns>
        public bool InsertBefore(int existingNodeValue, int newNodeValue)
        {
            Current = Head;
            Node nodeToInsert = new Node(newNodeValue);

            while (Current.Next != null)
            {
                if (Current.Value == existingNodeValue)
                {
                    nodeToInsert.Next = Current;
                    Head = nodeToInsert;
                    return true;
                }
                else if (Current.Next.Value == existingNodeValue)
                {
                    nodeToInsert.Next = Current.Next;
                    Current.Next = nodeToInsert;
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }


        /// <summary>
        /// Inserts new node after specified existing node
        /// </summary>
        /// <param name="existingNodeValue">int for value of node to insert new node after</param>
        /// <param name="newNodeValue">int for value of new node</param>
        /// <returns>boolean</returns>
        public bool InsertAfter(int existingNodeValue, int newNodeValue)
        {
            Current = Head;
            Node nodeToInsert = new Node(newNodeValue);

            while (Current.Next != null)
            {
                if (Current.Value == existingNodeValue)
                {
                    nodeToInsert.Next = Current.Next;
                    Current.Next = nodeToInsert;
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Next == null)
            {
                Current.Next = nodeToInsert;
                return true;
            }
            return false;
        }


        public int GetKthNodeFromEnd(int k)
        {
            if (Head == null)
            {
                throw new Exception("There are no nodes in the list!");
            }
            if (k < 0)
            {
                throw new Exception("k value cannot be negative!");
            }

            Current = Head;

            // Counter to increment for tracking length of list
            int count = 0;

            while (Current.Next != null)
            {
                count++;
                Current = Current.Next;
            }

            if (k > count)
            {
                throw new IndexOutOfRangeException("k value is greater than length of list!");
            }

            // Reset Current to Head before second loop through list
            Current = Head;

            int distanceFromEnd = count - k;
            for (int i = 0; i < distanceFromEnd; i++)
            {
                Current = Current.Next;
            }
            return Current.Value;
        }
    }
}
