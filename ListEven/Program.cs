namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listEven = new List<int>();
            List<int> listNoEven = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2 == 0)
                {
                    listEven.Add(list[i]);
                }
                else
                {
                    listNoEven.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ",listEven));
            Console.WriteLine(string.Join(" ",listNoEven));

            static ListEven <int> GetEvenElements(ListEven<int> input)
            {
                for (int i = 0;i < input.Count;i++)
                {
                    if (input[i]%2 == 0)
                    {
                        ListEvan.add(input[i]);
                    }

                }
                return ListEvan;
            }
        }
    }
}
