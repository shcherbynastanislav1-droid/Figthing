namespace OOP_Fight_GUI;

public class Inventory
{
    public Item ArmorSlot {get;set;}
    public Item WeaponSlot { get;set;}
    public Item UnderpantsSlot { get;set;}
    public InventorySlot[] Slots { get; set; }
    public Inventory(int size)
    {

    }
}
public class InventorySlot
{
    public Item Item { get; set; }
    public int Amount { get; set; }
    public bool IsEmpty => Item == null;
}