﻿string[] Array(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3) count++; else continue;
    } 
    string[] result = new string[count];
    int index = 0;
    foreach(var s in str)
    {
        if(s.Length <= 3) 
        {
            result[index] = s;
            index++;
        }    
        else continue;
    }
    return result;
}

void printArr(string[] result)
{
    for(int k = 0; k < result.Length; k++)
    {
        if(k == result.Length - 1) Console.Write($"{result[k]}");
        else Console.Write($"{result[k]}, ");
    }
}


string[] str = {"ghrrj", "12rr", "55555", "6rrr", "kjkjkj", "drb", "hrb"};
string[] x = Array(str);
printArr(x);





// foreach(var el in result)
// {
//     Console.Write($"{el}, ");
// }


    
