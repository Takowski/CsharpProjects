string? numberEntry;
int numericValue;
bool validNumber;
Console.WriteLine("Enter a string containing a number between 5 and 10");

do
{
    numberEntry = Console.ReadLine();
    validNumber = int.TryParse(numberEntry, out numericValue);

    if (!validNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    else if (numericValue <= 5 || numericValue >= 10)
    {
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        validNumber = false;
    }
    else
    {
        Console.WriteLine($"Your input value {numericValue} has been accepted.");
    }

} while (!validNumber);