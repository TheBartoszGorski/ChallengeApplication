// Exercise 5
// Count the number of occurences of each digit in a chosen number.

long number = 772366991;

string numberAsString = number.ToString();
char[] numberAsArray = numberAsString.ToCharArray();
char[] uniqueNumbers = numberAsArray.Distinct().ToArray();

char firstASCIICharacterAfterDigits = ':';

for (char digit = '0'; digit < firstASCIICharacterAfterDigits; digit++)
{
    bool isInNumber = false;

    foreach (char c in uniqueNumbers)
    {
        if (c == digit)
        {
            isInNumber = true;
        }
    }

    int counter = 0;

    if (isInNumber)
    {
        foreach (char c in numberAsArray)
        {
            if (c == digit)
            {
                counter++;
            }
        }
    }

    Console.WriteLine($"{digit} => {counter}");
}