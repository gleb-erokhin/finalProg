string[] Array()
{
    string[] str = {"ghj", "12", "55555", "6"};
    int count = 0;
    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3) 
        {
            // Console.WriteLine ($"{str[i]}");
            count++;
            result = result + str[i];

        }
        
    }
    string[] res = new string[count];
    for(int j = 0; j < res.Length; j++)
    {
        res[j] = str[count];
    }
    return res;
}


string[] CreateArray(string[] a)
{

}

void PrintArray(string[] a)
{
    
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]}, ");
    }
}



string[] x = Array();
PrintArray(x);


