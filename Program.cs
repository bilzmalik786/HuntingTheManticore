Console.Write("Player 1, how far away from the city do you want to station the Manticore?: ");
int p1Distance = Convert.ToInt32(Console.ReadLine());
while ( p1Distance < 0 || p1Distance > 100)
{
    Console.Write("Please select a range between 0 and 100: ");
    p1Distance = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
int manticore = 10;
int city = 15;
int round = 1;
int cannonRange;
int cannonDamage = 1;
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
        Console.WriteLine("That round was a DIRECT HIT !");
        round++;
        manticore = manticore - cannonDamage;
    }
    if (cannonRange > p1Distance)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        city--;
        round++;
    }
    else if (cannonRange < p1Distance)
    {
        Console.WriteLine("That round FELL SHORT of that target.");
        city--;
        round++;
    }
    return cannonRange;
}
while ( manticore > 0  || city > 0)
{
    Console.WriteLine($"STATUS: Round: {round} City {city}/15 Manticore: {manticore}/10");
    CannonDamage();
    CannonRange();
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
