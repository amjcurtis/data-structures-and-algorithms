using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_LinkedList.Classes
{
    public class Node
    {

        // Add property for value
        public int Value { get; set; }

        // Add property for pointer to next node
        public string Next { get; set; }

      
        public void Test()
        {
            Node newNode = new Node();
            newNode.Value = 10;

        }


    }
}
