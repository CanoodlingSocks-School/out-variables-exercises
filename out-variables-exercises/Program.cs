// Out Variables

//var variableForSecondReturnValue = "";
//var valueOfString = GetAString(out variableForSecondReturnValue);

var valueOfString = GetAString(out var variableForSecondReturnValue, out _); // out _ gets discarded
Console.WriteLine($"{variableForSecondReturnValue} - {valueOfString}");

string GetAString(out string variable, out string variable2)
{
    variable = "Another string";
    variable2 = "Another string again";
    return "Hej";
}

// Another exercise

var potentialNumbers = new List<string>() { "1", "a", "3", "0b" };

potentialNumbers.ForEach((number) =>
{
    if(int.TryParse(number, out var result))
    {
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Translation was unsuccessful");
    }
});

// Another exercise

var dateAsString = "2022-08-30";
if(DateTime.TryParse(dateAsString, out DateTime date))
{
    Console.WriteLine(date);
}