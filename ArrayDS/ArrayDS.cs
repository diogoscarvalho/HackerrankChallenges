namespace ArrayDS
{
    internal class ArrayDS
    {
        public static IEnumerable<int> ReverseArray(List<int> a)
        {
            for (int index = a.Count - 1; index >= 0; index--)
            {
                yield return a[index];
            }
        }

        public static IEnumerable<int> ReverseArrayRoots(List<int> a)
        {
            int index = 0;
            int reverseIndex = index + a.Count-1;
            int aux = default;

            while(reverseIndex > index)
            {
                aux = a[index];
                a[index] = a[reverseIndex];
                a[reverseIndex] = aux;

                index++;
                reverseIndex--;
            }

            return a;
        }
    }
}
