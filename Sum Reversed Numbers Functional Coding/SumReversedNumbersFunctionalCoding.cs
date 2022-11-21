namespace Sum_Reversed_Numbers_Functional_Coding
{
    internal class SumReversedNumbersFunctionalCoding
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(a => int.Parse(new String (a.Reverse().ToArray()))).Sum());
        }
    }
}