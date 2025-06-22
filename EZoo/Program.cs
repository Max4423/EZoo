namespace EZoo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var menu = new Menu();

			while(true)
			{ 
			menu.DisplayMenu();

			menu.GetUserChoice();

			menu.ProcessChoice();
}
		}
	}
}
