using System;
namespace OOP_Fight_GUI;

public class Battle {
	private Player player;
	private Mob mob;
	public Battle(Player player, Mob mob)
	{
		this.player = player;
		this.mob = mob;
	}
    public string MobAttack()
	{
		string massage = mob.Attack(player);
		return massage;
	}
	public string PlayerAttack()
	{
        string massage = player.Attack(mob);
        return massage;
    }
}
