using System;
using FIFOAnimalShelter.Classes;
using StacksAndQueues.Classes;

namespace FIFOAnimalShelter
{
    public class Program
    {

        public static void Main(string[] args)
        {
			///////////////////////////////////////////////////////
			// Instantiate nodes to populate animal shelter queue
			///////////////////////////////////////////////////////

			AnimalNode<string> catPreference = new AnimalNode<string>("cat");
			AnimalNode<string> dogPreference = new AnimalNode<string>("dog");

			// Instantiate and populate animal shelter queue
			AnimalShelter<string> animalShelter = new AnimalShelter<string>(catPreference);
			for (int i = 1; i <= 6; i++)
			{
				if (i % 3 == 0)
				{
					animalShelter.Enqueue(catPreference.Value);
					Console.WriteLine($"animalShelter.Rear:  {animalShelter.Rear.Value}");
				}
				else
				{
					animalShelter.Enqueue(dogPreference.Value);
					Console.WriteLine($"animalShelter.Rear:  {animalShelter.Rear.Value}");
				}
			}

			///////////////////////////////////////////
			// Beginning of console app UI
			///////////////////////////////////////////
			
			Console.WriteLine("Enter the animal you would like: dog or cat.");

			try
			{
				// Take in user input
				string pref = Console.ReadLine();

				// Instantiate animal node with value input by user
				AnimalNode<string> preferredAnimal = new AnimalNode<string>(pref);

				// Dequeue user's preferred type of animal and store in variable
				AnimalNode<string> dequeuedAnimal = DequeueAnimal(animalShelter, preferredAnimal);

				Console.WriteLine($"dequeuedAnimal is: {dequeuedAnimal.Value}");

			}
			catch (Exception e)
			{

				Console.WriteLine(e);
			}

			Console.ReadLine();
        }

		/// <summary>
		/// Dequeues first node with value of specified animal type
		/// </summary>
		/// <param name="queue1">"animal shelter" queue</param>
		/// <param name="pref">node with value of user's preferred animal</param>
		/// <returns></returns>
		public static AnimalNode<string> DequeueAnimal(AnimalShelter<string> queue1, AnimalNode<string> pref)
		{
			
			// Input validation
			if (pref.Value != "dog" && pref.Value !="cat")
			{
				return null;
			}

			// NOTE: swapping the two lines below in for the third line below makes difference in whether dog can be passed as preferred animal
			//AnimalNode<string> catPreference = new AnimalNode<string>("cat");
			//AnimalShelter<string> queue2 = new AnimalShelter<string>(catPreference);

			AnimalShelter<string> queue2 = new AnimalShelter<string>();
			AnimalNode<string> temp = null;

			if (pref.Value == queue1.Peek().Value)
			{
				return queue1.Peek();
			}
			while (queue1.Front.Next != null)
			{
				if (queue1.Front.Value == pref.Value)
				{
					temp = queue1.Front;
				}
				AnimalNode<string> temp2 = queue1.Front;
				queue1.Front = queue1.Front.Next;
				queue2.Enqueue(temp2.Value);
				Console.WriteLine($"queue2.Front.Value:  {queue2.Peek().Value}");
				Console.WriteLine($"queue2.Rear.Value:  {queue2.Rear.Value}");
			}
			return temp;
		}
	}
}
