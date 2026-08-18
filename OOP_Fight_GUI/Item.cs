using System;
namespace OOP_Fight_GUI;

public class Item
{
    private int id;
    private string name;
    private string description;
    private string emoji;
    public Action<Player> Stat {get; set;}
    public Item(int id, string name, string description, string emoji)
    {
        this.id = id;
        this.emoji = emoji;
        this.name = name;
        this.description = description;
    }
    public int Id
    {
        get
        {
            return this.id;
        }
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