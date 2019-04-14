using FIFOAnimalShelter;
using FIFOAnimalShelter.Classes;
using Xunit;

namespace XUnit_FIFOAnimalShelter
{
    public class UnitTest1
    {
		/// <summary>
		/// Tests for "happy path": verifies DequeueAnimal method can correctly return selected animal
		/// </summary>
		[Fact]
        public void CanReturnPreferredAnimal()
        {
			// Arrange
			AnimalNode<string> catPreference = new AnimalNode<string>("cat");
			AnimalShelter<string> animalShelter = new AnimalShelter<string>(catPreference);

			// Act
			AnimalNode<string> dequeuedAnimal = animalShelter.DequeueAnimal(catPreference);

			// Assert
			Assert.Equal("cat", dequeuedAnimal.Value);
		}

		/// <summary>
		/// Tests for expected failure if anything other than "cat" or "dog" is passed as preferred animal argument
		/// </summary>
		[Fact]
		public void CanReturnNullIfNeitherDogNorCatPassedInAsPreferredAnimal()
		{
			// Arrange
			AnimalNode<string> badPreference = new AnimalNode<string>("bird");
			AnimalNode<string> legitPreference = new AnimalNode<string>("cat");
			AnimalShelter<string> animalShelter = new AnimalShelter<string>();
			animalShelter.EnqueueAnimal(legitPreference);

			// Act
			AnimalNode<string> dequeuedAnimal = animalShelter.DequeueAnimal(badPreference);

			// Assert
			Assert.Null(dequeuedAnimal);
		}

		/// <summary>
		/// Tests for edge case of trying to dequeue from empty queue
		/// </summary>
		[Fact]
		public void CanReturnNullWhenTryingToDequeueFromEmptyQueue()
		{
			// Arrange
			AnimalNode<string> preference = new AnimalNode<string>("cat");
			AnimalShelter<string> animalShelter = new AnimalShelter<string>();

			// Act
			AnimalNode<string> dequeuedAnimal = animalShelter.DequeueAnimal(preference);

			// Assert
			Assert.Null(dequeuedAnimal);
		}
	}
}
