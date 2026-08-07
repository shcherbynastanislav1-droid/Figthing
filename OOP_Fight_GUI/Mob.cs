using System;
namespace OOP_Fight_GUI;

public class Mob : Character
{
    private int dropExp;
    static int kills = 0;
    public Mob(string name, int healthMax, int attackMax, int dropExp) : base(name, healthMax, attackMax)
    {
        this.dropExp = dropExp;

    }
    public int DropExp
    {
        get
        {
            return this.dropExp;
        }
    }

    public Mob Clone()
    {
        return new Mob(name, healthMax, attackMax, dropExp);
    }
   
}