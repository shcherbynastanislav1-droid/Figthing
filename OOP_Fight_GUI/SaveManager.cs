using System;
using System.Text.Json;
namespace OOP_Fight_GUI;

class SaveManager
{
    public string Save(Player player)
    {
        string json = JsonSerializer.Serialize(player);

        File.WriteAllText("save.json", json);
        return "You save your character";
    }
    public Player Load()
    {
        string jsonFromFile = File.ReadAllText("save.json");

        Player loadedPlayer = JsonSerializer.Deserialize<Player>(jsonFromFile);

        return loadedPlayer;
    }
    public Player NewGame()
    {
        Player defaultPlayer = new Player();
        return defaultPlayer;
    }
}
