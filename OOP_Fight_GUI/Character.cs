using System;
namespace OOP_Fight_GUI;

public abstract class Character
{
    protected static Random random = new Random();
    protected string name;
    protected int health;
    protected int healthMax;
    protected int armor;
    protected int attackMin;
    protected int attackMax;
    protected int critChance;
    protected int critDamage;
    protected int vampire;
    protected int dodgeChance = 1;
    
    protected Character(string name, int healthMax, int armor, int attackMax)
    {
        this.name = name;
        this.health = healthMax;
        this.healthMax = healthMax;
        this.armor = armor;
        this.attackMax = attackMax;
        this.attackMin = attackMax / 2;
    }
    protected Character() {
        this.name = "Deda";
        this.healthMax = 15;
        this.attackMax = 6;
        this.armor = 0;
        this.health = this.healthMax;
        this.attackMin = this.attackMax / 2;
    }
   
    public virtual string Attack(Character target)
    {
        int plusDamage = 1;
        if (this.critDamage != 0 && this.critChance != 0 && random.Next(1, 101) <= this.critChance)
        {
            plusDamage = critDamage;
        } 
        double takingDamage = random.Next(this.attackMin, this.attackMax + 1) * plusDamage * (100.0/(100 + target.armor));
        int finalDamage = (int)Math.Ceiling(takingDamage);
        if (random.Next(1, 101) <= target.dodgeChance)
        {
            return $"{target.name} dodge";
        }
        else
        {
            target.Health -= finalDamage;

            if (vampire != 0)
                this.Health += vampire;
            

            return $"{target.name} taking {finalDamage} damage";
            
        }
    }
     public int Armor
    {
        get
        {
            return this.armor;
        }
        set
        {
            this.armor = value;
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
            return this.health <= 0;
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
            if (value < 0) this.health = 0;
            else if (value > this.HealthMax) this.health = this.healthMax;
            else this.health = value;
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
    public int Vampire
    {
        get
        {
            return this.vampire;
        }
        set
        {
            this.vampire = value;
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