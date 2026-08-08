using System;
namespace OOP_Fight_GUI;

public class Skill
{
	private string name;
    private string description;
    public Action<Player> Effect {get; set;}
    private int skillPointCost;
    private bool isLearnd = false;

    public Skill(string name, string description, int skillPointCost)
    {
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
    public bool IsLearnd
    {
        get
        {
            return this.isLearnd;
        }
        set
        {
            this.isLearnd = value;
        }
    }
    
    
}
