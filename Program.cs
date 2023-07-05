UserInput("Player 1, how far away from the city do you want to station the Manticore?: ", 0, 100);
Console.Clear();
Console.WriteLine("Player 2, it is your turn.");
int p1Distance;
int manticore = 10;
int city = 15;
int round = 1;
int cannonRange;
int cannonDamage ;
while ( manticore > 0  || city > 0)
{
    Console.WriteLine("---------------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} City {city}/15 Manticore: {manticore}/10");
    CannonDamage();
    CannonRange();
    round++;
    if( manticore <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }
    else if (city <= 0)
    {
        Console.WriteLine("The city has been destroyed! YOU FAILED!!!");
        break;
    }   
}
//Methods
int CannonDamage()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        cannonDamage = 10;
    }
    else if (round % 3 == 0)
    {
        cannonDamage = 3;
    }
    else if (round % 5 == 0)
    {
        cannonDamage = 3;
    }
    else
    {
        cannonDamage = 1;
    }
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    return cannonDamage;
}
int CannonRange()
{
    Console.Write("Enter desired cannon range: ");
    cannonRange = Convert.ToInt32(Console.ReadLine());
    if (cannonRange == p1Distance)
    {
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round was a DIRECT HIT !");

        manticore = manticore - cannonDamage;
    }
    if (cannonRange > p1Distance)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("That round OVERSHOT the target.");
        city--;
    }
    else if (cannonRange < p1Distance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round FELL SHORT of that target.");
        city--;

    }
    return cannonRange;
}

int UserInput(string text, int min, int max)
{
    Console.Write(text);
    p1Distance = Convert.ToInt32(Console.ReadLine());
    while (p1Distance < min || p1Distance > max)
    {
        Console.Write("Please select a range between 0 and 100: ");
        p1Distance = Convert.ToInt32(Console.ReadLine());
    }
    return p1Distance;
}
