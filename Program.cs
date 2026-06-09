Console.WriteLine("Batu Kertas Gunting v1.0");

Console.WriteLine("Pilih salah satu:");
Console.WriteLine("1. Batu");
Console.WriteLine("2. Kertas");
Console.WriteLine("3. Gunting");
string text = Console.ReadLine();
int input = int.Parse(text[0].ToString());
if (input == 1)
{
    Console.WriteLine("Anda memilih Batu!");
}
else if (input == 2)
{
    Console.WriteLine("Anda memilih Kertas!");
}
else if (input == 3)
{
    Console.WriteLine("Anda memilih Gunting!");
}
else
{
    Console.WriteLine("Anda tidak memilih!");
}

int komputer = Random.Shared.Next(1, 4);
if (komputer == 1)
{
    Console.WriteLine("Komputer memilih Batu!");
}
else if (komputer == 2)
{
    Console.WriteLine("Komputer memilih Kertas!");
}
else if (komputer == 3)
{
    Console.WriteLine("Komputer memilih Gunting!");
}

if (input == 1 && komputer == 1)
{
    Console.WriteLine("Draw!");
}
else if (input == 1 && komputer == 2)
{
    Console.WriteLine("Anda kalah!");
}
else if (input == 1 && komputer == 3)
{
    Console.WriteLine("Anda menang!");
}
else if (input == 2 && komputer == 1)
{
    Console.WriteLine("Anda menang!");
}
else if (input == 2 && komputer == 2)
{
    Console.WriteLine("Draw!");
}
else if (input == 2 && komputer == 3)
{
    Console.WriteLine("Anda kalah!");
}
else if (input == 3 && komputer == 1)
{
    Console.WriteLine("Anda kalah!");
}
else if (input == 3 && komputer == 2)
{
    Console.WriteLine("Anda menang!");
}
else if (input == 3 && komputer == 3)
{
    Console.WriteLine("Draw!");
}

Console.ReadKey();