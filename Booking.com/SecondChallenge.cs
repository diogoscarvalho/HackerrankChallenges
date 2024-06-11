namespace Booking.com
{
    internal class SecondChallenge
    {
        /*
     * Complete the 'carParkingRoof' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. LONG_INTEGER_ARRAY cars
     *  2. INTEGER k
     */

        public static long CarParkingRoof(List<long> cars, int k)
        {
            long shortestDistance = default;
            
            // Sorting the car parking spots
            cars.Sort();
            for(int index =0; index < cars.Count; index++)
            {
                if(index + k < cars.Count)
                {
                    var distance = (cars[index + (k - 1)] - cars[index]) + 1;

                    if (shortestDistance == default || distance < shortestDistance) shortestDistance = distance;
                }
            }

            return shortestDistance;
        }
    }
}
