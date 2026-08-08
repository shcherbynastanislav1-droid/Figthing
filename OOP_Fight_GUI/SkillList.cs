namespace OOP_Fight_GUI;
public class SkillList {
    List<Skill> skills = new List<Skill>();
    public Skill Skills(int idSkill){
        Skill attackUpI = new Skill("Attack I","+1 attack",1);
        attackUpI.Effect = p => p.attackMax += 1;
        skills.Add(attackUpI);
        Skill vimpireI = new Skill("vimpire I","healing 1 hp on hit",2);
        attackUpI.Effect = p => p.attackMax += 1;
        skills.Add(vimpireI);
        Skill critChanceI = new Skill("Crits I", "10% crit chance, x2 damage", 2);
        critChanceI.Effect = p => {
            p.critChance = 10; 
            p.critDamage = 2;
        };
        skills.Add(critChanceI);
        Skill critChanceII = new Skill("Crits II", "20% crit chance, x2 crit damage", 3);
        critChanceII.Effect = p => {
            p.critChance += 10;
        };
        skills.Add(critChanceII);
        if (idSkill < skills.Count)
        {
            return skills[idSkill];
        }
    }
}