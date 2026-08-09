using System;
namespace OOP_Fight_GUI;

public class Item
{
    private string name;
    private string description;
    private string emoji;
    public Action<Player> Stat {get; set;}
    private bool isEquip = false;
    public Item(string name, string description, string emoji)
    {
        this.emoji = emoji;
        this.name = name;
        this.description = description;
    }
    public string Emoji
    
    {
        get
        {
            return this.emoji;
        }
        set
        {
            this.emoji = value;
        }
    }
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
    
    
}