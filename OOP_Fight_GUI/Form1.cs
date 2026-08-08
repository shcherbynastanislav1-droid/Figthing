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
        SaveManager loadDate = saveManager.Load();
        MobSelect mobs = new MobSelect();

        Battle battle;
        public Form1()
        {
            InitializeComponent();
            player = loadDate.Player;
            mob = loadDate.Mob;
            battle = new Battle(player, mob);
            label_Name_Player.Text = player.Name;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            console_Info.ReadOnly = true;
            UpdateUI();
        }
        private void UpdateUI()
        {
            label_Health_Player.Text = $"HP: {player.Health} / {player.HealthMax}";
            label_Attack_Player.Text = $"ATK: {player.AttackMax} / {player.AttackMin}";
            label_Lvl.Text = $"Lvl: {player.Lvl}";
            label_Exp.Text = $"Exp: {player.MaxExp} / {player.CurrentExp}";

            label_Name_Mob.Text = mob.Name;
            label_Health_Mob.Text = $"HP: {mob.Health} / {mob.HealthMax}";
            label_Attack_Mob.Text = $"ATK: {mob.AttackMax} / {mob.AttackMin}";
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
            New_Game_Button.Enabled = !New_Game_Button.Enabled;
            Save_Button.Enabled = !Save_Button.Enabled;
            Invetory_Button.Enabled = !Invetory_Button.Enabled;
            Skills_Button.Enabled = !Skills_Button.Enabled;
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
                "Вы хотите продолжить?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                
                player = saveManager.NewGame();
                mob = mobs.Add();
                saveManager.Save(player,mob);
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
        }
    }
}
