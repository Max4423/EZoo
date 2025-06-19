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

		public static void AddAnimal()
		{
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

			animals.Add(new Animal(name, age, energyLevel, healthLevel, animalSound));
			Console.WriteLine("Animal added successfully!");

			animals[0].ShowInfo();

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
	}
}


//1.Add new animal
//2.Feed animal
//3. Show animals list
//4. Exit