using EZoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZoo
{

	internal class Zoo
	{
		static List<Animal> animals = new List<Animal>();
		static List<string> animalTypes = new List<string>() { "Animal", "Fish" };

		public static void AddAnimal()
		{
			int type;
			while (true)
			{
				for (int i = 0; i < animalTypes.Count; i++)
				{
					Console.WriteLine($"[{i}] {animalTypes[i]}");
				}
				Console.Write("Enter animal type id: ");


				if (int.TryParse(Console.ReadLine(), out type) && type >= 0 && type < animalTypes.Count)
					break;
				Console.WriteLine($"Animal type  cannot be empty or < 0 or > {animalTypes.Count} Try again.");
			}
			string name;

			while (true)
			{
				Console.Write("Enter animal name: ");
				name = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(name))
					break;
				Console.WriteLine("Name cannot be empty. Try again.");
			}

			int age;
			while (true)
			{
				Console.Write("Enter animal age: ");
				if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
					break;
				Console.WriteLine("Invalid age. Please enter a non-negative number.");
			}

			int energyLevel;
			while (true)
			{
				Console.Write("Enter animal energy level (0-100): ");
				if (int.TryParse(Console.ReadLine(), out energyLevel) && energyLevel >= 0 && energyLevel <= 100)
					break;
				Console.WriteLine("Invalid energy level. Enter a number between 0 and 100.");
			}

			int healthLevel;
			while (true)
			{
				Console.Write("Enter animal health level (0-100): ");
				if (int.TryParse(Console.ReadLine(), out healthLevel) && healthLevel >= 0 && healthLevel <= 100)
					break;
				Console.WriteLine("Invalid health level. Enter a number between 0 and 100.");
			}

			string animalSound;
			while (true)
			{
				Console.Write("Enter animal sound: ");
				animalSound = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(animalSound))
					break;
				Console.WriteLine("Sound cannot be empty. Try again.");
			}
			if (type == 0)
			{
				animals.Add(new Animal(name, age, energyLevel, healthLevel, animalSound));

			}

			if (type == 1)
			{
				int swimmingSpeed;
				while (true)
				{
					Console.Write("Enter fish swimming speed: ");
					if (int.TryParse(Console.ReadLine(), out swimmingSpeed) && swimmingSpeed >= 0 && swimmingSpeed <= 100)
						break;
					Console.WriteLine("Invalid swimming speed. Enter a number between 0 and 100.");
				}
				animals.Add(new Fish(name, age, energyLevel, healthLevel, animalSound, swimmingSpeed));
			}
			Console.WriteLine("Animal added successfully!");

			animals[animals.Count - 1].ShowInfo();

		}

		public static void FeedAnimal()
		{
			if (animals.Count > 0)
			{
				for (int i = 0; i < animals.Count; i++)
				{
					Console.WriteLine($"[{i}] {animals[i].Name}");
				}
				Console.Write("Select animal to Feed(Press -1 to exit):");
				int choice;

				while (true)
				{

					if ((int.TryParse(Console.ReadLine(), out choice) && choice >= -1 && choice < animals.Count))
					{
						break;
					}
					Console.Write("Invalid choice. Please enter an animal from list:");

				}
				if (choice == -1)
				{
					return;
				}
				animals[choice].Eat();
			}
			else
				Console.WriteLine("Zoo is empty");
		}

		public static void ShowAnimalsList()
		{
			if (animals.Count > 0)
			{
				for (int i = 0; i < animals.Count; i++)
				{
					Console.Write($"[{i}] ");
					animals[i].ShowInfo();
				}
			}


			else
				Console.WriteLine("Zoo is empty");
		}

		public static void Swim()
		{
			int choice;
			List<Fish> fish = new List<Fish>();
			for (int i = 0; i < animals.Count; i++)
			{
				if (animals[i] is Fish)
				{
					fish.Add((Fish)animals[i]);
				}
			}
			if (fish.Count == 0)
			{
				Console.WriteLine("There is not available fish!");
				return;
			}

			Console.WriteLine("Available fish:");
			for (int i = 0; i < fish.Count; i++)
			{
				Console.WriteLine($"[{i}]. {fish[i].Name}");
			}
			Console.Write("Enter your choice: ");

			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out choice) && choice >=0 && choice < fish.Count)
				{
					break;
				}
				Console.WriteLine("Invalid choice. Please enter a fish from list:");
			}

			fish[choice].Swim();
		}
	}
}

