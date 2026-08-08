using System;
namespace OOP_Fight_GUI;
public class MobSelect
{
    List<Mob> locatio1 = new List<Mob>();
    List<Mob> bosses = new List<Mob>();
    Random random = new Random();
    public Mob Add()
    {
        locatio1.Add(new Mob("Pig", 8, 3, 2));
        locatio1.Add(new Mob("Slime", 6, 2, 1));
        locatio1.Add(new Mob("Goblin", 7, 2, 2));
        locatio1[2].CritChance = 20;
        locatio1[2].CritDamage = 2;

        Mob goldVersion = locatio1[random.Next(locatio1.Count)].Clone();
        goldVersion.Name += " G";
        goldVersion.HealthMax *= 2;
        goldVersion.dropExp *= 3;
        if (random.Next(1,101) <= 10) {
            return goldVersion.Clone();
        }
        return locatio1[random.Next(locatio1.Count)].Clone();
    }
    public Mob Boss(int idBoss)
    {
        bosses.Add(new Mob("Boss Pig", 20, 4, 7));
        return bosses[idBoss];
    }
}
