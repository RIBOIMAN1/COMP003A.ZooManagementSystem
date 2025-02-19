// Author: [Your Name]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#

namespace COMP003A.ZooManagementSystem
{

	internal class Program
    {
		while (programActive)
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo Management System!");
			Console.WriteLine("\nPlease choose an option:");
			Console.WriteLine("1. Add a Lion");
			Console.WriteLine("2. Add a Parrot");
			Console.WriteLine("3. Display All Animals");
			Console.WriteLine("4. Describe an Animal");
			Console.WriteLine("5. Exit");
			Console.Write("\nYour choice: ");
			string choice = Console.ReadLine();
			// if command choice 1
			if (choice == "1")
			{
				
			}
			else if (choice == "2")
			{
				
			}
			else if (choice == "3")
			{
				
			}
			else if (choice == "4")
			{
				
			}
			else if (choice == "5")
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