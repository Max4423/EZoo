using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZoo
{
	internal class Menu
	{
		int maxMenuItemId = 4;
		int choice = 0;
		List<string> menuItems = new List<string>
				{
			"Add new animal",
			"Feed animal",
			"Show animals list",
			"Exit"
		};

		public void GetUserChoice()
		{
			Console.Write("Enter your choice: ");
			while (choice == 0)
			{
				string input = Console.ReadLine();
				if (!int.TryParse(input, out choice) || choice <= 0 || choice > maxMenuItemId)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Reenter your choice:");
					Console.ResetColor();
					choice = 0;
				}
			}
		}

		public void DisplayMenu()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Zoo management menu");
			Console.WriteLine("===================");
			Console.ResetColor();

			for (int i = 0; i < menuItems.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {menuItems[i]}");
			}


		}

		public void ProcessChoice()
		{

			switch (choice)
			{
				case 1:
					Zoo.AddAnimal();
					break;
				case 2:
					Zoo.FeedAnimal();
					break;
				case 3:
					Zoo.ShowAnimalsList();
					break;
				case 4:
					Console.WriteLine("Program terminating...");
					Environment.Exit(1);
					break;
				default:
					break;

			}
			choice = 0;
			Console.Write("Press any key to continue: ");
			Console.ReadKey();
		}
	}

}


