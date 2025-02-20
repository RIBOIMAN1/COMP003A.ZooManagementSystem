using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
	/// <summary>
	/// Abstract class for all animals, containing properties and methods for animals.
	/// </summary>
	public abstract class Animal
	{
		private string _name;
		private string _species;
		/// <summary>
		/// Obtains animal name.
		/// </summary>
		/// <exception cref="ArgumentException">Exception for null or white space text.</exception>
		public string Name
		{
			get => _name;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Empty and null inputs are invalid, try again.");
				_name = value;
			}
		}
		/// <summary>
		/// Obtains animal species.
		/// </summary>
		/// <exception cref="ArgumentException">Exception for null or white space text.</exception>
		public string Species
		{
			get => _species;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Empty and null inputs are invalid, try again.");
				_species = value;
			}
		}
		public abstract void MakeSound();
	}
}