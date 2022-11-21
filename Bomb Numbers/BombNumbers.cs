namespace Bomb_Numbers
{
    internal class BombNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var bombTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bombNum = bombTokens[0];
            var bombStrength = bombTokens[1];

            for (int i = 0; i < list.Count; i++)
            {
                var currentNum = list[i];

                if(currentNum == bombNum)
                {
                    var leftindex = Math.Max(i - bombStrength, 0);
                    var rightindex = Math.Min(i + bombStrength, list.Count -1);


                    var removeCount = rightindex - leftindex + 1;

                    list.RemoveRange(leftindex, removeCount);
                    i = -1;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}