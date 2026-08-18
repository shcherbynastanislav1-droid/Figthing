namespace OOP_Fight_GUI;

public class Inventory
{
    public Item ArmorSlot {get;set;}
    public Item WeaponSlot { get;set;}
    public Item UnderpantsSlot { get;set;}
    public InventorySlot[] Slots { get; set; }
    public Inventory(int size)
    {
        Slots = new InventorySlot[size];
        for (int i = 0; i < size; i++)
        {
            Slots[i] = new InventorySlot();
        }
    }
    public void Add(Item item)
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            if (Slots[i].Item == item)
            {
                Slots[i].Amount++;
                break;
            }
            else if (Slots[i].Item == null)
            {
                Slots[i].Item = item;
                Slots[i].Amount = 1;
                break;
            }
        }
    }
    public void Remove(Item item)
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            if (Slots[i].Item == item)
            {
                Slots[i].Item = null;
                Slots[i].Amount = 0;
                break;
            }
        }
    }
}
public class InventorySlot
{
    public InventorySlot() 
    {
        Item = null;
        Amount = 0;
    }
    public Item Item { get; set; }
    public int Amount { get; set; }
    
}