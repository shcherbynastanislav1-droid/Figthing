namespace OOP_Fight_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Attack_Button = new Button();
            label_Name_Player = new Label();
            label_Name_Mob = new Label();
            label_Health_Player = new Label();
            label_Health_Mob = new Label();
            Save_Button = new Button();
            label_Attack_Player = new Label();
            label_Lvl = new Label();
            label_Exp = new Label();
            label_Attack_Mob = new Label();
            console_Info = new RichTextBox();
            background_console = new Panel();
            New_Game_Button = new Button();
            Skills_Button = new Button();
            Invetory_Button = new Button();
            tool_Tip_AttackI = new ToolTip(components);
            panel3 = new Panel();
            panel31 = new Panel();
            panel32 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel33 = new Panel();
            panel34 = new Panel();
            Slot7 = new Panel();
            panel16 = new Panel();
            panel35 = new Panel();
            panel36 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel37 = new Panel();
            panel38 = new Panel();
            panel39 = new Panel();
            panel40 = new Panel();
            Slot6 = new Panel();
            panel14 = new Panel();
            panel41 = new Panel();
            panel42 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            panel43 = new Panel();
            panel44 = new Panel();
            Slot5 = new Panel();
            panel12 = new Panel();
            panel23 = new Panel();
            panel24 = new Panel();
            Slot4 = new Panel();
            panel10 = new Panel();
            panel25 = new Panel();
            panel26 = new Panel();
            Slot3 = new Panel();
            panel8 = new Panel();
            panel27 = new Panel();
            panel28 = new Panel();
            Slot2 = new Panel();
            panel6 = new Panel();
            panel29 = new Panel();
            panel30 = new Panel();
            Slot1 = new Panel();
            panel4 = new Panel();
            Inventory_Panel = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            Vampire_II = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_Skill_Point = new Label();
            Health_I = new Button();
            Armor_I = new Button();
            Crit_Chance_II = new Button();
            Crit_Chance_I = new Button();
            Vampire_I = new Button();
            AttackUp_I = new Button();
            skills_Panel = new Panel();
            Settings_Button = new Button();
            background_console.SuspendLayout();
            panel3.SuspendLayout();
            panel31.SuspendLayout();
            panel17.SuspendLayout();
            panel33.SuspendLayout();
            Slot7.SuspendLayout();
            panel35.SuspendLayout();
            panel19.SuspendLayout();
            panel37.SuspendLayout();
            panel39.SuspendLayout();
            Slot6.SuspendLayout();
            panel41.SuspendLayout();
            panel21.SuspendLayout();
            panel43.SuspendLayout();
            Slot5.SuspendLayout();
            panel23.SuspendLayout();
            Slot4.SuspendLayout();
            panel25.SuspendLayout();
            Slot3.SuspendLayout();
            panel27.SuspendLayout();
            Slot2.SuspendLayout();
            panel29.SuspendLayout();
            Slot1.SuspendLayout();
            Inventory_Panel.SuspendLayout();
            panel1.SuspendLayout();
            skills_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Attack_Button
            // 
            Attack_Button.BackColor = Color.FromArgb(30, 30, 30);
            Attack_Button.FlatAppearance.BorderColor = Color.HotPink;
            Attack_Button.FlatStyle = FlatStyle.Flat;
            Attack_Button.Location = new Point(19, 538);
            Attack_Button.Name = "Attack_Button";
            Attack_Button.Size = new Size(148, 59);
            Attack_Button.TabIndex = 0;
            Attack_Button.Text = "Attack";
            Attack_Button.UseVisualStyleBackColor = false;
            Attack_Button.Click += Attack_Button_Click;
            // 
            // label_Name_Player
            // 
            label_Name_Player.AutoSize = true;
            label_Name_Player.Location = new Point(23, 416);
            label_Name_Player.Name = "label_Name_Player";
            label_Name_Player.Size = new Size(51, 15);
            label_Name_Player.TabIndex = 1;
            label_Name_Player.Text = "Deda";
            // 
            // label_Name_Mob
            // 
            label_Name_Mob.AutoSize = true;
            label_Name_Mob.Location = new Point(449, 33);
            label_Name_Mob.Name = "label_Name_Mob";
            label_Name_Mob.Size = new Size(66, 15);
            label_Name_Mob.TabIndex = 2;
            label_Name_Mob.Text = "Zombie";
            // 
            // label_Health_Player
            // 
            label_Health_Player.ForeColor = Color.LimeGreen;
            label_Health_Player.Location = new Point(23, 440);
            label_Health_Player.Name = "label_Health_Player";
            label_Health_Player.Size = new Size(500, 15);
            label_Health_Player.TabIndex = 5;
            label_Health_Player.Text = "HP:";
            // 
            // label_Health_Mob
            // 
            label_Health_Mob.ForeColor = Color.Crimson;
            label_Health_Mob.Location = new Point(449, 57);
            label_Health_Mob.Name = "label_Health_Mob";
            label_Health_Mob.Size = new Size(100, 15);
            label_Health_Mob.TabIndex = 6;
            label_Health_Mob.Text = "HP:";
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.FromArgb(30, 30, 30);
            Save_Button.FlatAppearance.BorderColor = Color.HotPink;
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Location = new Point(449, 400);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(116, 59);
            Save_Button.TabIndex = 7;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Visible = false;
            Save_Button.Click += Save_Button_Click;
            // 
            // label_Attack_Player
            // 
            label_Attack_Player.Location = new Point(23, 455);
            label_Attack_Player.Name = "label_Attack_Player";
            label_Attack_Player.Size = new Size(500, 15);
            label_Attack_Player.TabIndex = 8;
            label_Attack_Player.Text = "ATK:";
            // 
            // label_Lvl
            // 
            label_Lvl.ForeColor = Color.Gold;
            label_Lvl.Location = new Point(23, 489);
            label_Lvl.Name = "label_Lvl";
            label_Lvl.Size = new Size(200, 15);
            label_Lvl.TabIndex = 9;
            label_Lvl.Text = "LVL:";
            // 
            // label_Exp
            // 
            label_Exp.ForeColor = Color.Gold;
            label_Exp.Location = new Point(23, 504);
            label_Exp.Name = "label_Exp";
            label_Exp.Size = new Size(500, 15);
            label_Exp.TabIndex = 10;
            label_Exp.Text = "Exp:";
            // 
            // label_Attack_Mob
            // 
            label_Attack_Mob.Location = new Point(449, 72);
            label_Attack_Mob.Name = "label_Attack_Mob";
            label_Attack_Mob.Size = new Size(100, 15);
            label_Attack_Mob.TabIndex = 11;
            label_Attack_Mob.Text = "ATK:";
            // 
            // console_Info
            // 
            console_Info.BackColor = Color.FromArgb(30, 30, 30);
            console_Info.BorderStyle = BorderStyle.None;
            console_Info.ForeColor = Color.HotPink;
            console_Info.Location = new Point(2, 2);
            console_Info.Name = "console_Info";
            console_Info.Size = new Size(242, 112);
            console_Info.TabIndex = 14;
            console_Info.Text = "";
            // 
            // background_console
            // 
            background_console.BackColor = Color.HotPink;
            background_console.Controls.Add(console_Info);
            background_console.Location = new Point(0, 0);
            background_console.Name = "background_console";
            background_console.Size = new Size(246, 116);
            background_console.TabIndex = 15;
            // 
            // New_Game_Button
            // 
            New_Game_Button.BackColor = Color.FromArgb(30, 30, 30);
            New_Game_Button.FlatAppearance.BorderColor = Color.HotPink;
            New_Game_Button.FlatStyle = FlatStyle.Flat;
            New_Game_Button.Location = new Point(449, 467);
            New_Game_Button.Name = "New_Game_Button";
            New_Game_Button.Size = new Size(116, 59);
            New_Game_Button.TabIndex = 16;
            New_Game_Button.Text = "New_Game";
            New_Game_Button.UseVisualStyleBackColor = false;
            New_Game_Button.Visible = false;
            New_Game_Button.Click += New_Game_Button_Click;
            // 
            // Skills_Button
            // 
            Skills_Button.BackColor = Color.FromArgb(30, 30, 30);
            Skills_Button.FlatAppearance.BorderColor = Color.HotPink;
            Skills_Button.FlatStyle = FlatStyle.Flat;
            Skills_Button.Location = new Point(292, 538);
            Skills_Button.Name = "Skills_Button";
            Skills_Button.Size = new Size(123, 59);
            Skills_Button.TabIndex = 18;
            Skills_Button.Text = "Skills";
            Skills_Button.UseVisualStyleBackColor = false;
            Skills_Button.Click += Skills_Button_Click;
            // 
            // Invetory_Button
            // 
            Invetory_Button.BackColor = Color.FromArgb(30, 30, 30);
            Invetory_Button.FlatAppearance.BorderColor = Color.HotPink;
            Invetory_Button.FlatStyle = FlatStyle.Flat;
            Invetory_Button.Location = new Point(173, 538);
            Invetory_Button.Name = "Invetory_Button";
            Invetory_Button.Size = new Size(113, 59);
            Invetory_Button.TabIndex = 19;
            Invetory_Button.Text = "Invetory";
            Invetory_Button.UseVisualStyleBackColor = false;
            Invetory_Button.Click += Invetory_Button_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(panel31);
            panel3.Controls.Add(panel17);
            panel3.Controls.Add(panel33);
            panel3.Controls.Add(Slot7);
            panel3.Controls.Add(panel35);
            panel3.Controls.Add(panel19);
            panel3.Controls.Add(panel37);
            panel3.Controls.Add(panel39);
            panel3.Controls.Add(Slot6);
            panel3.Controls.Add(panel41);
            panel3.Controls.Add(panel21);
            panel3.Controls.Add(panel43);
            panel3.Controls.Add(Slot5);
            panel3.Controls.Add(panel23);
            panel3.Controls.Add(Slot4);
            panel3.Controls.Add(panel25);
            panel3.Controls.Add(Slot3);
            panel3.Controls.Add(panel27);
            panel3.Controls.Add(Slot2);
            panel3.Controls.Add(panel29);
            panel3.Controls.Add(Slot1);
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 354);
            panel3.TabIndex = 0;
            // 
            // panel31
            // 
            panel31.BackColor = Color.HotPink;
            panel31.Controls.Add(panel32);
            panel31.Location = new Point(389, 157);
            panel31.Name = "panel31";
            panel31.Size = new Size(55, 55);
            panel31.TabIndex = 4;
            // 
            // panel32
            // 
            panel32.BackColor = Color.FromArgb(30, 30, 30);
            panel32.BorderStyle = BorderStyle.FixedSingle;
            panel32.Location = new Point(2, 2);
            panel32.Name = "panel32";
            panel32.Size = new Size(51, 51);
            panel32.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.BackColor = Color.HotPink;
            panel17.Controls.Add(panel18);
            panel17.Location = new Point(389, 87);
            panel17.Name = "panel17";
            panel17.Size = new Size(55, 55);
            panel17.TabIndex = 4;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(30, 30, 30);
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Location = new Point(2, 2);
            panel18.Name = "panel18";
            panel18.Size = new Size(51, 51);
            panel18.TabIndex = 1;
            // 
            // panel33
            // 
            panel33.BackColor = Color.HotPink;
            panel33.Controls.Add(panel34);
            panel33.Location = new Point(328, 157);
            panel33.Name = "panel33";
            panel33.Size = new Size(55, 55);
            panel33.TabIndex = 5;
            // 
            // panel34
            // 
            panel34.BackColor = Color.FromArgb(30, 30, 30);
            panel34.BorderStyle = BorderStyle.FixedSingle;
            panel34.Location = new Point(2, 2);
            panel34.Name = "panel34";
            panel34.Size = new Size(51, 51);
            panel34.TabIndex = 1;
            // 
            // Slot7
            // 
            Slot7.BackColor = Color.HotPink;
            Slot7.Controls.Add(panel16);
            Slot7.Location = new Point(389, 15);
            Slot7.Name = "Slot7";
            Slot7.Size = new Size(55, 55);
            Slot7.TabIndex = 2;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(30, 30, 30);
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Location = new Point(2, 2);
            panel16.Name = "panel16";
            panel16.Size = new Size(51, 51);
            panel16.TabIndex = 1;
            // 
            // panel35
            // 
            panel35.BackColor = Color.HotPink;
            panel35.Controls.Add(panel36);
            panel35.Location = new Point(263, 157);
            panel35.Name = "panel35";
            panel35.Size = new Size(55, 55);
            panel35.TabIndex = 6;
            // 
            // panel36
            // 
            panel36.BackColor = Color.FromArgb(30, 30, 30);
            panel36.BorderStyle = BorderStyle.FixedSingle;
            panel36.Location = new Point(2, 2);
            panel36.Name = "panel36";
            panel36.Size = new Size(51, 51);
            panel36.TabIndex = 1;
            // 
            // panel19
            // 
            panel19.BackColor = Color.HotPink;
            panel19.Controls.Add(panel20);
            panel19.Location = new Point(328, 87);
            panel19.Name = "panel19";
            panel19.Size = new Size(55, 55);
            panel19.TabIndex = 5;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(30, 30, 30);
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Location = new Point(2, 2);
            panel20.Name = "panel20";
            panel20.Size = new Size(51, 51);
            panel20.TabIndex = 1;
            // 
            // panel37
            // 
            panel37.BackColor = Color.HotPink;
            panel37.Controls.Add(panel38);
            panel37.Location = new Point(202, 157);
            panel37.Name = "panel37";
            panel37.Size = new Size(55, 55);
            panel37.TabIndex = 7;
            // 
            // panel38
            // 
            panel38.BackColor = Color.FromArgb(30, 30, 30);
            panel38.BorderStyle = BorderStyle.FixedSingle;
            panel38.Location = new Point(2, 2);
            panel38.Name = "panel38";
            panel38.Size = new Size(51, 51);
            panel38.TabIndex = 1;
            // 
            // panel39
            // 
            panel39.BackColor = Color.HotPink;
            panel39.Controls.Add(panel40);
            panel39.Location = new Point(141, 157);
            panel39.Name = "panel39";
            panel39.Size = new Size(55, 55);
            panel39.TabIndex = 8;
            // 
            // panel40
            // 
            panel40.BackColor = Color.FromArgb(30, 30, 30);
            panel40.BorderStyle = BorderStyle.FixedSingle;
            panel40.Location = new Point(2, 2);
            panel40.Name = "panel40";
            panel40.Size = new Size(51, 51);
            panel40.TabIndex = 1;
            // 
            // Slot6
            // 
            Slot6.BackColor = Color.HotPink;
            Slot6.Controls.Add(panel14);
            Slot6.Location = new Point(328, 15);
            Slot6.Name = "Slot6";
            Slot6.Size = new Size(55, 55);
            Slot6.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(30, 30, 30);
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Location = new Point(2, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(51, 51);
            panel14.TabIndex = 1;
            // 
            // panel41
            // 
            panel41.BackColor = Color.HotPink;
            panel41.Controls.Add(panel42);
            panel41.Location = new Point(80, 157);
            panel41.Name = "panel41";
            panel41.Size = new Size(55, 55);
            panel41.TabIndex = 9;
            // 
            // panel42
            // 
            panel42.BackColor = Color.FromArgb(30, 30, 30);
            panel42.BorderStyle = BorderStyle.FixedSingle;
            panel42.Location = new Point(2, 2);
            panel42.Name = "panel42";
            panel42.Size = new Size(51, 51);
            panel42.TabIndex = 1;
            // 
            // panel21
            // 
            panel21.BackColor = Color.HotPink;
            panel21.Controls.Add(panel22);
            panel21.Location = new Point(263, 87);
            panel21.Name = "panel21";
            panel21.Size = new Size(55, 55);
            panel21.TabIndex = 6;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(30, 30, 30);
            panel22.BorderStyle = BorderStyle.FixedSingle;
            panel22.Location = new Point(2, 2);
            panel22.Name = "panel22";
            panel22.Size = new Size(51, 51);
            panel22.TabIndex = 1;
            // 
            // panel43
            // 
            panel43.BackColor = Color.HotPink;
            panel43.Controls.Add(panel44);
            panel43.Location = new Point(19, 157);
            panel43.Name = "panel43";
            panel43.Size = new Size(55, 55);
            panel43.TabIndex = 3;
            // 
            // panel44
            // 
            panel44.BackColor = Color.FromArgb(30, 30, 30);
            panel44.BorderStyle = BorderStyle.FixedSingle;
            panel44.Location = new Point(2, 2);
            panel44.Name = "panel44";
            panel44.Size = new Size(51, 51);
            panel44.TabIndex = 1;
            // 
            // Slot5
            // 
            Slot5.BackColor = Color.HotPink;
            Slot5.Controls.Add(panel12);
            Slot5.Location = new Point(263, 15);
            Slot5.Name = "Slot5";
            Slot5.Size = new Size(55, 55);
            Slot5.TabIndex = 2;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(30, 30, 30);
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Location = new Point(2, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(51, 51);
            panel12.TabIndex = 1;
            // 
            // panel23
            // 
            panel23.BackColor = Color.HotPink;
            panel23.Controls.Add(panel24);
            panel23.Location = new Point(202, 87);
            panel23.Name = "panel23";
            panel23.Size = new Size(55, 55);
            panel23.TabIndex = 7;
            // 
            // panel24
            // 
            panel24.BackColor = Color.FromArgb(30, 30, 30);
            panel24.BorderStyle = BorderStyle.FixedSingle;
            panel24.Location = new Point(2, 2);
            panel24.Name = "panel24";
            panel24.Size = new Size(51, 51);
            panel24.TabIndex = 1;
            // 
            // Slot4
            // 
            Slot4.BackColor = Color.HotPink;
            Slot4.Controls.Add(panel10);
            Slot4.Location = new Point(202, 15);
            Slot4.Name = "Slot4";
            Slot4.Size = new Size(55, 55);
            Slot4.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(30, 30, 30);
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(2, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(51, 51);
            panel10.TabIndex = 1;
            // 
            // panel25
            // 
            panel25.BackColor = Color.HotPink;
            panel25.Controls.Add(panel26);
            panel25.Location = new Point(141, 87);
            panel25.Name = "panel25";
            panel25.Size = new Size(55, 55);
            panel25.TabIndex = 8;
            // 
            // panel26
            // 
            panel26.BackColor = Color.FromArgb(30, 30, 30);
            panel26.BorderStyle = BorderStyle.FixedSingle;
            panel26.Location = new Point(2, 2);
            panel26.Name = "panel26";
            panel26.Size = new Size(51, 51);
            panel26.TabIndex = 1;
            // 
            // Slot3
            // 
            Slot3.BackColor = Color.HotPink;
            Slot3.Controls.Add(panel8);
            Slot3.Location = new Point(141, 15);
            Slot3.Name = "Slot3";
            Slot3.Size = new Size(55, 55);
            Slot3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(30, 30, 30);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(51, 51);
            panel8.TabIndex = 1;
            // 
            // panel27
            // 
            panel27.BackColor = Color.HotPink;
            panel27.Controls.Add(panel28);
            panel27.Location = new Point(80, 87);
            panel27.Name = "panel27";
            panel27.Size = new Size(55, 55);
            panel27.TabIndex = 9;
            // 
            // panel28
            // 
            panel28.BackColor = Color.FromArgb(30, 30, 30);
            panel28.BorderStyle = BorderStyle.FixedSingle;
            panel28.Location = new Point(2, 2);
            panel28.Name = "panel28";
            panel28.Size = new Size(51, 51);
            panel28.TabIndex = 1;
            // 
            // Slot2
            // 
            Slot2.BackColor = Color.HotPink;
            Slot2.Controls.Add(panel6);
            Slot2.Location = new Point(80, 15);
            Slot2.Name = "Slot2";
            Slot2.Size = new Size(55, 55);
            Slot2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(30, 30, 30);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(51, 51);
            panel6.TabIndex = 1;
            // 
            // panel29
            // 
            panel29.BackColor = Color.HotPink;
            panel29.Controls.Add(panel30);
            panel29.Location = new Point(19, 87);
            panel29.Name = "panel29";
            panel29.Size = new Size(55, 55);
            panel29.TabIndex = 3;
            // 
            // panel30
            // 
            panel30.BackColor = Color.FromArgb(30, 30, 30);
            panel30.BorderStyle = BorderStyle.FixedSingle;
            panel30.Location = new Point(2, 2);
            panel30.Name = "panel30";
            panel30.Size = new Size(51, 51);
            panel30.TabIndex = 1;
            // 
            // Slot1
            // 
            Slot1.BackColor = Color.HotPink;
            Slot1.Controls.Add(panel4);
            Slot1.Location = new Point(19, 15);
            Slot1.Name = "Slot1";
            Slot1.Size = new Size(55, 55);
            Slot1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 51);
            panel4.TabIndex = 1;
            // 
            // Inventory_Panel
            // 
            Inventory_Panel.BackColor = Color.HotPink;
            Inventory_Panel.Controls.Add(panel3);
            Inventory_Panel.Location = new Point(2, 172);
            Inventory_Panel.Name = "Inventory_Panel";
            Inventory_Panel.Size = new Size(471, 358);
            Inventory_Panel.TabIndex = 22;
            Inventory_Panel.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Vampire_II);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_Skill_Point);
            panel1.Controls.Add(Health_I);
            panel1.Controls.Add(Armor_I);
            panel1.Controls.Add(Crit_Chance_II);
            panel1.Controls.Add(Crit_Chance_I);
            panel1.Controls.Add(Vampire_I);
            panel1.Controls.Add(AttackUp_I);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 354);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 74);
            label6.Name = "label6";
            label6.Size = new Size(11, 15);
            label6.TabIndex = 33;
            label6.Text = "|";
            // 
            // Vampire_II
            // 
            Vampire_II.BackColor = Color.FromArgb(30, 30, 30);
            Vampire_II.FlatAppearance.BorderColor = Color.HotPink;
            Vampire_II.FlatStyle = FlatStyle.Flat;
            Vampire_II.Location = new Point(203, 21);
            Vampire_II.Name = "Vampire_II";
            Vampire_II.Size = new Size(50, 50);
            Vampire_II.TabIndex = 32;
            Vampire_II.Text = "VMP II";
            Vampire_II.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 149);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 31;
            label5.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 151);
            label4.Name = "label4";
            label4.Size = new Size(11, 15);
            label4.TabIndex = 30;
            label4.Text = "|";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 206);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 29;
            label3.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 158);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 28;
            label2.Text = "\\";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 176);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 27;
            label1.Text = "/";
            // 
            // label_Skill_Point
            // 
            label_Skill_Point.Location = new Point(3, 330);
            label_Skill_Point.Name = "label_Skill_Point";
            label_Skill_Point.Size = new Size(100, 15);
            label_Skill_Point.TabIndex = 23;
            label_Skill_Point.Text = "Points: ";
            // 
            // Health_I
            // 
            Health_I.BackColor = Color.FromArgb(30, 30, 30);
            Health_I.FlatAppearance.BorderColor = Color.HotPink;
            Health_I.FlatStyle = FlatStyle.Flat;
            Health_I.Location = new Point(131, 133);
            Health_I.Name = "Health_I";
            Health_I.Size = new Size(50, 50);
            Health_I.TabIndex = 26;
            Health_I.Text = "HLT I";
            Health_I.UseVisualStyleBackColor = false;
            Health_I.Click += Health_I_Click;
            // 
            // Armor_I
            // 
            Armor_I.BackColor = Color.FromArgb(30, 30, 30);
            Armor_I.FlatAppearance.BorderColor = Color.HotPink;
            Armor_I.FlatStyle = FlatStyle.Flat;
            Armor_I.Location = new Point(131, 200);
            Armor_I.Name = "Armor_I";
            Armor_I.Size = new Size(50, 50);
            Armor_I.TabIndex = 25;
            Armor_I.Text = "ARM I";
            Armor_I.UseVisualStyleBackColor = false;
            Armor_I.Click += Armor_I_Click;
            // 
            // Crit_Chance_II
            // 
            Crit_Chance_II.BackColor = Color.FromArgb(30, 30, 30);
            Crit_Chance_II.FlatAppearance.BorderColor = Color.HotPink;
            Crit_Chance_II.FlatStyle = FlatStyle.Flat;
            Crit_Chance_II.Location = new Point(344, 133);
            Crit_Chance_II.Name = "Crit_Chance_II";
            Crit_Chance_II.Size = new Size(50, 50);
            Crit_Chance_II.TabIndex = 24;
            Crit_Chance_II.Text = "CRT II";
            Crit_Chance_II.UseVisualStyleBackColor = false;
            Crit_Chance_II.Click += Crit_Chance_II_Click;
            // 
            // Crit_Chance_I
            // 
            Crit_Chance_I.BackColor = Color.FromArgb(30, 30, 30);
            Crit_Chance_I.FlatAppearance.BorderColor = Color.HotPink;
            Crit_Chance_I.FlatStyle = FlatStyle.Flat;
            Crit_Chance_I.Location = new Point(274, 133);
            Crit_Chance_I.Name = "Crit_Chance_I";
            Crit_Chance_I.Size = new Size(50, 50);
            Crit_Chance_I.TabIndex = 23;
            Crit_Chance_I.Text = "CRT I";
            Crit_Chance_I.UseVisualStyleBackColor = false;
            Crit_Chance_I.Click += Crit_Chance_I_Click;
            // 
            // Vampire_I
            // 
            Vampire_I.BackColor = Color.FromArgb(30, 30, 30);
            Vampire_I.FlatAppearance.BorderColor = Color.HotPink;
            Vampire_I.FlatStyle = FlatStyle.Flat;
            Vampire_I.Location = new Point(203, 93);
            Vampire_I.Name = "Vampire_I";
            Vampire_I.Size = new Size(50, 50);
            Vampire_I.TabIndex = 22;
            Vampire_I.Text = "VMP I";
            Vampire_I.UseVisualStyleBackColor = false;
            Vampire_I.Click += Vampire_I_Click;
            // 
            // AttackUp_I
            // 
            AttackUp_I.BackColor = Color.FromArgb(30, 30, 30);
            AttackUp_I.FlatAppearance.BorderColor = Color.HotPink;
            AttackUp_I.FlatStyle = FlatStyle.Flat;
            AttackUp_I.Location = new Point(203, 171);
            AttackUp_I.Name = "AttackUp_I";
            AttackUp_I.Size = new Size(50, 50);
            AttackUp_I.TabIndex = 21;
            AttackUp_I.Text = "ATK I";
            AttackUp_I.UseVisualStyleBackColor = false;
            AttackUp_I.Click += Skill_Button_1_Click;
            // 
            // skills_Panel
            // 
            skills_Panel.BackColor = Color.HotPink;
            skills_Panel.Controls.Add(panel1);
            skills_Panel.Location = new Point(101, 172);
            skills_Panel.Name = "skills_Panel";
            skills_Panel.Size = new Size(471, 358);
            skills_Panel.TabIndex = 20;
            skills_Panel.Visible = false;
            // 
            // Settings_Button
            // 
            Settings_Button.BackColor = Color.FromArgb(30, 30, 30);
            Settings_Button.FlatAppearance.BorderColor = Color.HotPink;
            Settings_Button.FlatStyle = FlatStyle.Flat;
            Settings_Button.Location = new Point(449, 538);
            Settings_Button.Name = "Settings_Button";
            Settings_Button.Size = new Size(116, 59);
            Settings_Button.TabIndex = 23;
            Settings_Button.Text = "Settings";
            Settings_Button.UseVisualStyleBackColor = false;
            Settings_Button.Click += Settings_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(577, 609);
            Controls.Add(Settings_Button);
            Controls.Add(skills_Panel);
            Controls.Add(Inventory_Panel);
            Controls.Add(New_Game_Button);
            Controls.Add(Save_Button);
            Controls.Add(Invetory_Button);
            Controls.Add(Skills_Button);
            Controls.Add(background_console);
            Controls.Add(label_Attack_Mob);
            Controls.Add(label_Exp);
            Controls.Add(label_Lvl);
            Controls.Add(label_Attack_Player);
            Controls.Add(label_Health_Mob);
            Controls.Add(label_Health_Player);
            Controls.Add(label_Name_Mob);
            Controls.Add(label_Name_Player);
            Controls.Add(Attack_Button);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            background_console.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel31.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel33.ResumeLayout(false);
            Slot7.ResumeLayout(false);
            panel35.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel37.ResumeLayout(false);
            panel39.ResumeLayout(false);
            Slot6.ResumeLayout(false);
            panel41.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel43.ResumeLayout(false);
            Slot5.ResumeLayout(false);
            panel23.ResumeLayout(false);
            Slot4.ResumeLayout(false);
            panel25.ResumeLayout(false);
            Slot3.ResumeLayout(false);
            panel27.ResumeLayout(false);
            Slot2.ResumeLayout(false);
            panel29.ResumeLayout(false);
            Slot1.ResumeLayout(false);
            Inventory_Panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            skills_Panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Attack_Button;
        private Label label_Name_Player;
        private Label label_Name_Mob;
        private Label label_Health_Player;
        private Label label_Health_Mob;
        private Button Save_Button;
        private Label label_Attack_Player;
        private Label label_Lvl;
        private Label label_Exp;
        private Label label_Attack_Mob;
        private RichTextBox console_Info;
        private Panel background_console;
        private Button New_Game_Button;
        private Button Skills_Button;
        private Button Invetory_Button;
        private ToolTip tool_Tip_AttackI;
        private Panel panel3;
        private Panel panel31;
        private Panel panel32;
        private Panel panel17;
        private Panel panel18;
        private Panel panel33;
        private Panel panel34;
        private Panel Slot7;
        private Panel panel16;
        private Panel panel35;
        private Panel panel36;
        private Panel panel19;
        private Panel panel20;
        private Panel panel37;
        private Panel panel38;
        private Panel panel39;
        private Panel panel40;
        private Panel Slot6;
        private Panel panel14;
        private Panel panel41;
        private Panel panel42;
        private Panel panel21;
        private Panel panel22;
        private Panel panel43;
        private Panel panel44;
        private Panel Slot5;
        private Panel panel12;
        private Panel panel23;
        private Panel panel24;
        private Panel Slot4;
        private Panel panel10;
        private Panel panel25;
        private Panel panel26;
        private Panel Slot3;
        private Panel panel8;
        private Panel panel27;
        private Panel panel28;
        private Panel Slot2;
        private Panel panel6;
        private Panel panel29;
        private Panel panel30;
        private Panel Slot1;
        private Panel panel4;
        private Panel Inventory_Panel;
        private Panel panel1;
        private Label label6;
        private Button Vampire_II;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label_Skill_Point;
        private Button Health_I;
        private Button Armor_I;
        private Button Crit_Chance_II;
        private Button Crit_Chance_I;
        private Button Vampire_I;
        private Button AttackUp_I;
        private Panel skills_Panel;
        private Button Settings_Button;
    }
}
