using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Fight_GUI
{
    public partial class Form1 : Form
    {
        Player player;
        Mob mob;
        SaveManager saveManager = new SaveManager();
        SkillList skillList = new SkillList();
        ItemList itemList = new ItemList();
        MobSelect mobs = new MobSelect();
        Button[] skillButtons;
        Label[] inventoryLabels;
        Label[] inventoryAmounts;
        Battle battle;
        public Form1()
        {
            InitializeComponent();

            SaveManager loadDate = saveManager.Load();
            player = loadDate.Player;

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
                Crit_Chance_II,
                Vampire_II

            };

            inventoryLabels = new Label[] 
            { 
                Label_Slot1,
                Label_Slot2,
                Label_Slot3,
                Label_Slot4,
                Label_Slot5,
                Label_Slot6,
                Label_Slot7
            };
            inventoryAmounts = new Label[]
            {
                Label_Amount1,
                Label_Amount2,
                Label_Amount3,
                Label_Amount4,
                Label_Amount5,
                Label_Amount6,
                Label_Amount7
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
            if (!player.CheckSkill(skillList.Skills(idSkill)))
            {
                if (player.SkillPoints >= skillList.Skills(idSkill).SkillPointCost)
                {
                    skillButtons[idButton].Enabled = !player.CheckSkill(skillList.Skills(idSkill));
                }
                else
                {
                    skillButtons[idButton].Enabled = player.CheckSkill(skillList.Skills(idSkill));
                }
            }
            else
            {
                skillButtons[idButton].Enabled = player.CheckSkill(skillList.Skills(idSkill));
                Select(idSkill, skillButtons[idButton]);
            }
        }
        private void UpdateSkill()
        {
            enableSkillButton(0, 0);
            if (!player.CheckSkill(skillList.Skills(0)))
            {
                for (int i = 1; i < 5; i++)
                {
                    skillButtons[i].Enabled = false;
                }
            } else
            {
                for (int i = 1; i < 5; i++)
                {
                    enableSkillButton(i, i);
                }
            }
            if (!player.CheckSkill(skillList.Skills(4)))
            {
                
                skillButtons[5].Enabled = false;
                
            }
            else
            {
                
                enableSkillButton(5, 5);
                
            }
            if (!player.CheckSkill(skillList.Skills(3)))
            {

                skillButtons[6].Enabled = false;

            }
            else
            {

                enableSkillButton(6, 6);

            }
        }
        private void InventoryUpdate()
        {
            
            for (int i = 0; i < inventoryLabels.Length; i++)
            {
                
                if (player.inventory.Slots[i].Item != null)
                {
                    inventoryLabels[i].Text = player.inventory.Slots[i].Item.Emoji;
                    if (player.inventory.Slots[i].Amount == 1)
                        inventoryAmounts[i].Text = "";
                    else 
                        inventoryAmounts[i].Text = $"{player.inventory.Slots[i].Amount}";

                } else
                {
                    inventoryLabels[i].Text = "";
                    inventoryAmounts[i].Text = "";
                }
            }
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
                player.inventory.Add(mob.Try(itemList));
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
                for (int i = 0; i < skillButtons.Length; i++)
                {
                    skillButtons[i].ForeColor = Color.White;
                }
                UpdateUI();
            }

        }
        private void Select(int idSkill, Button button)
        {
            button.ForeColor = Color.Gold;
            player.LearnSkill(skillList.Skills(idSkill));
        }

        private void Skills_Button_Click(object sender, EventArgs e)
        {
            ViewButton(Skills_Button);
            skills_Panel.Visible = !skills_Panel.Visible;
        }

        private void Invetory_Button_Click(object sender, EventArgs e)
        {
            InventoryUpdate();
            ViewButton(Invetory_Button);
            Inventory_Panel.Visible = !Inventory_Panel.Visible;
        }
        private void Settings_Button_Click(object sender, EventArgs e)
        {
            Save_Button.Visible = !Save_Button.Visible;
            New_Game_Button.Visible = !New_Game_Button.Visible;
            ViewButton(Settings_Button);
        }
        private void Skill_Button_1_Click(object sender, EventArgs e)
        {
            Select(0, AttackUp_I);
            UpdateUI();
        }
        private void Armor_I_Click(object sender, EventArgs e)
        {
            Select(1, Armor_I);
            UpdateUI();
        }

        private void Health_I_Click(object sender, EventArgs e)
        {
            Select(2, Health_I);
            UpdateUI();
        }

        private void Vampire_I_Click(object sender, EventArgs e)
        {
            Select(3, Vampire_I);
            UpdateUI();
        }

        private void Crit_Chance_I_Click(object sender, EventArgs e)
        {
            Select(4, Crit_Chance_I);
            UpdateUI();
        }

        private void Crit_Chance_II_Click(object sender, EventArgs e)
        {
            Select(5, Crit_Chance_II);
            UpdateUI();
        }
        private void Vampire_II_Click(object sender, EventArgs e)
        {
            Select(6, Vampire_II);
            UpdateUI();
        }
    }
}
