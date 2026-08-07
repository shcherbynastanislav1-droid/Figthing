using System;
namespace OOP_Fight_GUI;

public abstract class Character
{
    protected static Random random = new Random();
    protected string name;
    protected int health;
    protected int healthMax;
    protected int attackMin;
    protected int attackMax;
    protected const int dodgeChance = 15;
    
    protected Character(string name, int healthMax, int attackMax)
    {
        this.name = name;
        this.health = healthMax;
        this.healthMax = healthMax;
        this.attackMax = attackMax;
        this.attackMin = attackMax / 2;
    }
    protected Character() {
        this.name = "Deda";
        this.healthMax = 10;
        this.attackMax = 5;
        this.health = this.healthMax;
        this.attackMin = this.attackMax / 2;
    }
   
    public virtual string Attack(Character target)
    {
        int takingDamage = random.Next(this.attackMin, this.attackMax + 1);
        if (random.Next(1, 101) <= dodgeChance)
        {
            return $"{target.name} dodge";
        }
        else
        {
            target.Health = target.Health - takingDamage;

            return $"{target.name} taking {takingDamage} damage";
            
        }
    }
    public virtual bool isDead
    {
        get
        {
            return health <= 0;
        }
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if (value < 0) health = 0;
            else health = value;
        }
    }
    public int AttackMax
    {
        get
        {
            return this.attackMax;
        }
        set
        {
            this.attackMax = value;
        }
    }
    public int HealthMax
    {
        get
        {
            return this.healthMax;
        }
        set
        {
            this.healthMax = value;
        }
    }
    public string Name
    {
        get {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public int AttackMin
    {
        get
        {
            return this.attackMin;
        }
        set
        {
            this.attackMin = value;
        }
    }
}