// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');
System.Console.WriteLine(sku);
string type = "";
string color = "";
string size = "";

type = product[0] switch
{
    "01" => "Sweat shirt",
    "02" => "T-shirt",
    "03" => "Sweat pants",
    _ => "Other",
};

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size ="Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}




Console.WriteLine($"Product: {size} {color} {type}");