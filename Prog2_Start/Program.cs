using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Review
            // an array is a collection of a single data type 
            // with fixed length

            // array declaration
            int[] arr1 = new int[] { };     // elements are unknown
            int[] arr2 = new int[5];        // length is known
            int[] arr3 = { 1, 2, 3, 4, 5 }; // elements are known
            int[] arr4 = { };               // elements/length is unknown

            // arr1 has a length of 0
            // arr2 has a length of 5
            // arr3 has a length of 5
            // arr4 has a length of 0

            // arr1 has a maximum index of null/undefined
            // arr1 has a minimum index of null/undefined
            // arr2 has a maximum index of 4
            // arr2 has a minumum index of 0
            // arr3 has a maximum index of 4
            // arr3 has a minumum index of 0
            // arr4 has a maximum index of null/undefined
            // arr4 has a minimum index of null/undefined

            // things to remember: the indexes of an array is base 0
            // this means the elements are counted from 0 to a maximum of 
            // its length - 1
            // which is why an array with length 0 has an undefined length

            // purpose of declaring an array with length 0, when you need
            // a placeholder. Placeholder arrays needs to be reinitialized
            // with its proper length.
            arr1 = new int[20];
            // note : the length of an array must always be a whole number

            // the new arr1
            // has a length of 20
            // has 20 elements
            // has 20 indexes 0 - 19

            // what is the index of element 18? 17
            arr1[17] = 15; // placing a value at element 18 of the array

            // moving on to multidimensional arrays

            // jagged array
            // a jagged array is an array within an array
            int[][] arr5 = new int[5][]; // declaration of a jagged array
            arr5[0] = new int[5];
            arr5[1] = new int[6];
            arr5[2] = new int[7];
            arr5[3] = new int[4];
            arr5[4] = new int[2];

            //Console.WriteLine(arr5.Length);
            //Console.ReadKey();
            // what is the length of arr5? 5
            // how many elements are in arr5? 24

            int[][][] arr6 = new int[6][][];

            for(int x = 0; x < arr6.Length; x++)
            {
                arr6[x] = new int[6][];
                for(int y = 0; y < arr6[x].Length; y++)
                {
                    arr6[x][y] = new int[6];
                }
            }

            // multidimensional array (c#)
            int[,] arr7 = new int[5, 5];
            // how many elements are in arr7? 25
            // what is the length of arr7? 25

            Console.WriteLine(arr7.Length);
            Console.WriteLine(arr7.GetLength(0));
            Console.WriteLine(arr7.GetLength(1));
            Console.ReadKey();

            // what is the index of the 13th element? 2,2

            int[][,] arr8 = new int[5][,];

        }
    }
}
