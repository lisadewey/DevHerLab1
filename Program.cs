using System;

namespace DevHerLab1
{
    class Program
    {
        static void Main(string[] args)
        {
			string dashes = new string('-', 119);
			string header = "Let's calculate the area and perimeter of the Grand Circus classrooms!";
			bool Continue;
			while(true)
			{
			Console.WriteLine(dashes);
			Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, Console.CursorTop);
			Console.WriteLine(header);
			Console.WriteLine(dashes);

			Console.WriteLine();
			Console.Write("Please enter the length of your classroom: ");
			decimal length = decimal.Parse(Console.ReadLine());
			Console.Write("Please enter the width of your classroom: ");
			decimal width = decimal.Parse(Console.ReadLine());

			decimal area = length * width;
			decimal perimeter = 2 * (length + width);

			Console.WriteLine();
			Console.WriteLine($"The area of your classroom is: {area}");
			Console.WriteLine($"The perimeter of your classroom is: {perimeter}");
			Console.WriteLine();

			Console.WriteLine("Would you like to calculate the area and perimeter of another classroom?");
			Console.Write("Y or N? ");
				if (Console.ReadLine() == "y")
						{
					Continue = true;
				}
				else
				{
					Environment.Exit(0);
				}

		

				




			//Console.Write("Enter the length of the classroom:");
			//double length = Convert.ToDouble(Console.ReadLine());
			//Console.Write("Enter the width of the classroom:");
			//double width = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("P = {0}", 2 * (width + length));
			//Console.WriteLine("A = {0}", width * length);

		}
	}
    
}
}
