namespace RoadsAndLibraries
{
    internal static class Solution
    {
        internal static long RoadsAndLibraries(int n, int c_lib, int c_road, List<List<int>> cities)
        {
            long totalCost = 0;

            if(c_road > c_lib)
                return c_lib * n;

            List<int>[] adjList = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                adjList[i] = [];
            }

            foreach (var road in cities)
            {
                int city1 = road[0];
                int city2 = road[1];
                adjList[city1].Add(city2);
                adjList[city2].Add(city1);
            }

            bool[] visited = new bool[n + 1];

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    long componentSize = DeepFirstSearch(i, adjList, visited);
                    totalCost += c_lib + (componentSize - 1) * c_road;
                }
            }

            return totalCost;

        }

        private static long DeepFirstSearch(int city, List<int>[] adjList, bool[] visited)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(city);
            visited[city] = true;
            long componentSize = 0;

            while (stack.Count > 0)
            {
                int current = stack.Pop();
                componentSize++;

                foreach (int neighbor in adjList[current])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        stack.Push(neighbor);
                    }
                }
            }

            return componentSize;
        }
    }
}
