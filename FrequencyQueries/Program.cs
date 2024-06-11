// See https://aka.ms/new-console-template for more information
using FrequencyQueries;


/*
 * You are given  queries. Each query is of the form two integers described below:
    - 1 x : Insert x in your data structure.
    - 2 y : Delete one occurence of y from your data structure, if present.
    - 3 z : Check if any integer is present whose frequency is exactly z. If yes, print 1 else 0.

    The queries are given in the form of a 2-D array  of size  where  contains the operation, and  contains the data element.

    Example
    queries = [(1,1),(2,2),(3,2),(1,1),(1,1),(2,1),(3,2)]

    The results of each operation are:

    Operation   Array   Output
    (1,1)       [1]
    (2,2)       [1]
    (3,2)                   0
    (1,1)       [1,1]
    (1,1)       [1,1,1]
    (2,1)       [1,1]
    (3,2)                   1
    Return an array with the output:[0, 1].

    Function Description

    Complete the freqQuery function in the editor below.

    freqQuery has the following parameter(s):

    int queries[q][2]: a 2-d array of integers
    
    Returns
    - int[]: the results of queries of type 

    Sample Input 0
    8
    1 5
    1 6
    3 2
    1 10
    1 10
    1 6
    2 5
    3 2

    Sample Output 0
    0
    1

    Sample Input 1
    4
    3 4
    2 1003
    1 16
    3 1

    Sample Output 1
    0
    1

    Sample Input 2
    10
    1 3
    2 3
    3 2
    1 4
    1 5
    1 5
    1 4
    3 2
    2 4
    3 2

    Sample Output 2
    0
    1
    1
 */

Console.WriteLine("Hello, World!");
FrequencyQuery.FreqQuery(
    [
        [1, 5],
        [1, 6],
        [3, 2],
        [1, 10],
        [1, 10],
        [1, 6],
        [2, 5],
        [3, 2],
    ]);


// [ [1, 89],
// [3 ,15],
// [1 ,12],
// [1 ,47],
// [1 ,23],
// [1 ,66],
// [2 ,28],
// [3 ,2],
// [2 ,15],
// [1 ,16],
// [3 ,16],
// [1 ,17],
// [1 ,73],
// [2 ,44],
// [3 ,14],
// [2 ,30],
// [2 ,38],
// [2 ,4],
// [1 ,4],
// [2 ,35],
// [1 ,28],
// [1 ,9],
// [1 ,68],
// [3 ,1],
// [3 ,33],
// [3 ,5],
// [1 ,36],
// [1 ,30],
// [3 ,22],
// [1 ,72],
// [1 ,68],
// [1 ,62],
// [1 ,88],
// [1 ,79],
// [2 ,9],
// [1 ,10],
// [2 ,44],
// [3 ,38],
// [2 ,13],
// [1 ,61],
// [3 ,3],
// [1 ,78],
// [2 ,27],
// [1 ,28],
// [3 ,23],
// [1 ,92],
// [3 ,9],
// [1 ,13],
// [3 ,48],
// [3 ,12],
// [2 ,47],
// [3 ,25],
// [1 ,23],
// [1 ,66],
// [1 ,77],
// [3 ,5],
// [3 ,20],
// [2 ,12],
// [1 ,87],
// [1 ,93],
// [2 ,33],
// [2 ,6],
// [1 ,55],
// [3 ,20],
// [3 ,34],
// [2 ,15],
// [1 ,31],
// [2 ,29],     
// [2 ,2]
//  ]);