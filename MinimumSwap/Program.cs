﻿namespace MinimumSwap
{
    /*
     * You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates. You are allowed to swap any two elements. Find the minimum number of swaps required to sort the array in ascending order.
     
     * Example
     * arra = [7, 1, 3, 2, 4, 5, 6]
     * 
     * Perform the following steps:

        i   arr                         swap (indices)
        0   [7, 1, 3, 2, 4, 5, 6]   swap (0,3)
        1   [2, 1, 3, 7, 4, 5, 6]   swap (0,1)
        2   [1, 2, 3, 7, 4, 5, 6]   swap (3,4)
        3   [1, 2, 3, 4, 7, 5, 6]   swap (4,5)
        4   [1, 2, 3, 4, 5, 7, 6]   swap (5,6)
        5   [1, 2, 3, 4, 5, 6, 7]
        It took  swaps to sort the array.

        Function Description

        Complete the function minimumSwaps in the editor below.

        minimumSwaps has the following parameter(s):

        int arr[n]: an unordered array of integers
        Returns

        int: the minimum number of swaps to sort the array
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Swap.MinimumSwaps([4, 3, 1, 2]);
            Console.ReadKey();

        }
    }
}
