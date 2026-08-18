using System;
namespace OOP_Fight_GUI;

public class Skill
{
    private int id;
	private string name;
    private string description;
    public Action<Player> Effect {get; set;}
    private int skillPointCost;

    public Skill(int id, string name, string description, int skillPointCost)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.skillPointCost = skillPointCost;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public string Description
    {
        get
        {
            return this.description;
        }
        set
        {
            this.description = value;
        }
    }
    public int SkillPointCost
    {
        get
        {
            return this.skillPointCost;
        }
        set
        {
            this.skillPointCost = value;
        }
    }
    public int Id
    {
        get
        {
            return this.id;
        }
    }

}
