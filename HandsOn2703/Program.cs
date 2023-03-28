using System.ComponentModel;

namespace HandsOn2703 { 



    public class HandsOn2704
    {

        public static void Main(string[] args)
        {
            int rows = Convert.ToInt32(Console.ReadLine()), cols = Convert.ToInt32(Console.ReadLine());

            List<List<int>> matrix = new();

            for (int i = 0; i < rows; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < cols; j++)
                {
                    matrix[i].Add(Convert.ToInt32(Console.ReadLine()));
                }
            }

            int totalCovered = 0, rowIndex = 0, colIndex = cols - 1;

            while (totalCovered < rows * cols)
            {
                //right
                for (int i = rowIndex; i <= colIndex; i++)
                {
                    Console.Write(matrix[rowIndex][i] + " ");
                    totalCovered++;
                }
                //down
                for (int i = rowIndex + 1; i <= colIndex; i++)
                {
                    Console.Write(matrix[i][colIndex] + " "); ;
                    totalCovered++;
                }
                //left
                for (int i = colIndex - 1; i >= rowIndex; i--)
                {
                    Console.Write(matrix[colIndex][i] + " ");
                    totalCovered++;
                }
                //up
                for (int i = colIndex - 1; i >= rowIndex + 1; i--)
                {
                    Console.Write(matrix[i][rowIndex] + " ");
                    totalCovered++;
                }
                rowIndex++;
                colIndex--;
            }
        }
    }
}