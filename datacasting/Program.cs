﻿string[] values = { "12.3", "45", "ABC", "11", "DEF" };
int condition = values.Length;
bool validation = false;
decimal sum = 0;
string line = "";
for (int i = 0; i < condition; i++)
{
    validation = decimal.TryParse(values[i], out decimal numValue);
    if (validation)
    {
        sum += numValue;
    }
    else
    {
        line += values[i];
    }
}
System.Console.WriteLine($"Message:{line}");
System.Console.WriteLine($"Total:{sum}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1/value2);
decimal result2=value2/(decimal)value3;
float result3=value3/value1;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");