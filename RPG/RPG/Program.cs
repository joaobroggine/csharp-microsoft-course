int hero = 10;
int monster = 10;
Random random = new Random();
int heroAttack = random.Next(1, 10);
int monsterAttack = random.Next(1, 10);

do
{
    int damage = monster - heroAttack;
    monster = damage;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monster} health.");
    if (monster > 0)
    {
        damage = hero - monsterAttack;
        hero = damage;
        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {hero} health.");
    }
} while (monster > 0 && hero > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");