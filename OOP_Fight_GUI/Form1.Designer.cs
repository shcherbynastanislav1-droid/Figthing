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
            skills_Panel = new Panel();
            panel1 = new Panel();
            background_console.SuspendLayout();
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
            label_Health_Player.Size = new Size(100, 15);
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
            Save_Button.Location = new Point(449, 538);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(116, 59);
            Save_Button.TabIndex = 7;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Click += Save_Button_Click;
            // 
            // label_Attack_Player
            // 
            label_Attack_Player.Location = new Point(23, 455);
            label_Attack_Player.Name = "label_Attack_Player";
            label_Attack_Player.Size = new Size(100, 15);
            label_Attack_Player.TabIndex = 8;
            label_Attack_Player.Text = "ATK:";
            // 
            // label_Lvl
            // 
            label_Lvl.ForeColor = Color.Gold;
            label_Lvl.Location = new Point(23, 489);
            label_Lvl.Name = "label_Lvl";
            label_Lvl.Size = new Size(70, 15);
            label_Lvl.TabIndex = 9;
            label_Lvl.Text = "LVL:";
            // 
            // label_Exp
            // 
            label_Exp.ForeColor = Color.Gold;
            label_Exp.Location = new Point(23, 504);
            label_Exp.Name = "label_Exp";
            label_Exp.Size = new Size(150, 15);
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
            // skills_Panel
            // 
            skills_Panel.BackColor = Color.HotPink;
            skills_Panel.Controls.Add(panel1);
            skills_Panel.Location = new Point(60, 174);
            skills_Panel.Name = "skills_Panel";
            skills_Panel.Size = new Size(471, 358);
            skills_Panel.TabIndex = 20;
            skills_Panel.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 354);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(577, 609);
            Controls.Add(skills_Panel);
            Controls.Add(Invetory_Button);
            Controls.Add(Skills_Button);
            Controls.Add(New_Game_Button);
            Controls.Add(background_console);
            Controls.Add(label_Attack_Mob);
            Controls.Add(label_Exp);
            Controls.Add(label_Lvl);
            Controls.Add(label_Attack_Player);
            Controls.Add(Save_Button);
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
        private Panel skills_Panel;
        private Panel panel1;
    }
}
