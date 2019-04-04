using FIFOAnimalShelter;
using FIFOAnimalShelter.Classes;
using Xunit;

namespace XUnit_FIFOAnimalShelter
{
    public class UnitTest1
    {
		/// <summary>
		/// Tests whether DequeueAnimal method can correctly return selected animal
		/// </summary>
		[Fact]
        public void CanReturnPreferredAnimal()
        {
			// Arrange
			AnimalNode<string> catPreference = new AnimalNode<string>("cat");
			AnimalShelter<string> animalShelter = new AnimalShelter<string>(catPreference);

			// Act
			AnimalNode<string> dequeuedAnimal = Program.DequeueAnimal(animalShelter, catPreference);

			// Assert
			Assert.Equal("cat", dequeuedAnimal.Value);

		}

		[Fact]
		public void CanReturnNullIfNeitherDogNorCatPassedInAsPreferredAnimal()
		{
			// Arrange
			AnimalNode<string> badPreference = new AnimalNode<string>("bird");
			AnimalShelter<string> animalShelter = new AnimalShelter<string>(badPreference);

			// Act
			AnimalNode<string> dequeuedAnimal = Program.DequeueAnimal(animalShelter, badPreference);

			// Assert
			Assert.Null(dequeuedAnimal);
		}
	}
}
