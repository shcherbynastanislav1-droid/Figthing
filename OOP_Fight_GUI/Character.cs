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
    private int critChance;
    private int critDamage;
    private int vampire;
    protected int dodgeChance = 1;
    
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
        this.healthMax = 15;
        this.attackMax = 2;
        this.health = this.healthMax;
        this.attackMin = this.attackMax / 2;
    }
   
    public virtual string Attack(Character target)
    {
        int plusDamage = 1;
        if (critDamage != 0 && critChance != 0 && random.Next(1, 101) <= critChance)
        {
            plusDamage = critDamage;
        } 
        int takingDamage = random.Next(this.attackMin, this.attackMax + 1) * plusDamage;

        if (random.Next(1, 101) <= dodgeChance)
        {
            return $"{target.name} dodge";
        }
        else
        {
            target.Health -= takingDamage;

            if (vampire != 0)
                this.Health += vampire;
            

            return $"{target.name} taking {takingDamage} damage";
            
        }
    }
    public int CritChance
    {
        get
        {
            return this.critChance;
        }
        set
        {
            this.critChance = value;
        }
    }
    public int CritDamage
    {
        get
        {
            return this.critDamage;
        }
        set
        {
            this.critDamage = value;
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