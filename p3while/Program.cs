Random attack = new();
int monsterLife = 10;
int heroLife = 10;

do
{

    int hitHero = attack.Next(1, 10);
    monsterLife -= hitHero;
    Console.WriteLine($"Monster was damaged and lost {hitHero} health and now has {monsterLife} health.");
    if (monsterLife <= 0) continue;
    int hitMonster = attack.Next(1, 10);
    heroLife -= hitMonster;
    Console.WriteLine($"Hero was damaged and lost {hitMonster} health and now has {heroLife} health.");

}
while (monsterLife > 0 && heroLife > 0);
{
    Console.WriteLine(heroLife > monsterLife ? "Hero wins!" : "Monster wins!");
}
