using System;
namespace OOP_Fight_GUI;

public class Mob : Character
{
    private int dropExp;
    static int kills = 0;
    public Mob(string name, int healthMax, int armor,int attackMax, int dropExp) : base(name, healthMax, armor, attackMax)
    {
        this.dropExp = dropExp;

    }
    public int DropExp
    {
        get
        {
            return this.dropExp;
        }
        set
        {
            this.dropExp = value;
        }
    }

    public Mob Clone()
    {
        Mob mobClone = new Mob(name, healthMax, armor, attackMax, dropExp);
        return mobClone;
    }
   
}