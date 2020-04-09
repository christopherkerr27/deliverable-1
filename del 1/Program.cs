using System;

namespace Deliverable1
{
	public class Program
	{
		public static void Main()
		{
			string travelSuggestion = "";
			string destination = "";
			Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous?");
			string vacationType = Console.ReadLine();
			Console.Write("How many are in your group?");
			int groupSize = Convert.ToInt32(Console.ReadLine());
			if (vacationType == "musical")
			{
				destination = "New Orleans";
			}
			else if (vacationType == "tropical")
			{
				destination = "Beach Vacation in Mexicoo";
			}
			else
			{
				destination = "Whitewater Rafting the Grand Canyon";
			}

			if (groupSize >= 6)
			{
				travelSuggestion = "Charter Flight";
			}
			else if (groupSize <= 5 && groupSize >= 3)
			{
				travelSuggestion = "Helicopter";
			}
			else
			{
				travelSuggestion = "First Class";
			}

			string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " you should take a " + travelSuggestion + " to " + destination;
			Console.Write(result);
		}
	}
}