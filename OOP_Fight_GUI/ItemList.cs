namespace OOP_Fight_GUI;
public class ItemList {
    List<Item> itemsList = new List<Item>();
    Random random = new Random();
    private int ChanceDrop = 50;
    public ItemList()
    {
        Item baseKnife = new Item(0, "Knife", "HP-43, +2 max attack", "🔪");
        baseKnife.Stat = p => p.AttackMax += 2;
        itemsList.Add(baseKnife);

        Item military_helmet = new Item(1, "Military helmet", "just helmet, +4 armor", "🪖");
        military_helmet.Stat = p => p.Armor += 4;
        itemsList.Add(military_helmet);

        Item gun = new Item(2, "Gun", "ТТ-33, +4 max attack", "🔫");
        gun.Stat = p => p.AttackMax += 4;
        itemsList.Add(gun);

        Item awp = new Item(3, "Awp", "Imba, +100 max attack", "🏹");
        awp.Stat = p => p.AttackMax += 100;
        itemsList.Add(awp);
    }
    public Item Add(int idItem)
    {
        if(idItem < itemsList.Count)
        {
            return itemsList[idItem];
        }
        return null;
    }
    public int HowMany()
    {
        return itemsList.Count();
    }
}