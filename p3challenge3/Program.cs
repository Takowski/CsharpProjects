using System.Text.RegularExpressions;

string? roleEntry;
bool validEntry = true;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    roleEntry = Console.ReadLine();
    if (roleEntry != null)
    {
        roleEntry = roleEntry.Trim().ToLower();

        if (roleEntry == "administrator" || roleEntry == "manager" || roleEntry == "user")
        {
            validEntry = true;
            Console.WriteLine($"Your input({roleEntry}) has been accepted");
        }
        else
        {
            validEntry = false;
            Console.WriteLine($"The role name that you entered, \"{roleEntry}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
    else
    {
        validEntry = false;
    }




}
while (!validEntry);