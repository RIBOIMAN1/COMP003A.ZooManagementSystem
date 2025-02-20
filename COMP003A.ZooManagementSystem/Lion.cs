using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
	/// <summary>
	/// Showcases a lion, which inherits from the Animal base class.
	/// </summary>
	public class Lion : Animal
	{
		/// <summary>
		/// Shows the user of the program what sound a lion makes.
		/// </summary>
		public override void MakeSound()
		{
			Console.WriteLine("The lion roars!");
		}
	}
}