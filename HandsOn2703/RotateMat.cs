using System;
using System.Data;

public class Class1
{

	public static void Main(string[]args)
	{
		//int rows = 2, cols = 2;


		List<List<int>>matrix=new List<List<int>>() {
			new List<int>{ 1,2,3},
			new List<int>{ 4,5,6},
			new List<int>{ 7,8,9}
		};


		int[, ] newMatrix = new int[3, 3];

		for(int i=0;i<3; i++)
		{
			int columnNumber = 3 - i - 1;
			for(int rowNumber = 0; rowNumber < 3; rowNumber++)
			{
				newMatrix[rowNumber,columnNumber] = matrix[i][rowNumber];
			}
			{

			}
		}

		for(int  i=0;i<3;i++)
		{
			for (int j =0;j<3;j++)
				Console.Write(newMatrix[i,j] + " ");
			Console.WriteLine();
		}
		

	}
}
