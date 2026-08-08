namespace OOP_Fight_GUI;
class SkillSelect {
    List<Skill> skills = new List<Skill>();
    public Skill SkillList(int idSkill){
        Skill attackUpI = new Skills("Attack I","+1 attack",1);
        attackUpI.Effect = p => p.attackMax += 1;
        skills.Add(attackUpI);
        Skill vimpireI = new Skills("vimpire I","healing 1 hp on hit",2);
        attackUpI.Effect = p => p.attackMax += 1;
        skills.Add(vimpireI);
        Skill critChanceI = new Skills("Crits I", "10% crit chance, x2 damage", 2);
        critChanceI.Effect = p => {
            p.critChance = 10; 
            p.critDamage = 2;
        };
        skills.Add(critChanceI);
        Skill critChanceII = new Skills("Crits II", "20% crit chance, x2 crit damage", 3);
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