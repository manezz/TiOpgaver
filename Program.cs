using System;
using System.Collections.Generic;

namespace TiOpgaver
{
class Program
	 {
		 static void Main(string[] args)
		 {
			 while (true)
			 {
				 int caseSwitch = 1;
				 switch (caseSwitch)
				 {
					 case 1:
					 Matix_10x10();
					 break;
				 }

				static void Matix_10x10()
				{
					for (int i = 1; i <= 11; i++)
					{
						System.Console.WriteLine();
						for (int u = 1; u <= 10; u++)
						{
							System.Console.Write($" {i * u}");
						}
					}	
				}
				break;
			 }
		 }
	 }
}
