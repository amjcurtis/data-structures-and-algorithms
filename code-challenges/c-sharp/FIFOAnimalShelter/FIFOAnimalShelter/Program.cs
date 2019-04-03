using System;
using FIFOAnimalShelter.Classes;
using StacksAndQueues.Classes;

namespace FIFOAnimalShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////////////////////////////////////////////
            // Section below uses *Queue* class's methods
            ////////////////////////////////////////////
            //Node<string> newAnimal = new Node<string>("dog");
            //Queue<string> animalQueue = new Queue<string>(newAnimal);
            //for (int i = 1; i <= 6; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        animalQueue.Enqueue("cat");
            //    }
            //    else
            //    {
            //        animalQueue.Enqueue("dog");
            //    }
            //}

            //Console.WriteLine(animalQueue.Front.Value);
            //Console.WriteLine(animalQueue.Rear.Value);

            //Node<string> preferredAnimal = new Node<string>("cat");
            // Doesn't work; uses Queue class's Dequeue method, not AnimalShelter class's Dequeue
            //animalQueue.Dequeue(preferredAnimal);


            ////////////////////////////////////////////
            // Section below uses *AnimalShelter* class's methods
            ////////////////////////////////////////////

            Node<string> catPreference = new Node<string>("cat");
            Node<string> dogPreference = new Node<string>("dog");

            AnimalShelter<string> animalShelterQueue = new AnimalShelter<string>(catPreference);
            for (int i = 1; i <= 6; i++)
            {
                if (i % 3 == 0)
                {
                    animalShelterQueue.Enqueue("cat");
                }
                else
                {
                    animalShelterQueue.Enqueue("dog");
                }
            }

            //animalShelterQueue.Dequeue(catPreference);

            Console.ReadLine();
        }
    }
}
