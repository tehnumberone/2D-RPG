namespace _2D_RPG
{
    partial class Charactercreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCharname = new System.Windows.Forms.TextBox();
            this.CharacterDetails = new System.Windows.Forms.GroupBox();
            this.inputRace = new System.Windows.Forms.ComboBox();
            this.bCreateChar = new System.Windows.Forms.Button();
            this.CharacterStats = new System.Windows.Forms.GroupBox();
            this.statsAgility = new System.Windows.Forms.NumericUpDown();
            this.statsVitality = new System.Windows.Forms.NumericUpDown();
            this.statsHealth = new System.Windows.Forms.NumericUpDown();
            this.statsAttack = new System.Windows.Forms.NumericUpDown();
            this.statsStrength = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CharacterDetails.SuspendLayout();
            this.CharacterStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsVitality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Character race";
            // 
            // inputCharname
            // 
            this.inputCharname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCharname.Location = new System.Drawing.Point(6, 51);
            this.inputCharname.MaxLength = 20;
            this.inputCharname.Name = "inputCharname";
            this.inputCharname.Size = new System.Drawing.Size(291, 29);
            this.inputCharname.TabIndex = 2;
            // 
            // CharacterDetails
            // 
            this.CharacterDetails.Controls.Add(this.inputRace);
            this.CharacterDetails.Controls.Add(this.label1);
            this.CharacterDetails.Controls.Add(this.label2);
            this.CharacterDetails.Controls.Add(this.inputCharname);
            this.CharacterDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CharacterDetails.Location = new System.Drawing.Point(12, 12);
            this.CharacterDetails.Name = "CharacterDetails";
            this.CharacterDetails.Size = new System.Drawing.Size(307, 318);
            this.CharacterDetails.TabIndex = 3;
            this.CharacterDetails.TabStop = false;
            // 
            // inputRace
            // 
            this.inputRace.FormattingEnabled = true;
            this.inputRace.Items.AddRange(new object[] {
            "Human",
            "Chicken",
            "Cow"});
            this.inputRace.Location = new System.Drawing.Point(6, 157);
            this.inputRace.Name = "inputRace";
            this.inputRace.Size = new System.Drawing.Size(287, 21);
            this.inputRace.TabIndex = 3;
            this.inputRace.Text = "Pick a race...";
            this.inputRace.SelectedIndexChanged += new System.EventHandler(this.inputRace_SelectedIndexChanged);
            // 
            // bCreateChar
            // 
            this.bCreateChar.Location = new System.Drawing.Point(12, 345);
            this.bCreateChar.Name = "bCreateChar";
            this.bCreateChar.Size = new System.Drawing.Size(121, 64);
            this.bCreateChar.TabIndex = 4;
            this.bCreateChar.Text = "Create Character";
            this.bCreateChar.UseVisualStyleBackColor = true;
            this.bCreateChar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterStats
            // 
            this.CharacterStats.Controls.Add(this.label10);
            this.CharacterStats.Controls.Add(this.label9);
            this.CharacterStats.Controls.Add(this.statsAgility);
            this.CharacterStats.Controls.Add(this.statsVitality);
            this.CharacterStats.Controls.Add(this.statsHealth);
            this.CharacterStats.Controls.Add(this.statsAttack);
            this.CharacterStats.Controls.Add(this.statsStrength);
            this.CharacterStats.Controls.Add(this.label8);
            this.CharacterStats.Controls.Add(this.label7);
            this.CharacterStats.Controls.Add(this.label6);
            this.CharacterStats.Controls.Add(this.label5);
            this.CharacterStats.Controls.Add(this.label4);
            this.CharacterStats.Controls.Add(this.label3);
            this.CharacterStats.Location = new System.Drawing.Point(349, 12);
            this.CharacterStats.Name = "CharacterStats";
            this.CharacterStats.Size = new System.Drawing.Size(426, 318);
            this.CharacterStats.TabIndex = 5;
            this.CharacterStats.TabStop = false;
            this.CharacterStats.Visible = false;
            // 
            // statsAgility
            // 
            this.statsAgility.Location = new System.Drawing.Point(103, 172);
            this.statsAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsAgility.Name = "statsAgility";
            this.statsAgility.Size = new System.Drawing.Size(120, 20);
            this.statsAgility.TabIndex = 14;
            this.statsAgility.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsAgility.ValueChanged += new System.EventHandler(this.checkcap);
            // 
            // statsVitality
            // 
            this.statsVitality.Location = new System.Drawing.Point(103, 147);
            this.statsVitality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsVitality.Name = "statsVitality";
            this.statsVitality.Size = new System.Drawing.Size(120, 20);
            this.statsVitality.TabIndex = 13;
            this.statsVitality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsVitality.ValueChanged += new System.EventHandler(this.checkcap);
            // 
            // statsHealth
            // 
            this.statsHealth.Location = new System.Drawing.Point(103, 121);
            this.statsHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsHealth.Name = "statsHealth";
            this.statsHealth.Size = new System.Drawing.Size(120, 20);
            this.statsHealth.TabIndex = 12;
            this.statsHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsHealth.ValueChanged += new System.EventHandler(this.checkcap);
            // 
            // statsAttack
            // 
            this.statsAttack.Location = new System.Drawing.Point(103, 95);
            this.statsAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsAttack.Name = "statsAttack";
            this.statsAttack.Size = new System.Drawing.Size(120, 20);
            this.statsAttack.TabIndex = 11;
            this.statsAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsAttack.ValueChanged += new System.EventHandler(this.checkcap);
            // 
            // statsStrength
            // 
            this.statsStrength.Location = new System.Drawing.Point(103, 68);
            this.statsStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsStrength.Name = "statsStrength";
            this.statsStrength.Size = new System.Drawing.Size(120, 20);
            this.statsStrength.TabIndex = 10;
            this.statsStrength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statsStrength.ValueChanged += new System.EventHandler(this.checkcap);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Agility";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vitality";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Health";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Attack";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Strength";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character Stats";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Remaining Skillpoints";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // Charactercreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CharacterStats);
            this.Controls.Add(this.bCreateChar);
            this.Controls.Add(this.CharacterDetails);
            this.Name = "Charactercreation";
            this.Text = "Charactercreation";
            this.CharacterDetails.ResumeLayout(false);
            this.CharacterDetails.PerformLayout();
            this.CharacterStats.ResumeLayout(false);
            this.CharacterStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsVitality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsStrength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCharname;
        private System.Windows.Forms.GroupBox CharacterDetails;
        private System.Windows.Forms.ComboBox inputRace;
        private System.Windows.Forms.Button bCreateChar;
        private System.Windows.Forms.GroupBox CharacterStats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown statsAgility;
        private System.Windows.Forms.NumericUpDown statsVitality;
        private System.Windows.Forms.NumericUpDown statsHealth;
        private System.Windows.Forms.NumericUpDown statsAttack;
        private System.Windows.Forms.NumericUpDown statsStrength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}