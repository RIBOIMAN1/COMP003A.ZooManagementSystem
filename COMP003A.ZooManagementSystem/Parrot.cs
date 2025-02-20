using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
	/// <summary>
	/// Showcases a parrot, which inherits from the Animal base class.
	/// </summary>
	public class Parrot : Animal
	{
		/// <summary>
		/// Shows the user of the program what sound a parrot makes.
		/// </summary>
		public override void MakeSound()
		{
			Console.WriteLine("The parrot squawks!");
		}
	}
}