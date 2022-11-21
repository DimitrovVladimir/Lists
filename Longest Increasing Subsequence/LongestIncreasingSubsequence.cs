namespace Longest_Increasing_Subsequence
{
    internal class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var longestIncreasingSubsequence = FindLongestIncreasingSubsequence(inputArr);

            Console.WriteLine(String.Join(" ", longestIncreasingSubsequence));


        }

         static int[] FindLongestIncreasingSubsequence(int[] arr)
        {
            var lenght = new int[arr.Length];
            var previous = new int[arr.Length];


            var bestLenght =0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < arr.Length; anchor++)
            {
                lenght[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = arr[anchor];
                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = arr[i];
                    if (currentNum < anchorNum && lenght[i] + 1 > lenght[anchor])
                    {
                        lenght[anchor] = lenght[i] + 1;
                        previous[anchor] = i;
                    }
                }
                if (lenght[anchor] > bestLenght) 
                { 
                    bestLenght = lenght[anchor];
                    lastIndex = anchor;
                }
            }
            var longestIncreasingSubsequence = new List<int>();
            while(lastIndex != -1)
            {
                longestIncreasingSubsequence.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestIncreasingSubsequence.Reverse();


            return longestIncreasingSubsequence.ToArray();
            

        }
    }
}