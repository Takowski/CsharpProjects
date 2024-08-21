string[] values = { "12.3", "45", "ABC", "11", "DEF" };
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