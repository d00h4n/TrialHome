

class Program {

    // Driver code
    public static void Main()
    {
        string name1, name2;
        
        Dictionary<string, string> myDict = new Dictionary<string, string>();
  
        // Adding key/value pairs in myDict
        myDict.Add("Dawn", "Lucia" );
        myDict.Add("Plume", "Lucia" );
        myDict.Add("Tempest", "Selena" );
        myDict.Add("Garnet", "Vera" );
        myDict.Add("Glory", "Crome" );
        myDict.Add("Lux", "Liv"  );


        name1 = Console.ReadLine();
        name2 = Console.ReadLine();
        // To get count of key/value
        // pairs in myDict
        Console.WriteLine("Total Character: " + myDict.Count);


        bool added = myDict.TryAdd(name1, name2);
		Console.WriteLine("add a new Character pair for"+ name1 +" : " + added);
        // Displaying the key/value
        // pairs in myDict
        Console.WriteLine("The key/value in Char  : ");



        foreach(KeyValuePair<string, string> kvp in myDict)
        {
            Console.WriteLine("Name {0} {1} ",kvp.Value, kvp.Key  );
        }

    }
}