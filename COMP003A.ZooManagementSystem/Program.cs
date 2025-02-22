// Author: [Your Name]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{

	public class Program
	{
		static void Main(string[] args)
		{
			List<Animal> animals = new List<Animal>();
			ZooUtility utility = new ZooUtility();
			bool programActive = true;
			while (programActive)
			{
				try
				{
					Console.WriteLine("Welcome to the Zoo Management System!");
					Console.WriteLine("\nPlease choose an option:");
					Console.WriteLine("1. Add a Lion");
					Console.WriteLine("2. Add a Parrot");
					Console.WriteLine("3. Display All Animals");
					Console.WriteLine("4. Describe an Animal");
					Console.WriteLine("5. Exit");
					Console.Write("\nYour choice: ");
					int choice = int.Parse(Console.ReadLine());
					if (choice == 1)
					{
						AddAnimal(animals, new Lion());
					}
					else if (choice == 2)
					{
						AddAnimal(animals, new Parrot());
					}
					else if (choice == 3)
					{
						DisplayAllAnimals(animals);
					}
					else if (choice == 4)
					{
						DescribeAnimalMenu(utility);
					}
					else if (choice == 5)
					{
						programActive = false;
						Console.WriteLine("Thank you for using the Zoo Management System!");
					}
					else
					{
						Console.WriteLine("Your choice is invalid, please choose a number between 1 and 5.");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
			}
		}
		/// <summary>
		/// Adds animal to zoo.
		/// </summary>
		/// <param name="animals">Animal list</param>
		/// <param name="animal">Animal to add</param>
		private static void AddAnimal(List<Animal> animals, Animal animal)
		{
			Console.Write($"Enter the name of the {animal.GetType().Name.ToLower()}: ");
			animal.Name = Console.ReadLine();
			Console.Write($"Enter the species of the {animal.GetType().Name.ToLower()}: ");
			animal.Species = Console.ReadLine();
			animals.Add(animal);
			Console.WriteLine($"\n{animal.GetType().Name} added successfully!");
		}
		/// <summary>
		/// Displays a list of animals in the zoo and shows their details.
		/// </summary>
		/// <param name="animals">Animals to display</param>
		private static void DisplayAllAnimals(List<Animal> animals)
		{
			if (animals.Count == 0)
			{
				Console.WriteLine("\nThere are not any animals in the zoo yet.");
			}
			else
			{
				Console.WriteLine("\nDisplaying all animals:");
				foreach (var animal in animals)
				{
					animal.MakeSound();
					Console.WriteLine($"({animal.Name}, {animal.Species})");
				}
			}
		}
		/// <summary>
		/// Handles shown details for animals.
		/// </summary>
		/// <param name="utility">Describes animals using ZooUtility.</param>
		private static void DescribeAnimalMenu(ZooUtility utility)
		{
			Console.WriteLine("\nPick an animal to describe below:");
			Console.WriteLine("1. Lion");
			Console.WriteLine("2. Parrot");
			Console.Write("\nYour choice: ");
			int choice = int.Parse(Console.ReadLine());
			Console.Write("What is the animal's age? ");
			int age = int.Parse(Console.ReadLine());
			if (age < 0)
			{
				throw new ArgumentException("The age cannot be less than 0, try again.");
			}
			if (choice == 1)
			{
				utility.DescribeAnimal($"Lion", age);
			}
			else if (choice == 2)
			{
				utility.DescribeAnimal("Parrot", age);
			}
			else
			{
				Console.WriteLine("This is an invalid choice of animal, try again.");
			}
		}
	}
}