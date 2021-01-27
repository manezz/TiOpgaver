using System;

namespace TiOpgaver
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Skriv opgave nummer");
				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 0:
						return;

					case 1:
						Matix_10x10();
						break;
					case 2:
						FindHojesteTal();
						break;
					case 3:
						FindLigeTal();
						break;
					case 4:
						StrengIOmvendtRaekkefolge();
						break;
					case 5:
						Palindrom();
						break;
					case 6:
						AntalOrd();
						break;
				}

				// opgave 1
				static void Matix_10x10()
				{
					for (int i = 1; i <= 10; i++)
					{
						Console.WriteLine();
						for (int u = 1; u <= 10; u++)
						{
							Console.Write($" {i * u}");
						}
					}
					Console.ReadLine();
				}

				// ogpave 2
				static void FindHojesteTal()
				{
					int[] tal = {32, 245,531, 232, 74, 147};
					int storsteTal = 0;

					foreach (int i in tal)
					{
						if (storsteTal < i)
						{
							storsteTal = i;
						}
					}
					Console.WriteLine(storsteTal);
					Console.ReadLine();
				}

				// opgave 3
				static void FindLigeTal()
				{
					for (int i = 1; i <= 100; i++)
					{
						if (i % 2 != 0)
						{
							Console.WriteLine(i);
						}
					}
					Console.ReadLine();
				}

				// opgave 4
				static void StrengIOmvendtRaekkefolge()
				{
					string input = "qwerty";
					string output = "";
					char[] array = input.ToCharArray();
					Array.Reverse(array);
					foreach (char c in array)
					{
						output += c;
					}
					Console.WriteLine();
					Console.WriteLine($"{input} => {output}");
					Console.ReadLine();
				}

				// opgave 5
				static void Palindrom()
				{
					Console.WriteLine("Skriv et ord");
					string input = Console.ReadLine();
					string output = "";
					char[] array = input.ToCharArray();
					Array.Reverse(array);
					foreach (char c in array)
					{
						output += c;
					}
					Console.WriteLine();
					if (input == output)
					{
						Console.WriteLine($"{input} => True");
					}
					else
					{
						Console.WriteLine($"{input} => False");
					}
					Console.ReadLine();
				}

				// opgave 6
				static void AntalOrd()
				{
					Console.WriteLine("Skriv en saetning");
					string input = Console.ReadLine();
					string[] output = input.Split(" ");
					Console.WriteLine($"Antal ord = {output.Length}");
				}

			}
		}
	}
}