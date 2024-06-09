namespace CountTriplets;

public static class Triplets
{
    public static long CountTriplets(List<long> arr, long commonRatio)
    {
        long totalTriplets = 0;
        if (arr.Count < 3) return totalTriplets;

        Dictionary<long, long> secondNumberMap = [];
        Dictionary<long, long> thirdNumberMap = [];
        
        for(int index = 0; index < arr.Count; index++){
            if(thirdNumberMap.TryGetValue(arr[index], out long triplets))
            {
                totalTriplets += triplets;
            }
            if(secondNumberMap.TryGetValue(arr[index], out triplets)){
                if(!thirdNumberMap.TryAdd(arr[index] * commonRatio, triplets))
                    thirdNumberMap[arr[index] * commonRatio] += triplets;
            }
            if(!secondNumberMap.TryAdd(arr[index] * commonRatio, 1))
                secondNumberMap[arr[index] * commonRatio]++; 
        }

        return totalTriplets;
    }
}
