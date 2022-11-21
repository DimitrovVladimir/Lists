namespace Sum_Reversed_Numbers
{
    internal class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var currentNumToStr = currentNum.ToString();
                var reversedNumArray = currentNumToStr.Reverse().ToArray();
                var reversedNum = new String (reversedNumArray);

                arr[i] =int.Parse(reversedNum);

            }
            Console.WriteLine(arr.Sum());
        }
    }
}