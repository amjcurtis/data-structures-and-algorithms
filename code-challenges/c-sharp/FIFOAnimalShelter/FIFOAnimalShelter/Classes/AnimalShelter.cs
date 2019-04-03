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

        //public Node<T> Dequeue()
        //{
        //    An
        //}


    }
}
