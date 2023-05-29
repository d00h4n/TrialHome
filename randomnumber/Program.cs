class Program
{
	public static void Main(string[] args)
	{
        int x ;
		Random random = new Random();
		Dictionary<string, int> dictionary = new Dictionary<string, int>();

		dictionary.Add("a", 1);
		dictionary.Add("b", 2);
		dictionary.Add("c", 3);
		dictionary.Add("d", 4);
		dictionary.Add("e", 5);
        dictionary.Add("f", 6);
        dictionary.Add("g", 7);
        dictionary.Add("h", 8);
        dictionary.Add("Luck", 9);
        dictionary.Add("j", 10);
        x = int.Parse(Console.ReadLine());
		for (int i = 0; i < x; ++i)
		{
			int index = random.Next(dictionary.Count);

			//string key = dictionary.Keys.ElementAt(index);
			//int value = dictionary.Values.ElementAt(index);
			KeyValuePair<string, int> pair = dictionary.ElementAt(index);

			Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
		}
	}
}