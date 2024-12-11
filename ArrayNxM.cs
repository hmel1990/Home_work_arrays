using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_arrays
{
    internal class ArrayNxM
    {
        private int width = 6;
        private int height = 5;
        private int[,] arr;
        private int k = 1;

        public ArrayNxM()
        {
            arr = new int[height, width];
        }

        public void Print ()
        {
            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    arr[r,c] = k;
                    k++;
                    Console.Write(arr [r,c] + "\t");
                }
                Console.Write("\n\n");
            }
        }

    }
}
