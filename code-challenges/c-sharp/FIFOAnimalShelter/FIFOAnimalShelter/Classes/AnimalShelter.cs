
namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter<T>
    {
		// Node in animal shelter queue
		public AnimalNode<T> Front { get; set; }
        public AnimalNode<T> Rear { get; set; }

		// Constructor for "animal shelter" queue data structure
		public AnimalShelter(AnimalNode<T> animal)
        {
			Front = animal;
			Rear = animal;
        }

		// Empty constructor for animal shelter queue (so can instantiate empty queue)
		public AnimalShelter()
		{
		}

        /// <summary>
        /// Adds new node with string value "dog" or "cat" to end of queue
        /// </summary>
        /// <param name="animal">string "dog" or "cat"</param>
        public void EnqueueAnimal(AnimalNode<T> animal)
        {
			//AnimalNode<T> newAnimal = new AnimalNode<T>(animal);
			if (Rear == null)
			{
				Front = animal;
				Rear = Front;
			}
            Rear.Next = animal;
            Rear = animal;
        }

		/// <summary>
		/// Removes first node with value of preferred animal ("dog" or "cat") from front of queue
		/// </summary>
		/// <param name="pref">string specifying user's preferred type of animal</param>
		/// <returns>first node with value of user's preferred type of animal</returns>
		public AnimalNode<T> DequeueAnimal(AnimalNode<T> pref)
		{
			// Input validation
			if (Front == null)
			{
				return null;
			}
			if (!pref.Value.Equals("dog") && !pref.Value.Equals("cat"))
			{
				return null;
			}

			// Instantiate empty second queue for use below
			AnimalShelter<T> queue2 = new AnimalShelter<T>();

			if (pref.Value.Equals(Peek().Value))
			{
				return Peek();
			}
			else
			{
				while (Front.Next != null)
				{
					if (Front.Value.Equals(pref.Value))
					{
						return Front;
					}
					AnimalNode<T> temp = Front;
					Front = Front.Next;
					queue2.EnqueueAnimal(temp);
				}
			}
			// Fallback (should never happen)
			return null;
		}

		/// <summary>
		/// Looks at value of front animal node in queue
		/// </summary>
		/// <returns>front animal node in animal shelter queue or null if queue is empty</returns>
		public AnimalNode<T> Peek()
		{
			return Front;
		}
	}
}
