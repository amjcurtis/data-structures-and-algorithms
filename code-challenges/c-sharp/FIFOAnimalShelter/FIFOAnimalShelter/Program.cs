using System;
using FIFOAnimalShelter.Classes;
using StacksAndQueues.Classes;

namespace FIFOAnimalShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Node<string> newAnimal = new Node<string>("dog");
            Queue<string> animalQueue = new Queue<string>(newAnimal);
            for (int i = 1; i <= 6; i++)
            {
                if (i % 3 == 0)
                {
                    animalQueue.Enqueue("cat");
                }
                else
                {
                    animalQueue.Enqueue("dog");
                }
            }

            Console.WriteLine(animalQueue.Front.Value);
            Console.WriteLine(animalQueue.Rear.Value);


            Console.ReadLine();
        }
    }
}
