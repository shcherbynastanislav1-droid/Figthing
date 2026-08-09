namespace OOP_Fight_GUI;

public class Inventory
{
    public Item ArmorSlot {get;set;}
    public Item Weapon {get;set;}
    public Item Amulet {get;set;}
    List<Item> backpak = new List<Item>();
    public void Delete(Item item)
    {
        backpak.Remove(item);
    }
    public void Add(Item item)
    {
        backpak.Add(item);
    }
}