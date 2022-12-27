string[] str = {"ghrrj", "12rr", "55555", "6rrr", "kjkjkj", "drr", "hirr"};
// int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if(str[i].Length <= 3) 
    {
        string[] res = str[i].Split(",");
        for(int j =0; j < res.Length; j++)
        {
            Console.Write($" res = {res[j]}, j = {j}");
        }
    }
}
