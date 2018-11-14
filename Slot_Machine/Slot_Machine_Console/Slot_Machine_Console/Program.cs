using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			//create random number generator
			Random randNumGen = new Random();

			//enter credit amount
			Console.WriteLine("Enter Credite Amount");
			Double credits = Convert.ToDouble(Console.ReadLine());
			Double stakes;

			//Simpe Layout
			Console.WriteLine("******************************************");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Slot Machine Test Program");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Press Spacebar to Roll the slot machine!");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("-------Credits Available: " + credits + "--------------");
			Console.WriteLine("******************************************");


			//Loop until you run out of credite
			while (credits > 0)
			{
				//display credits
				Console.WriteLine("******************************************");
				Console.WriteLine("---$$----Credits Available: " + credits + "-----$$-----");
				Console.WriteLine("******************************************");

				Console.WriteLine("Enter stakes amount");
				stakes = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Press Spacebar to roll");
				//Start roll
				//Call spacebar key and save it in a variable
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				if (keyInfo.Key == ConsoleKey.Spacebar)
				{
					if (stakes <= credits)
					{
						Console.WriteLine("******************************************");
						Console.WriteLine("You stakes " + stakes + "-----$$-----");
						Console.WriteLine("******************************************");

						//When Spacebar pressed credites = Stakes - Credits
						credits = credits - stakes;

						//slots declaration
						string slot1;
						string slot2;
						string slot3;

						//record next 3 numbers in the RandomNumberGenrator
						int randNum1 = randNumGen.Next(10000, 20000);
						int randNum2 = randNumGen.Next(30000, 40000);
						int randNum3 = randNumGen.Next(50000, 60000);

						//divide the three number by 8
						int modR1 = randNum1 % 100;
						int modR2 = randNum2 % 100;
						int modR3 = randNum3 % 100;

						//Define an array and add the slots with their odds
						//1-45 Apple, 46-80 Banana, 81-95,Pineapple, 96-100 Wild 

						string[] slots = new string[100];

						for (int i = 0; i < 45; i++)
							slots[i] = "Apple";
						for (int i = 45; i < 80; i++)
							slots[i] = "Banana";
						for (int i = 80; i < 95; i++)
							slots[i] = "Pinapple";
						for (int i = 95; i < 100; i++)
							slots[i] = "*";
						slot1 = slots[modR1];
						slot2 = slots[modR2];
						slot3 = slots[modR3];

						//Display Slots
						Console.WriteLine("Slot 1: " + slot1);
						Console.WriteLine("Slot 2: " + slot2);
						Console.WriteLine("Slot 3: " + slot3);

						//Win Check
						if ((slot1 == "Apple") && (slot2 == "Apple") && (slot3 == "Apple"))
						{
							//add credits
							credits = credits + (1.2 * stakes) + stakes;
							double winings = credits + (1.2 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "Apple") && (slot3 == "Apple"))
						{
							//add credits
							credits = credits + (0.8 * stakes) + stakes;
							double winings = credits + (0.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Apple") && (slot2 == "*") && (slot3 == "Apple"))
						{
							//add credits
							credits = credits + (0.8 * stakes) + stakes;
							double winings = credits + (0.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Apple") && (slot2 == "Apple") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.8 * stakes) + stakes;
							double winings = credits + (0.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Apple") && (slot2 == "*") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.4 * stakes) + stakes;
							double winings = credits + (0.4 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "Apple") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.4 * stakes) + stakes;
							double winings = credits + (0.4 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "*") && (slot3 == "Apple"))
						{
							//add credits
							credits = credits + (0.4 * stakes) + stakes;
							double winings = credits + (0.4 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}
						else if ((slot1 == "Banana") && (slot2 == "Banana") && (slot3 == "Banana"))
						{
							//add credits
							credits = credits + (1.8 * stakes) + stakes;
							double winings = credits + (1.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "Banana") && (slot3 == "Banana"))
						{
							//add credits
							credits = credits + (1.2 * stakes) + stakes;
							double winings = credits + (1.2 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Banana") && (slot2 == "*") && (slot3 == "Banana"))
						{
							//add credits
							credits = credits + (1.2 * stakes) + stakes;
							double winings = credits + (1.2 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Banana") && (slot2 == "Banana") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (1.2 * stakes) + stakes;
							double winings = credits + (1.2 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Banana") && (slot2 == "*") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.6 * stakes) + stakes;
							double winings = credits + (0.6 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "Banana") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.6 * stakes) + stakes;
							double winings = credits + (0.6 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "*") && (slot3 == "Banana"))
						{
							//add credits
							credits = credits + (0.6 * stakes) + stakes;
							double winings = credits + (0.6 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Pinapple") && (slot2 == "Pinapple") && (slot3 == "Pinapple"))
						{
							//add credits
							credits = credits + (2.4 * stakes) + stakes;
							double winings = credits + (2.4 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "Pinapple") && (slot3 == "Pinapple"))
						{
							//add credits
							credits = credits + (1.6 * stakes) + stakes;
							double winings = credits + (1.6 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Pinapple") && (slot2 == "*") && (slot3 == "Pinapple"))
						{
							//add credits
							credits = credits + (1.6 * stakes) + stakes;
							double winings = credits + (1.6 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Pinapple") && (slot2 == "Pinapple") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (1.6 * stakes) + stakes;
							double winings = credits + (1.6 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "Pinapple") && (slot2 == "*") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.8 * stakes) + stakes;
							double winings = credits + (0.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "Pinapple") && (slot3 == "*"))
						{
							//add credits
							credits = credits + (0.8 * stakes) + stakes;
							double winings = credits + (0.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else if ((slot1 == "*") && (slot2 == "*") && (slot3 == "Pinapple"))
						{
							//add credits
							credits = credits + (0.8 * stakes) + stakes;
							double winings = credits + (0.8 * stakes) - credits;
							//display Win
							Console.WriteLine("YOU WIN!! $$$$$$$$$ " + winings + " CREDITS $$$$$$$$");
						}

						else
						{
							Console.WriteLine("Bust");
						}
					}

					else
					{
						//Player lost display message
						Console.WriteLine("insufficient Credits");
					}
				}

				else
				{
					Console.WriteLine("Wrong Key!----please press Spacebar");
					//store keyinfo in readkey
					keyInfo = Console.ReadKey(true);
				}
			}
		}
	}
}
