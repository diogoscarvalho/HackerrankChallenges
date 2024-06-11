// See https://www.hackerrank.com/challenges/ctci-bubble-sort/problem for more information

/*
 * Consider the following version of Bubble Sort:

    for (int i = 0; i < n; i++) {
    
        for (int j = 0; j < n - 1; j++) {
            // Swap adjacent elements if they are in decreasing order
            if (a[j] > a[j + 1]) {
                swap(a[j], a[j + 1]);
            }
        }
    
    }
    Given an array of integers, sort the array in ascending order using the Bubble Sort algorithm above. Once sorted, print the following three lines:

    Array is sorted in numSwaps swaps., where numSwaps is the number of swaps that took place.
    First Element: firstElement, where firstElement is the first element in the sorted array.
    Last Element: lastElement, where lastElement is the last element in the sorted array.
    
    Hint: To complete this challenge, you must add a variable that keeps a running tally of all swaps that occur during execution.

    Example

    swap    a       
    0       [6,4,1]
    1       [4,6,1]
    2       [4,1,6]
    3       [1,4,6]
    The steps of the bubble sort are shown above. It took  swaps to sort the array. Output is:

    Array is sorted in 3 swaps.  
    First Element: 1  
    Last Element: 6  
 */

using BubbleSort;

Solution.countSwaps([1, 2, 3]);
