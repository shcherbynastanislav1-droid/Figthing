namespace OOP_Fight_GUI;
public class ItemList {
    List<Item> itemsList = new List<Item>();
    public Item Items(int idItem)
    {
        Item baseKnife = new Item("Knife","HP-43, +2 max attack");
        baseKnife.Stat = p => p.AttackMax += 2;
        itemsList.Add(baseKnife);

        Item military_helmet = new Item("military_helmet","+4 armor");
        military_helmet.Stat = p => p.Armor += 4;
        itemsList.Add(military_helmet);
        
        if(idItem < itemsList.Count)
        {
            return itemsList[idItem];
        }   
    }
    
}