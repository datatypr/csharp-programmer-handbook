/*
 * C# Programmers Pocket Consultant
 * Author: Gregory S. MacBeth
 * Email: gmacbeth@comporium.net
 * Create Date: June 27, 2003
 * Last Modified Date:
 */
using System;

namespace Client.Chapter_5___Building_Your_Own_Classes
{
	class CTOR
	{
		public int[] MyIntArray;
		public int Y;
		//Initialization can take place here
		private int ObjectCount = 0;
		static void Main(string[] args)
		{
			CTOR X = new CTOR();

			X.ObjectCount++;

			CTOR YY = new CTOR(10);
		}
		//Default CTOR
		CTOR()
		{
			MyIntArray = new int[10];
			//Do work necessary during object creation
		}
		//Overloads the CTOR allowing you to initialize Y
		CTOR(int myY)
		{
			Y = myY;
		}
	}
}



