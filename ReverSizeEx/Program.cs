using System;
using System.Collections.Generic;
using System.Numerics;

namespace ReverSizeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] reverData = new int[,] {{ 1, 1, 0, 0, 0, 0, 0 }, 
                                           { 0, 1, 1, 0, 0, 1, 0 }, 
                                           { 0, 0, 0, 1, 0, 1, 0 }, 
                                           { 0, 0, 0, 0, 1, 0, 0 } 
                                          };

            List<int> result = ReverSizes(reverData);
            result.ForEach(i => { Console.WriteLine(i); });
        }

        public static List<int> ReverSizes(int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            bool[,] visitedMatrix = new bool[height, width];
            Stack<int[]> coordinatesOfSameRever = new Stack<int[]>();
            List<int> result = new List<int>();
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (visitedMatrix[row, col])
                    {
                        continue;
                    }
                    else if (matrix[row, col] == 1)
                    {
                        visitedMatrix[row, col] = true;
                        coordinatesOfSameRever.Push(new int[] { row, col });
                        result.Add(ComputeSizeOfCurrentRever(matrix, coordinatesOfSameRever, visitedMatrix));
                    }
                }
            }

            return result;
        }

        public static int ComputeSizeOfCurrentRever(int[,] matrix, Stack<int[]> coordinatesOfSameRever, bool[,] visitedCells)
        {
            int size = 0;
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            while (coordinatesOfSameRever.Count > 0)
            {
                int[] current = coordinatesOfSameRever.Pop();
                int row = current[0];
                int column = current[1];
                size++;

                // UP
                AddCellsForReverLengthCalculation(row - 1, column, coordinatesOfSameRever, ref visitedCells, matrix);
                //if ((row - 1) >= 0 && !visitedCells[row - 1, col] && matrix[row - 1, col] == 1)
                //{
                //    visitedCells[row - 1, col] = true;
                //    coordinatesOfSameRever.Push(new int[2] {row -1 , col});
                //}

                //RIGHT
                AddCellsForReverLengthCalculation(row, column+1, coordinatesOfSameRever, ref visitedCells, matrix);
                //if ((col + 1) < width && !visitedCells[row, col + 1] && matrix[row, col + 1] == 1)
                //{
                //    visitedCells[row, col + 1] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row, col + 1 });
                //}

                //Down
                AddCellsForReverLengthCalculation(row + 1, column, coordinatesOfSameRever, ref visitedCells, matrix);
                //if ((row + 1) < height && !visitedCells[row + 1, col] && matrix[row + 1, col] == 1)
                //{
                //    visitedCells[row + 1, col] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row + 1, col });
                //}

                //LEFT
                AddCellsForReverLengthCalculation(row, column - 1, coordinatesOfSameRever, ref visitedCells, matrix);
                //if ((col - 1) >= 0 && !visitedCells[row, col - 1] && matrix[row, col - 1] == 1)
                //{
                //    visitedCells[row, col - 1] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row, col - 1 });
                //}

                //Left Up
                AddCellsForReverLengthCalculation(row - 1, column - 1, coordinatesOfSameRever, ref visitedCells, matrix);
                //if (((col - 1) >= 0 && (row - 1) >= 0) && !visitedCells[row - 1, col - 1] && matrix[row - 1 , col - 1] == 1)
                //{
                //    visitedCells[row - 1, col - 1] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row - 1, col - 1 });
                //}

                //Right Up
                AddCellsForReverLengthCalculation(row - 1, column + 1, coordinatesOfSameRever, ref visitedCells, matrix);
                //if (((col + 1) < width && (row - 1) >= 0) && !visitedCells[row - 1, col + 1] && matrix[row - 1, col + 1] == 1)
                //{
                //    visitedCells[row - 1, col + 1] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row - 1, col + 1 });
                //}

                //Left Down
                AddCellsForReverLengthCalculation(row + 1, column - 1, coordinatesOfSameRever, ref visitedCells, matrix);
                //if (((col - 1) >= 0 && (row + 1) < height) && !visitedCells[row + 1, col - 1] && matrix[row + 1, col - 1] == 1)
                //{
                //    visitedCells[row +1, col - 1] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row + 1, col - 1 });
                //}

                //Right Down
                AddCellsForReverLengthCalculation(row + 1, column + 1, coordinatesOfSameRever, ref visitedCells, matrix);
                //if (((col + 1) < width && (row + 1) < height) && !visitedCells[row + 1, col + 1] && matrix[row + 1, col + 1] == 1)
                //{
                //    visitedCells[row + 1, col + 1] = true;
                //    coordinatesOfSameRever.Push(new int[2] { row + 1, col + 1 });
                //}
            }

            return size;
        }

        public static void AddCellsForReverLengthCalculation(int row, int column, Stack<int[]> coordinatesOfSameRever, ref bool[,] visitedCells, int[,] matrix)
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            if (row < 0 || column < 0 || row >= height || column >= width)
            {
                return;
            }
            
            if (!visitedCells[row, column] && matrix[row, column] == 1)
            {
                visitedCells[row, column] = true;
                coordinatesOfSameRever.Push(new int[2] { row, column });
            }
        }
    }
}
