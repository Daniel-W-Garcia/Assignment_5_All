// Given a 2D array matrix find the sum of the right diag
// right diag = end of array 1 and beginning of last array and any number in between that falls on that line
// add up all nums that are on the diag and return
//
// func int AddDiagNums(int matrixSize)
//  {
//      int sum = 0;
//      rows = columns = matrixSize
//      get last value in first column
//      get first value in last row
//      if matrix > 2 then for i = 0; i < matrixSize; i++
//          {
//              the diag is always at i,i so sum += matrix[i,i]
//          }
//      return sum
//   
int sum = 0;
Console.Write("\nPlease enter a matrix size: ");
int.TryParse(Console.ReadLine(), out int matrixSize);
int[,] matrix = new int[matrixSize, matrixSize];
Console.WriteLine();

for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        Console.Write($"Enter value at [{i},{j}]: ");
        int.TryParse(Console.ReadLine(), out int value);
        matrix[i, j] = value;
    }
}


Console.WriteLine("\nThe matrix is :\n");
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < matrixSize; i++)
{
    sum += matrix[i, matrixSize - 1 - i];  // this (and i,i for the other diag) is always on a diag. I stole this idea but wish I had thought of it
}

Console.WriteLine($"The sum of the right diagonals is: {sum}");
Console.ReadKey();





