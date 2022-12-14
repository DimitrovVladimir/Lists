namespace Array_Manipulator
{
    internal class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine();

            while (line != "print") 
            {
                var tokens = line.Split();
                var command = tokens[0];

                if (command == "add")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);

                    list.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    var elements = new List<int>();
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var currentItem = int.Parse(tokens[1]);
                        elements.Add(currentItem);
                    }
                    list.InsertRange(index, elements);

                }
                else if (command == "contains")
                {
                    var index = -1;
                    var elements = int.Parse(tokens[1]);

                    if (list.Contains(elements))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == elements)
                            {
                                index = i;
                                break;
                            }
                        }

                    }
                }
                else if (command == "remove")
                {
                    var index = int.Parse(tokens[1]);
                    list.RemoveAt(index);
                }
                else if (command == "shift")
                {
                    var count = int.Parse(tokens[1])% list.Count;
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (command == "sumPairs")
                {
                    var pairsSum = new List<int>();

                    for (int i = 0; i < list.Count; i+= 2)
                    {
                        var currentElement = list[i];
                        var nextElement = 0;
                        if (i > list.Count -1 )
                        {
                            nextElement = list[i+1];
                        }

                        var elementsSum = currentElement + nextElement;
                        pairsSum.Add(elementsSum);
                    }
                    list = pairsSum;
                }
                line = Console.ReadLine();

            }
            Console.WriteLine("[{0}]", String.Join (", ", list));
        }
    }
}