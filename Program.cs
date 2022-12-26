string[] input = {"hello", "-2", "may"};
for (int i = 0; i < input.Length; i++)
{
    if (input[Index] <= 3)
        {
            res[i] = input[i];
        }
    else
        {
            res[i] = "[]";
        }
    Console.Write($" {res[i]}, ");
}








// int[] CountArr(int[] array)
// {
//     int[] res = new int[4];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] <= 3)
//         {
//             res[i] = array[i];
//         }
//         else
//         {
//             res[i] = "[]";
//         }
//     }
//     return res;
// }

// int[] printarr(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     Console.WriteLine($"{array[i]}");
// }

// int[] input = new int{"hello", "-2", "may"};
// int[] x = CountArr(input);
// printarr(x);  