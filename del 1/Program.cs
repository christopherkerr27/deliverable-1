using System;

namespace Deliverable1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous?");
			string vacationType = Console.ReadLine();
			Console.Write("How many are in your group?");
			int groupSize = Convert.ToInt32(Console.ReadLine());
			if (vacationType == "musical")
			{
				string destination = "New Orleans";
			}
			else if (vacationType == "tropical")
			{
				string destination = "Beach Vacation in Mexicoo";
			}
			else
			{
				string destination = "Whitewater Rafting the Grand Canyon";
			}

			if (groupSize >= 6)
			{
				string travelSuggestion = "Charter Flight";
			}
			else if (groupSize <= 5 && groupSize >= 3)
			{
				string travelSuggestion = "Helicopter";
			}
			else
			{
				string travelSuggestion = "First Class";
			}

			string result = $"Since you’re a group of {groupSize} going on a musical vacation, you should take a {travelSuggestion} to {destination}.";
		}
	}
}