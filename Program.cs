﻿string[] str = {"ghrrj", "12rr", "55555", "6rrr", "kjkjkj", "drrb", "hrrb"};
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

foreach(var el in result)
{
    Console.Write($"{el}, ");
}


    
