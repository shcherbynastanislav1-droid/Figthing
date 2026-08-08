using System;
using System.Text.Json;
namespace OOP_Fight_GUI;

public class SaveManager
{
    public Player Player { get; set; }
    public Mob Mob { get; set; }
    
    public string Save(Player player, Mob mob)
    {
        SaveManager saveDate = new SaveManager
        {
            Player = player,
            Mob = mob
        };
        string json = JsonSerializer.Serialize(saveDate);
        File.WriteAllText("save.json", json);
        return "You save your character";
    }
    public SaveManager Load()
    {
        string jsonFromFile = File.ReadAllText("save.json");

        return JsonSerializer.Deserialize<SaveManager>(jsonFromFile);
    }
    public Player NewGame()
    {
        // Player defaultPlayer = new Player();
        return new Player();
    }
}
