using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZoo
{
	internal class Fish: Animal
	{
		int swimmingSpeed;
		public int SwimmingSpeed { get => swimmingSpeed; 
			set
			{
				if (value < 0)
					throw new ArgumentException("Swimming speed cannot be negative");

				swimmingSpeed = value;
			}
		}

		public Fish(string name, int age, int energeLevel, int healthLevel, string animalSound, int swimmingSpeed) : base(name,age, energeLevel, healthLevel, animalSound)
		{
			SwimmingSpeed = swimmingSpeed;
		}

		public void Swim()
		{
			Console.WriteLine($"Fish {Name} is swimming with speed {swimmingSpeed} km/h");
		}

		override public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name} Age: {Age} EnergyLevel: {EnergyLevel} Healthlevel: {Healthlevel}, Sound: {AnimalSound}, Swimming speed: {swimmingSpeed}");
		}
	}
}
