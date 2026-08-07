using System;
namespace OOP_Fight_GUI;
public class MobSelect
{
    List<Mob> enemys = new List<Mob>();
    Random random = new Random();
    public Mob Add()
    {
        enemys.Add(new Mob("Zombie", 6, 2, 4));
        enemys.Add(new Mob("Slime", 2, 1, 1));
        enemys.Add(new Mob("Skeleton", 4, 3, 3));
        enemys.Add(new Mob("Boss", 20, 4, 10));
        enemys.Add(new Mob("Pig", 3, 1, 2));

        return enemys[random.Next(enemys.Count)].Clone();
    }
}
