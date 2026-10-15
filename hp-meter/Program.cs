
int hp = 0;
Console.WriteLine("What is your max HP\nIt can't be biger than 20");


while (!int.TryParse(Console.ReadLine(), out hp) || hp < 0 || hp > 20)
{
    Console.WriteLine("That's not a number!");


}

// en loop som skriver ut tecken lika många som hp och minskar varje gång
// loopen slutar när hp är slut

while (hp > 0)
{
    int i = 0;
    while (i < hp)
    {
        Console.Write("*");
        i++;
    }
    Console.WriteLine();
    hp--;
}

Console.WriteLine("");


Console.ReadLine();