using System.Numerics;

namespace OOP_Fight_GUI;
public class SkillList {
    List<Skill> skills = new List<Skill>();
    Player player;
    public SkillList(Player player)
    {
        this.player = player;
    }
    public Skill Skills(int idSkill) {
        //Skill per = new Skill("Attack I", "+1 attack", 1);
        //per.Effect = p => p.st += 1;
        //skills.Add(per);

        Skill Id0_attackUpI = new Skill("Attack I", "+1 attack", 1);
        Id0_attackUpI.Effect = p => {
            p.AttackMax += 6;
            p.AttackMin = p.AttackMax / 2;
            };
        skills.Add(Id0_attackUpI);

        Skill Id1_armorI = new Skill("Armor I", "+1 armor", 1);
        Id1_armorI.Effect = p => p.Armor += 1;
        skills.Add(Id1_armorI);

        Skill Id2_healthI = new Skill("Health I", "+2 max health", 1);
        Id2_healthI.Effect = p => p.HealthMax += 1;
        skills.Add(Id2_healthI);

        Skill Id3_vimpireI = new Skill("vimpire I","Healing 1 hp on hit",2);
        Id3_vimpireI.Effect = p => p.Vampire += 1;
        skills.Add(Id3_vimpireI);

        Skill Id4_critChanceI = new Skill("Crits I", "10% crit chance, x2 damage", 2);
        Id4_critChanceI.Effect = p => {
            p.CritChance = 10; 
            p.CritDamage = 2;
        };
        skills.Add(Id4_critChanceI);

        Skill Id5_critChanceII = new Skill("Crits II", "20% crit chance, x2 crit damage", 3);
        Id5_critChanceII.Effect = p => {
            p.CritChance += 10;
        };
        skills.Add(Id5_critChanceII);

        if (idSkill < skills.Count)
        {
            return skills[idSkill];
        }
        return null;
    }
    public void Select(int idSkill, Button button)
    {
        if (skills[idSkill].IsLearnd)
        {
            return;
        }
        if (player.SkillPoints >= skills[idSkill].SkillPointCost)
            player.SkillPoints -= skills[idSkill].SkillPointCost;
        else 
            return;
        button.ForeColor = Color.Gold;
        skills[idSkill].IsLearnd = true;
        skills[idSkill].Effect(player);
        
    }
    
    public int Count()
    {
        return skills.Count;
    }
     
}