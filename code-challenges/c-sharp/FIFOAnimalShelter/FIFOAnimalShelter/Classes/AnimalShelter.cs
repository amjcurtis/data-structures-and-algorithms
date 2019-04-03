using StacksAndQueues.Classes;
using System.Collections;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter<T>
    {

        // Publicly accessible queue
        public Queue<T> AnimalQueue = new Queue<T>();
       
        /// <summary>
        /// Adds new node with string value "dog" or "cat" to end of queue
        /// </summary>
        /// <param name="animal">string "dog" or "cat"</param>
        public void Enqueue(T animal)
        {
            Node<T> animalToEnqueue = new Node<T>(animal);
            AnimalQueue.Rear.Next = animalToEnqueue;
            AnimalQueue.Rear = animalToEnqueue;
        }

        /// <summary>
        /// Removes first node with value of preferred animal ("dog" or "cat") from front of queue
        /// </summary>
        /// <param name="pref">string specifying user's preferred type of animal</param>
        /// <returns>first node with value of user's preferred type of animal</returns>
        public Node<T> Dequeue(Node<T> pref)
        {
            // Input validation
            if ( !pref.Value.Equals("dog") && !pref.Value.Equals("cat") )
            {
                return null;
            }

            Queue<T> queue2 = new Queue<T>();
            Node<T> temp = null;

            if ( pref.Value.Equals(AnimalQueue.Peek().Value) )
            {
                return AnimalQueue.Peek();
            }
            while (AnimalQueue.Front.Next != null)
            {
                if ( AnimalQueue.Front.Value.Equals(pref.Value) )
                {
                    temp = AnimalQueue.Front;
                }
                Node<T> temp2 = AnimalQueue.Front;
                AnimalQueue.Front = AnimalQueue.Front.Next;
                queue2.Enqueue(temp2.Value);
            }
            return temp;
        }


    }
}
