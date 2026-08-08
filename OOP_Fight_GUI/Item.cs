using System;
namespace OOP_Fight_GUI;

public class Item
{
    private string name;
    private string description;
    public Action<Player> Stat {get; set;}
    private bool isEquip = false;
    public bool IsEquip
    {
        get
        {
            return this.isEquip;
        }
        set
        {
            this.isEquip = value;
        }
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
    public Item(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
    public Item Items()
    {
        Item baseKnife = new Item("Knife","HP-43, +2 max attack");
        baseKnife.Stat = p => p.AttackMax += 2;
        return baseKnife;
    }
}