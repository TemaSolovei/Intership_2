﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNumTwo
{
    class Program
    {
        private static int size;
        private static int[,] masPoints;
        private static int[,] minMax; // 0 - minX, 1 - maxX, 2 - minY, 3 - maxY

        static void Main(string[] args)
        {
            IORead();
        }

        static void IORead()
        {
            size = Int32.Parse(Console.ReadLine());
            masPoints = new int[size,4];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    masPoints[i,j] = Int32.Parse(Console.ReadLine());
                }

                if ((masPoints[i, 0] + masPoints[i, 1]) < (masPoints[i, 2] + masPoints[i, 3]))
                {
                    int tempX = masPoints[i, 0], tempY = masPoints[i, 1];
                    masPoints[i, 0] = masPoints[i, 2];
                    masPoints[i, 1] = masPoints[i, 3];
                    masPoints[i, 2] = tempX;
                    masPoints[i, 3] = tempY;
                }

                if (masPoints[i, 0] < masPoints[i, 1]) //MinMaxX
                {
                    minMax[i, 0] = masPoints[i, 0];
                    minMax[i, 1] = masPoints[i, 1];
                }
                else if (masPoints[i, 0] > masPoints[i, 1])
                {
                    minMax[i, 0] = masPoints[i, 1];
                    minMax[i, 1] = masPoints[i, 0];
                }
                else
                {
                    minMax[i, 0] = masPoints[i, 0];
                    minMax[i, 1] = masPoints[i, 0];
                }

                if (masPoints[i, 2] < masPoints[i, 3]) //MinMaxY
                {
                    minMax[i, 2] = masPoints[i, 2];
                    minMax[i, 3] = masPoints[i, 3];
                }
                else if (masPoints[i, 2] > masPoints[i, 3])
                {
                    minMax[i, 2] = masPoints[i, 3];
                    minMax[i, 3] = masPoints[i, 2];
                }
                else
                {
                    minMax[i, 2] = masPoints[i, 2];
                    minMax[i, 3] = masPoints[i, 2];
                }
            }
        }

        static void Calculate()
        {
            int x1, y1, x2, y2, x1Old, y1Old, x2Old, y2Old;
            

        }
    }
}
