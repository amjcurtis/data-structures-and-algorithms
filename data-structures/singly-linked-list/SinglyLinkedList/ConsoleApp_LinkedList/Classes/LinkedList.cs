using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_LinkedList.Classes
{
    public class LinkedList
    {

        // Add head property
        public Node Head { get; set; }

        public /* string or Node? */ current;


        // Should take any (int) value as arg and add a new node with that value to head of linked list
        public void Insert(int value)
        {
            current = Head;

            Node newNode = new Node();

            newNode.Value = value;

            Node Head = newNode;
        }


        // Define method on LinkedList class called Includes()
        // Should take any value as arg and return boolean result depending on if value exists as a node's value somewhere in list  
        public bool Includes(int value)
        {
            while (/* node's Next != null */)
            {
                if (/* node's value == value*/)
                {
                    return true;
                }
            }
            return false;
        }


        // Define method on LinkedList class called Print()
        // Takes in no arguments and returns a collection all of the current Node values in the Linked List
        public void Print()
        {
            while (/* node's Next != null */)
            {

            }
        }

    }



}
