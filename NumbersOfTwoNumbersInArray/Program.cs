using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOfTwoNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool compare(string firstValue, string secondValue)
        {
            return firstValue.Equals(secondValue);
        }

        public bool compare(int firstNumber, int secondeNumber)
        {
            return firstNumber.Equals(secondeNumber);
        }

        public bool compare(string[] firstArray, string[] secondArray)
        {
            var firstArrayLength = firstArray.Length;
            var secondArrayLength = secondArray.Length;

            if (firstArrayLength == secondArrayLength)
            {
                for(int i =0; i < firstArrayLength; i++)
                {
                    if (!firstArray[i].Equals(secondArray[i]))
                        return false;
                }
            }
            else
                return false;

            return true;
        }
    }
}
