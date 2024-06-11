// See https://www.hackerrank.com/challenges/torque-and-development/problem for more information

/*
 * Determine the minimum cost to provide library access to all citizens of HackerLand. There are n cities numbered from 1 to n. Currently there are no libraries and the cities are not connected. Bidirectional roads may be built between any city pair listed in cities. A citizen has access to a library if:

    - Their city contains a library.
    - They can travel by road from their city to a city containing a library.
    
    Example

    The following figure is a sample map of HackerLand where the dotted lines denote possible roads:

    c_road = 2
    c_lib = 3
    cities = [[1,7], [1,3], [1,2], [2,3], [5,6], [6,8]]

    The cost of building any road is cc_road = 2, and the cost to build a library in any city is c_lib = 3. Build  roads at a cost of 5 x 2 = 10 and 2 libraries for a cost of 6. One of the available roads in the cycle 1 -> 2 -> 3 -> 1 is not necessary.

    There are q queries, where each query consists of a map of HackerLand and value of c_lib and c_road. For each query, find the minimum cost to make libraries accessible to all the citizens.
    
    Function Description

    Complete the function roadsAndLibraries in the editor below.
    roadsAndLibraries has the following parameters:

        - int n: integer, the number of cities
        - int c_lib: integer, the cost to build a library
        - int c_road: integer, the cost to repair a road
        - int cities[m][2]: each  contains two integers that represent cities that can be connected by a new road
    
    Returns
        - int: the minimal cost

    Sample Input

    STDIN       Function
    -----       --------
    2           q = 2
    3 3 2 1     n = 3, cities[] size m = 3, c_lib = 2, c_road = 1
    1 2         cities = [[1, 2], [3, 1], [2, 3]]
    3 1
    2 3
    6 6 2 5     n = 6, cities[] size m = 6, c_lib = 2, c_road = 5
    1 3         cities = [[1, 3], [3, 4],...]
    3 4
    2 4
    1 2
    2 3
    5 6
    
    Sample Output
    4
    12
 */
using RoadsAndLibraries;

Solution.RoadsAndLibraries(5, 6, 1, [[1, 2], [1, 3], [1, 4]]);
