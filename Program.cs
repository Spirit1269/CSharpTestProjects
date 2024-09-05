// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal num =0;
// string words = "";
// for (int i =0; i<values.Length; i++)
// {
//     decimal temp;
//     if (decimal.TryParse(values[i], out temp))
//         {
//             num += temp;
//         } else{
//             words += values[i];
//         }
// }
// Console.WriteLine(num);
// Console.WriteLine(words);

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = value1 / (int)value2;
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 =  value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3/ (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");