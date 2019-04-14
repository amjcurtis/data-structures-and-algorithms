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

			// Populate shelter with mix of dogs and cats
			animalShelter.EnqueueAnimal(dogPreference);
			animalShelter.EnqueueAnimal(dogPreference);
			animalShelter.EnqueueAnimal(catPreference);
			animalShelter.EnqueueAnimal(dogPreference);
			animalShelter.EnqueueAnimal(dogPreference);
			
			Console.WriteLine("");
			Console.WriteLine($"Front: {animalShelter.Front.Value}");
			Console.WriteLine($"Rear: {animalShelter.Rear.Value}");
			Console.WriteLine("");

			///////////////////////////////////////////
			// Beginning of console app UI
			///////////////////////////////////////////
			
			Console.WriteLine("Please enter the animal you would like: dog or cat.");

			try
			{
				// Take in user input
				string pref = Console.ReadLine();

				while (pref.ToLower() != "dog" && pref.ToLower() != "cat")
				{
					Console.WriteLine("Please choose either 'dog' or 'cat'. Or press 'X' to exit the program.");
					pref = Console.ReadLine();
					if (pref.ToLower() == "x")
					{
						Environment.Exit(0);
					}
				}

				// Instantiate animal node with value input by user
				AnimalNode<string> preferredAnimal = new AnimalNode<string>(pref);

				// Dequeue user's preferred type of animal and store in variable
				AnimalNode<string> dequeuedAnimal = DequeueAnimal(animalShelter, preferredAnimal);

				Console.WriteLine($"You've successfully gotten your new {dequeuedAnimal.Value} from the shelter!\n");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
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
			if (queue1.Front == null)
			{
				return null;
			}
			if (pref.Value != "dog" && pref.Value != "cat")
			{
				return null;
			}


			// Instantiate empty second queue for use below
			AnimalShelter<string> queue2 = new AnimalShelter<string>();

			if (pref.Value == queue1.Peek().Value)
			{
				return queue1.Peek();
			}
			else
			{
				while (queue1.Front.Next != null)
				{
					if (queue1.Front.Value == pref.Value)
					{
						return queue1.Front;
					}
					AnimalNode<string> temp = queue1.Front;
					queue1.Front = queue1.Front.Next;
					queue2.EnqueueAnimal(temp);
				}
			}
			// Fallback (should never happen)
			return null;
		}
	}
}
