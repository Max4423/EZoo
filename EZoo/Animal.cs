using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EZoo
{
	interface IAnimal
	{
		string Name { get; set; }
		int Age { get; set; }
		int EnergyLevel { get; set; }
		int Healthlevel { get; set; }
		public void MakeSound();
		public void Eat();

	}
	internal class Animal : IAnimal
	{
		public Animal(string name, int age, int energeLevel, int healthLevel, string animalSound)
		{
			Name = name;
			Age = age;
			EnergyLevel = energeLevel;
			Healthlevel = healthLevel;
			AnimalSound = animalSound;
		}

		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
			EnergyLevel = 50;
			Healthlevel = 50;
		}
		private string name;
		private int age;
		private int energyLevel;
		private int healthlevel;
		private string animalSound = "default sound";

		public string Name
		{
			get => name;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Name cannot be empty");
				name = value;
				
			}
		}
		public int Age
		{
			get => age;
			set
			{
				if (value < 0)
					throw new ArgumentException("Age cannot be negative");
				age = value;
			}
		}
		public int EnergyLevel { get => energyLevel; set
			{
				if (value < 0)
					throw new ArgumentException("Energy Level cannot be negative");
				if (value > 100)
					value = 100;
				energyLevel = value;
			}
		}
		public int Healthlevel
		{
			get => healthlevel; set
			{
				if (value < 0 || value > 100)
					throw new ArgumentException("Healthlevel cannot be negative or > 100");
				healthlevel = value;
			}
		}

		public string AnimalSound { get => animalSound; 
			set
			{
				animalSound = value;
			}
		}

		public void MakeSound()
		{
			Console.WriteLine(AnimalSound);
		}
		public void Eat()
		{
			Console.Write($"{Name} is eating.");
			EnergyLevel += 10;
			Console.WriteLine($" Energe level is {energyLevel}");

		}

		virtual public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name} Age: {Age} EnergyLevel: {EnergyLevel} Healthlevel: {Healthlevel}, Sound: {AnimalSound}");
		}

	}
}
