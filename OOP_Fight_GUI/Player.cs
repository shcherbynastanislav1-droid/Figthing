using System;
namespace OOP_Fight_GUI;

public class Player : Character
{
    private int lvl;
    private int currentExp;
    private int maxExp;
    private int kills;
    private int death;
    
    public Player(string name, int healthMax, int attackMax, int lvl, int exp) : base(name, healthMax, attackMax)
    {
        this.lvl = lvl;
        this.currentExp = exp;
        this.maxExp = 10;
        this.kills = 0;
        this.death = 0;
    }
    public Player() : base()
    {
        this.lvl = 1;
        this.currentExp = 0;
        this.maxExp = 10;
        this.kills = 0;
        this.death = 0;
    }
    public int Lvl
    {
        get
        {
            return this.lvl;
        }
        set
        {
            this.lvl = value;
        }
    }
    public int CurrentExp
    {
        get
        {
            return this.currentExp;
        }
        set
        {
            this.currentExp = value;
        }
    }
    public int MaxExp
    {
        get
        {
            return this.maxExp;
        }
        set
        {
            this.maxExp = value;
        }
    }
    public void ExpUp(int dropExp)
    {
        this.currentExp += dropExp;
        if (this.currentExp >= this.maxExp)
        {
            int remainder = this.currentExp - this.maxExp;
            this.currentExp = remainder;
            this.maxExp = this.maxExp + (this.maxExp * 20 / 100);
            base.HealthMax = HealthMax + (HealthMax * 10 / 100);
            base.Health = HealthMax;
            base.AttackMax++;
            base.AttackMin = attackMax / 2;
            this.lvl++;
        }
    }
    public int Kills
    {
        get
        {
            return this.kills;
        }
        set
        {
            this.kills = value;
        }
    }
    public int Death
    {
        get
        {
            return this.death;
        }
        set
        {
            this.death = value;
        }
    }
}