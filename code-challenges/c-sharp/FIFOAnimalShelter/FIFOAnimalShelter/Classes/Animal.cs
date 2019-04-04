using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
	public class AnimalNode<T>
	{
		public T Value { get; set; }

		public AnimalNode<T> Next { get; set; }
	
		// Node constructor for "animal shelter" queue data structure
		public AnimalNode(T value)			{
			Value = value;
			// Next = null;
		}
	}
}
