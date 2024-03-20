string name = "Ewa";
string sex = "Kobieta";
int age = 19;

if (age < 30 && sex == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 roku życia");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine($"{name}, lat {age}");
}
else if (age < 18 && sex == "Mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
