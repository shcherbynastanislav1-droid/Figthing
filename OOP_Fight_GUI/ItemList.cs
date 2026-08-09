namespace OOP_Fight_GUI;
public class ItemList {
    List<Item> itemsList = new List<Item>();
    Random random = new Random();
    private int ChanceDrop = 50;
    public Item Drop()
    {
        if(random.Next(1,101) >= ChanceDrop)
        {
            return itemsList[random.Next(itemsList.Count)];
        }
    }
    public Item Items(int idItem)
    {
        Item baseKnife = new Item("Knife","HP-43, +2 max attack");
        baseKnife.Stat = p => p.AttackMax += 2;
        itemsList.Add(baseKnife);

        Item military_helmet = new Item("Military helmet","just helmet, +4 armor");
        military_helmet.Stat = p => p.Armor += 4;
        itemsList.Add(military_helmet);

        Item gun = new Item("Gun","ТТ-33, +4 max attack");
        gun.Stat = p => p.AttackMax += 4;
        itemsList.Add(gun);

        Item awp = new Item("Awp", "Imba, +100 max attack");
        awp.Stat = p => p.AttackMax += 4;
        itemsList.Add(awp);
        
        if(idItem < itemsList.Count)
        {
            return itemsList[idItem];
        }   
    }
    
}