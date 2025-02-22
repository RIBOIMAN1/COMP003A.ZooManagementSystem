using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
	public class ZooUtility
	{
		/// <summary>
		/// Uses an animal's name to describe it.
		/// </summary>
		/// <param name="name">Animal's name</param>
		public void DescribeAnimal(string name)
		{
			Console.WriteLine("DescribeAnimal (name only):");
			Console.WriteLine($"Animal Name: {name}");
		}
		/// <summary>
		/// Uses both the name and species of an animal to describe it.
		/// </summary>
		/// <param name="name">Animal's name</param>
		/// <param name="species">Animal's species</param>
		public void DescribeAnimal(string name, string species)
		{
			Console.WriteLine("DescribeAnimal (name and species):");
			Console.WriteLine($"Animal Name: {name}, Species: {species}");
		}
		/// <summary>
		/// Uses the name, species, and the age of an animal to describe it.
		/// </summary>
		/// <param name="name">Animal's name</param>
		/// <param name="species">Animal's species</param>
		/// <param name="age">Animal's age</param>
		public void DescribeAnimal(string name, string species, int age)
		{
			Console.WriteLine("DescribeAnimal (name, species, and age):");
			Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old");
		}
	}
}