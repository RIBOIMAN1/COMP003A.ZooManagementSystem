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
			Console.Write($"Enter the name of the {animal.GetType().Name.ToLower()}: ");
			animal.Species = Console.ReadLine();
			animals.Add(animal);
			Console.WriteLine($"\n{animal.GetType().Name} added successfully!");
		}
	}
}