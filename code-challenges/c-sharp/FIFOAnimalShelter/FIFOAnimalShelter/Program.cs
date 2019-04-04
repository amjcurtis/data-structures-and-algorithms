using System;
using FIFOAnimalShelter.Classes;

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
		/// <param name="animalShelterQueue">"animal shelter" queue</param>
		/// <param name="pref">node with value of user's preferred animal</param>
		/// <returns></returns>
		public static AnimalNode<string> DequeueAnimal(AnimalShelter<string> animalShelterQueue, AnimalNode<string> pref)
		{
			
			// Input validation
			if (pref.Value != "dog" && pref.Value !="cat")
			{
				return null;
			}

			AnimalShelter<string> queue2 = new AnimalShelter<string>();
			AnimalNode<string> temp = null;

			if (pref.Value == animalShelterQueue.Peek().Value)
			{
				return animalShelterQueue.Peek();
			}
			while (animalShelterQueue.Front.Next != null)
			{
				if (animalShelterQueue.Front.Value.Equals(pref.Value))
				{
					temp = animalShelterQueue.Front;
				}
				AnimalNode<string> temp2 = animalShelterQueue.Front;
				animalShelterQueue.Front = animalShelterQueue.Front.Next;
				queue2.Enqueue(temp2.Value);
				Console.WriteLine($"queue2.Front.Value:  {queue2.Peek().Value}");
				Console.WriteLine($"queue2.Rear.Value:  {queue2.Rear.Value}");
			}
			return temp;
		}
	}
}
