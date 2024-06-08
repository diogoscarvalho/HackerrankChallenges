using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class DynamicArray
    {
        public static List<int> Queries(int n, List<List<int>> queries)
        {
            List<List<int>> sequences = [];
            int lastAnswer = 0;
            List<int> answers = [];

            for(int i = 0; i < n; i++)
            {
                sequences.Add([]);
            }

            foreach(var query in queries)
            {
                int type = query[0];
                int x = query[1];
                int y = query[2];

                int index = (x ^ lastAnswer) % n;

                if (type == 1)
                {
                    sequences[index].Add(y);
                }
                else if (type == 2)
                {
                    int size = sequences[index].Count;
                    lastAnswer = sequences[index][y % size];
                    answers.Add(lastAnswer);
                }
            }

            return answers;
        }
    }
}
