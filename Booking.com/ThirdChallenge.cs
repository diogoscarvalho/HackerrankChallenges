using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com
{
    internal class ThirdChallenge
    {
        public static List<int> AwardTopKHotels(string positiveKeywords, string negativeKeywords, List<int> hotelIds, List<string> reviews, int k)
        {
            var positiveKeyWordsArray = positiveKeywords.Split(' ');
            var negativeKeyWordsArray = negativeKeywords.Split(' ');

            int positiveScore = 3;
            int negativeScore = -1;

            Dictionary<int, long> hotelScores = new Dictionary<int, long>();
            for (int index = 0; index < hotelIds.Count; index++)
            {
                int positiveWordsFound = FindNumberOfPositiveWords(reviews[index], positiveKeyWordsArray);
                int negativeWordsFound = FindNumberOfNegativeWords(reviews[index], negativeKeyWordsArray);

                var reviewPositiveScore = positiveWordsFound * positiveScore;
                var reviewNegativeScore = negativeWordsFound * negativeScore;
                var totalScore = positiveScore * negativeScore;

                if(!hotelScores.TryAdd(hotelIds[index], totalScore))
                {
                    var currentScore = hotelScores[hotelIds[index]];
                    hotelScores[hotelIds[index]] = currentScore + totalScore;
                }
            }

            var orderedHotels = hotelScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            return orderedHotels.Take(k).Select(x => x.Key).ToList();
        }

        private static int FindNumberOfPositiveWords(string review, string[] positiveWords)
        {
            var numberOfPositiveWords = 0;
            var reviewList = new List<string>(review.Split(" "));

            for (int index = 0; index < positiveWords.Length; index++)
            {
                numberOfPositiveWords += reviewList.FindAll(word => word.Equals(positiveWords[index], StringComparison.CurrentCultureIgnoreCase)).Count;

            }

            return numberOfPositiveWords;
        }


        private static int FindNumberOfNegativeWords(string review, string[] negativeWords)
        {
            var numberOfPositiveWords = 0;
            var reviewList = new List<string>(review.Split(" "));

            for (int index = 0; index < negativeWords.Length; index++)
            {
                numberOfPositiveWords += reviewList.FindAll(word => word.Equals(negativeWords[index], StringComparison.CurrentCultureIgnoreCase)).Count;

            }

            return numberOfPositiveWords;
        }
    }
}
