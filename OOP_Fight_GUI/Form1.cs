using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
namespace OOP_Fight_GUI
{
    public partial class Form1 : Form
    {
        Player player;
        Mob mob;
        SaveManager saveManager = new SaveManager();
        SkillList skillList;
        MobSelect mobs = new MobSelect();
        Panel[] inventoryPanels;
        Button[] skillButtons;
        Battle battle;
        public Form1()
        {
            InitializeComponent();

            SaveManager loadDate = saveManager.Load();
            player = loadDate.Player;
            skillList = new SkillList(player);
            //player = new Player();
            mob = loadDate.Mob;
            //mob = mobs.Add();
            battle = new Battle(player, mob);
            label_Name_Player.Text = player.Name;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            skillButtons = new Button[]
            {
                AttackUp_I,
                Armor_I,
                Health_I,
                Vampire_I,
                Crit_Chance_I,
                Crit_Chance_II

            };
            inventoryPanels = new Panel[]
            {
                Slot1,
                Slot2,
                Slot3,
                Slot4,
                Slot5,
                Slot6,
                Slot7
            };
            tool_Tip_AttackI.SetToolTip(
                AttackUp_I,
                $"{skillList.Skills(0).Name}\n{skillList.Skills(0).Description}\nCost:");

            console_Info.ReadOnly = true;

            UpdateUI();
        }
        private void UpdateUI()
        {
            label_Health_Player.Text = $"HP: {player.Health} / {player.HealthMax}";
            label_Attack_Player.Text = $"ATK: {player.AttackMax} / {player.AttackMin}";
            label_Lvl.Text = $"Lvl: {player.Lvl}";
            label_Exp.Text = $"Exp: {player.MaxExp} / {player.CurrentExp}";
            label_Skill_Point.Text = $"Points: {player.SkillPoints}";

            label_Name_Mob.Text = mob.Name;
            label_Health_Mob.Text = $"HP: {mob.Health} / {mob.HealthMax}";
            label_Attack_Mob.Text = $"ATK: {mob.AttackMax} / {mob.AttackMin}";

            UpdateSkill();
        }
        private void AddLog(string message)
        {
            console_Info.AppendText(message + Environment.NewLine);
            console_Info.SelectionStart = console_Info.TextLength;
            console_Info.ScrollToCaret();
        }
        private void ViewButton(Button viewTrue)
        {
            viewTrue.Enabled = !viewTrue.Enabled;
            Attack_Button.Enabled = !Attack_Button.Enabled;
            Invetory_Button.Enabled = !Invetory_Button.Enabled;
            Skills_Button.Enabled = !Skills_Button.Enabled;
            Settings_Button.Enabled = !Settings_Button.Enabled;
        }
        private void enableSkillButton(int idSkill, int idButton)
        {
            if (player.SkillPoints >= skillList.Skills(idSkill).SkillPointCost)
            {
                if (!skillList.Skills(idSkill).IsLearnd)
                {
                    skillButtons[idButton].Enabled = true;
                }
            }
            else if (player.SkillPoints < skillList.Skills(idSkill).SkillPointCost && !skillList.Skills(idSkill).IsLearnd)
            {
                skillButtons[idButton].Enabled = false;
            }
        }
        private void UpdateSkill()
        {
            //if (player.SkillPoints >= skillList.Skills(0).SkillPointCost)
            //{
            //    if (!skillList.Skills(0).IsLearnd)
            //    {
            //        skillButtons[0].Enabled = true;
            //    }
            //}
            //else if (player.SkillPoints < skillList.Skills(0).SkillPointCost && !skillList.Skills(0).IsLearnd)
            //{
            //    skillButtons[0].Enabled = false;
            //}
            enableSkillButton(0, 0);

            for (int i = 1; i < skillButtons.Length - 1; i++)
            {
                if (skillList.Skills(0).IsLearnd)
                {
                    enableSkillButton(i, i);
                }
                else
                {
                    skillButtons[i].Enabled = false;
                }
            }
            if (skillList.Skills(4).IsLearnd)
            {
                enableSkillButton(5, 5);
            }
            else
            {
                Crit_Chance_II.Enabled = false;
            }
            //if (skillList.Skills(0).IsLearnd)
            //{
            //    if (player.SkillPoints < skillList.Skills(0).SkillPointCost)
            //    {
            //        Health_I.Enabled = true;
            //        Vampire_I.Enabled = true;
            //        Crit_Chance_I.Enabled = true;
            //        Armor_I.Enabled = true;
            //    } 

            //} else
            //{
            //    Health_I.Enabled = false;
            //    Vampire_I.Enabled = false;
            //    Crit_Chance_I.Enabled = false;
            //    Armor_I.Enabled = false;
            //}

        }
        private async void Attack_Button_Click(object sender, EventArgs e)
        {
            Attack_Button.Enabled = false;
            ViewButton(Attack_Button);
            string attackPlayerMassage = battle.PlayerAttack();
            AddLog(attackPlayerMassage);
            UpdateUI();
            await Task.Delay(500);
            if (mob.isDead)
            {
                player.ExpUp(mob.DropExp);
                player.Kills++;
                mob = mobs.Add();
                battle = new Battle(player, mob);
            }
            else
            {
                string attackMobMassage = battle.MobAttack();
                if (!console_Info.IsDisposed) AddLog(attackMobMassage);

            }
            UpdateUI();
            ViewButton(Attack_Button);
            Attack_Button.Enabled = true;
            if (player.isDead)
            {
                console_Info.AppendText("You dead\n");
                player.Death++;
                Attack_Button.Enabled = false;
                Save_Button.Enabled = false;
            }
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            string saveMassage = saveManager.Save(player, mob);
            AddLog(saveMassage);
        }

        private void New_Game_Button_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {

                player = saveManager.NewGame();
                mob = mobs.Add();
                saveManager.Save(player, mob);
                battle = new Battle(player, mob);
                Attack_Button.Enabled = true;
                Save_Button.Enabled = true;

                UpdateUI();
            }

        }

        private void Skills_Button_Click(object sender, EventArgs e)
        {
            ViewButton(Skills_Button);
            skills_Panel.Visible = !skills_Panel.Visible;
        }

        private void Invetory_Button_Click(object sender, EventArgs e)
        {
            ViewButton(Invetory_Button);
            //Inventory_Panel.Visible = !Inventory_Panel.Visible;
        }

        private void Skill_Button_1_Click(object sender, EventArgs e)
        {
            skillList.Select(0, AttackUp_I);
            UpdateUI();
        }
        private void Armor_I_Click(object sender, EventArgs e)
        {
            skillList.Select(1, Armor_I);
            UpdateUI();
        }

        private void Health_I_Click(object sender, EventArgs e)
        {
            skillList.Select(2, Health_I);
            UpdateUI();
        }

        private void Vampire_I_Click(object sender, EventArgs e)
        {
            skillList.Select(3, Vampire_I);
            UpdateUI();
        }

        private void Crit_Chance_I_Click(object sender, EventArgs e)
        {
            skillList.Select(4, Crit_Chance_I);
            UpdateUI();
        }

        private void Crit_Chance_II_Click(object sender, EventArgs e)
        {
            skillList.Select(5, Crit_Chance_II);
            UpdateUI();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Save_Button.Visible = !Save_Button.Visible;
            New_Game_Button.Visible = !New_Game_Button.Visible;
            ViewButton(Settings_Button);
        }
    }
}
