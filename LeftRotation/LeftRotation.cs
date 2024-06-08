using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    internal class LeftRotation
    {
        // Solution that I come up with
        // It works but it is too slow when we have big arrays
        // the time complexity of it is O(n2)
        public static List<int> RotateLeft(int d, List<int> arr)
        {
            for (int round = 1; round <= d; round++)
            {
                int current = arr[0];
                for (int index = 0; index < arr.Count; index++)
                {
                    arr[index] = arr[index + 1];
                }

                arr[^1] = current;
            }

            return [.. arr];
        }

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            List<int> rotation = [];
            for (int i = 0; i < arr.Count; i++)
            {
                int index = (i + d) % arr.Count;
                Console.WriteLine(index);

                rotation.Add(arr[(i + d) % arr.Count]);
            }
            return rotation;
        }
    }
}
