using System.Numerics;

namespace OOP_Fight_GUI;
public class SkillList {
    List<Skill> skills = new List<Skill>();
    public SkillList() {
        //Skill per = new Skill("Attack I", "+1 attack", 1);
        //per.Effect = p => p.st += 1;
        //skills.Add(per);

        Skill attackUpI = new Skill(0,"Attack I", "+1 attack", 1);
        attackUpI.Effect = p => {
            p.AttackMax += 6;
            p.AttackMin = p.AttackMax / 2;
        };
        skills.Add(attackUpI);

        Skill armorI = new Skill(1,"Armor I", "+1 armor", 1);
        armorI.Effect = p => p.Armor += 1;
        skills.Add(armorI);

        Skill Id2_healthI = new Skill(2,"Health I", "+2 max health", 1);
        Id2_healthI.Effect = p => p.HealthMax += 1;
        skills.Add(Id2_healthI);

        Skill Id3_vampireI = new Skill(3,"vimpire I", "Healing 1 hp on hit", 2);
        Id3_vampireI.Effect = p => p.Vampire += 1;
        skills.Add(Id3_vampireI);

        Skill Id4_critChanceI = new Skill(4,"Crits I", "10% crit chance, x2 damage", 2);
        Id4_critChanceI.Effect = p => {
            p.CritChance = 10;
            p.CritDamage = 2;
        };
        skills.Add(Id4_critChanceI);

        Skill Id5_critChanceII = new Skill(5,"Crits II", "20% crit chance, x2 crit damage", 3);
        Id5_critChanceII.Effect = p => {
            p.CritChance += 10;
        };
        skills.Add(Id5_critChanceII);

        Skill Id_6vampireII = new Skill(6,"vimpire I", "Healing 2 hp on hit", 2);
        Id_6vampireII.Effect = p => p.Vampire += 1;
        skills.Add(Id_6vampireII);

    }
    
    public Skill Skills(int idSkill) {
        
        if (idSkill < skills.Count)
        {
            return skills[idSkill];
        }
        return null;
    }
    public int Count()
    {
        return skills.Count;
    }
     
}