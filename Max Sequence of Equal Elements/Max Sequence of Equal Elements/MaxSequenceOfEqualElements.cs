namespace Max_Sequence_of_Equal_Elements
{
    internal class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            var maxSequenceOfEqualElements = FindMAxSequenceOfEqualElements(inputArr);

            Console.WriteLine(String.Join(" ", maxSequenceOfEqualElements));

        }

        static int[] FindMAxSequenceOfEqualElements(int[] arr)
        {
           var longestSequence = new List<int>();
           var currentSequence = new List<int>();
            currentSequence.Add(arr[0]);


            for (int i = 1; i < arr.Length; i++)
            {
               var currentNum = arr[i];
               var searchNum = currentSequence[0];

                if (currentNum == searchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if(currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }

            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
            return longestSequence.ToArray();
        }
    }
}   