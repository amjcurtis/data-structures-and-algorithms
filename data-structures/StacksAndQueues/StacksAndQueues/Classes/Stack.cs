using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack<T> : IEnumerable
    {

        // Add Top property
        public Node<T> Top { get; set; }

        //TODO Push method


        //TODO Pop method

        //TODO Peek method 

        /// <summary>
        /// Implements IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implements IEnumerable
        /// </summary>
        /// <returns>GetEumerator()</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
