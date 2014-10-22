using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
	public class Mines
	{
		public class Dots
		{
            public string name;
			public int numOfDots;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

            public int NumOfDots
			{
				get { return numOfDots; }
				set { numOfDots = value; }
			}

            public Dots() { }

			public Dots(string name, int numOfDots)
			{
				this.name = name;
				this.numOfDots = numOfDots;
			}
		}

		static void Main()
		{
			string command = string.Empty;
			char[,] field = CreatePlayingField();
			char[,] bombs = InsertBombs();
			int counter = 0;
			bool explode = false;
            List<Dots> champions = new List<Dots>(6);
			int row = 0;
			int col = 0;
			bool flag = true;
			const int maximum = 35;
			bool flag2 = false;

			do
			{
				if (flag)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh fieldteta bez mini4ki." +
					" command 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					Result(field);
					flag = false;
				}
				Console.Write("Daj row i col : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out col) &&
						row <= field.GetLength(0) && col <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						Ranking(champions);
						break;
					case "restart":
						field = CreatePlayingField();
						bombs = InsertBombs();
						Result(field);
						explode = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[row, col] != '*')
						{
							if (bombs[row, col] == '-')
							{
								YourTurn(field, bombs, row, col);
								counter++;
							}
							if (maximum == counter)
							{
								flag2 = true;
							}
							else
							{
								Result(field);
							}
						}
						else
						{
							explode = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna command\n");
						break;
				}
				if (explode)
				{
					Result(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", counter);
					string niknejm = Console.ReadLine();
					Dots t = new Dots(niknejm, counter);
					if (champions.Count < 5)
					{
						champions.Add(t);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
							if (champions[i].numOfDots < t.numOfDots)
							{
								champions.Insert(i, t);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
                    champions.Sort((Dots r1, Dots r2) => r2.name.CompareTo(r1.name));
                    champions.Sort((Dots r1, Dots r2) => r2.numOfDots.CompareTo(r1.numOfDots));
					Ranking(champions);

					field = CreatePlayingField();
					bombs = InsertBombs();
					counter = 0;
					explode = false;
					flag = true;
				}
				if (flag2)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					Result(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string name = Console.ReadLine();
                    Dots playerDots = new Dots(name, counter);
					champions.Add(playerDots);
					Ranking(champions);
					field = CreatePlayingField();
					bombs = InsertBombs();
					counter = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void Ranking(List<Dots> playerDots)
		{
			Console.WriteLine("\nTo4KI:");
			if (playerDots.Count > 0)
			{
				for (int i = 0; i < playerDots.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, playerDots[i].name, playerDots[i].numOfDots);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void YourTurn(char[,] field,
			char[,] bombs, int row, int col)
		{
			char howMuchbombs = HowMuch(bombs, row, col);
			bombs[row, col] = howMuchbombs;
			field[row, col] = howMuchbombs;
		}

		private static void Result(char[,] board)
		{
			int RRR = board.GetLength(0);
			int KKK = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < RRR; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < KKK; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayingField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] InsertBombs()
		{
			int rows = 5;
			int columns = 10;
			char[,] playingField = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					playingField[i, j] = '-';
				}
			}

			List<int> randomNums = new List<int>();
			while (randomNums.Count < 15)
			{
				Random random = new Random();
				int randomNum = random.Next(50);
				if (!randomNums.Contains(randomNum))
				{
					randomNums.Add(randomNum);
				}
			}

			foreach (int number in randomNums)
			{
				int column = (number / columns);
				int row = (number % columns);
				if (row == 0 && number != 0)
				{
					column--;
					row = columns;
				}
				else
				{
					row++;
				}
				playingField[column, row - 1] = '*';
			}

			return playingField;
		}

		private static void CalculateField(char[,] field)
		{
			int column = field.GetLength(0);
			int row = field.GetLength(1);

			for (int i = 0; i < column; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (field[i, j] != '*')
					{
						char howMuch = HowMuch(field, i, j);
						field[i, j] = howMuch;
					}
				}
			}
		}

		private static char HowMuch(char[,] charArr, int numOne, int numTwo)
		{
			int count = 0;
			int rows = charArr.GetLength(0);
			int columns = charArr.GetLength(1);

			if (numOne - 1 >= 0)
			{
				if (charArr[numOne - 1, numTwo] == '*')
				{ 
					count++; 
				}
			}
			if (numOne + 1 < rows)
			{
				if (charArr[numOne + 1, numTwo] == '*')
				{ 
					count++; 
				}
			}
			if (numTwo - 1 >= 0)
			{
				if (charArr[numOne, numTwo - 1] == '*')
				{ 
					count++;
				}
			}
			if (numTwo + 1 < columns)
			{
				if (charArr[numOne, numTwo + 1] == '*')
				{ 
					count++;
				}
			}
			if ((numOne - 1 >= 0) && (numTwo - 1 >= 0))
			{
				if (charArr[numOne - 1, numTwo - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((numOne - 1 >= 0) && (numTwo + 1 < columns))
			{
				if (charArr[numOne - 1, numTwo + 1] == '*')
				{ 
					count++; 
				}
			}
			if ((numOne + 1 < rows) && (numTwo - 1 >= 0))
			{
				if (charArr[numOne + 1, numTwo - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((numOne + 1 < rows) && (numTwo + 1 < columns))
			{
				if (charArr[numOne + 1, numTwo + 1] == '*')
				{ 
					count++; 
				}
			}
			return char.Parse(count.ToString());
		}
	}
}
