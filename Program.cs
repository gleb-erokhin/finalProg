string[] str = {"ghj", "12", "55555", "6"};
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3) 
        {
            Console.WriteLine ($"{str[i]}");
            count++;
            Console.WriteLine($"count = {count}");
        }
    }