namespace _2D_RPG
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.pPlayer = new System.Windows.Forms.PictureBox();
            this.lAgi = new System.Windows.Forms.Label();
            this.lVit = new System.Windows.Forms.Label();
            this.lHP = new System.Windows.Forms.Label();
            this.lAtk = new System.Windows.Forms.Label();
            this.lStr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pPlayer
            // 
            this.pPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pPlayer.Image")));
            this.pPlayer.Location = new System.Drawing.Point(565, 258);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(90, 90);
            this.pPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPlayer.TabIndex = 2;
            this.pPlayer.TabStop = false;
            // 
            // lAgi
            // 
            this.lAgi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lAgi.AutoSize = true;
            this.lAgi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAgi.Location = new System.Drawing.Point(6, 130);
            this.lAgi.Name = "lAgi";
            this.lAgi.Size = new System.Drawing.Size(57, 18);
            this.lAgi.TabIndex = 14;
            this.lAgi.Text = "Agility";
            // 
            // lVit
            // 
            this.lVit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lVit.AutoSize = true;
            this.lVit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVit.Location = new System.Drawing.Point(6, 103);
            this.lVit.Name = "lVit";
            this.lVit.Size = new System.Drawing.Size(62, 18);
            this.lVit.TabIndex = 13;
            this.lVit.Text = "Vitality";
            // 
            // lHP
            // 
            this.lHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lHP.AutoSize = true;
            this.lHP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHP.Location = new System.Drawing.Point(6, 77);
            this.lHP.Name = "lHP";
            this.lHP.Size = new System.Drawing.Size(60, 18);
            this.lHP.TabIndex = 12;
            this.lHP.Text = "Health";
            // 
            // lAtk
            // 
            this.lAtk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lAtk.AutoSize = true;
            this.lAtk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAtk.Location = new System.Drawing.Point(6, 49);
            this.lAtk.Name = "lAtk";
            this.lAtk.Size = new System.Drawing.Size(61, 18);
            this.lAtk.TabIndex = 11;
            this.lAtk.Text = "Attack";
            // 
            // lStr
            // 
            this.lStr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lStr.AutoSize = true;
            this.lStr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStr.Location = new System.Drawing.Point(6, 22);
            this.lStr.Name = "lStr";
            this.lStr.Size = new System.Drawing.Size(78, 18);
            this.lStr.TabIndex = 10;
            this.lStr.Text = "Strength";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l5);
            this.groupBox1.Controls.Add(this.lAtk);
            this.groupBox1.Controls.Add(this.l4);
            this.groupBox1.Controls.Add(this.lAgi);
            this.groupBox1.Controls.Add(this.l3);
            this.groupBox1.Controls.Add(this.lStr);
            this.groupBox1.Controls.Add(this.l2);
            this.groupBox1.Controls.Add(this.lVit);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Controls.Add(this.lHP);
            this.groupBox1.Location = new System.Drawing.Point(12, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 161);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // l5
            // 
            this.l5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(116, 130);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(57, 18);
            this.l5.TabIndex = 20;
            this.l5.Text = "Agility";
            // 
            // l4
            // 
            this.l4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(116, 103);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(62, 18);
            this.l4.TabIndex = 19;
            this.l4.Text = "Vitality";
            // 
            // l3
            // 
            this.l3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(116, 77);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(60, 18);
            this.l3.TabIndex = 18;
            this.l3.Text = "Health";
            // 
            // l2
            // 
            this.l2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(116, 49);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(61, 18);
            this.l2.TabIndex = 17;
            this.l2.Text = "Attack";
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(116, 22);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(78, 18);
            this.l1.TabIndex = 16;
            this.l1.Text = "Strength";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardControls);
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pPlayer;
        private System.Windows.Forms.Label lAgi;
        private System.Windows.Forms.Label lVit;
        private System.Windows.Forms.Label lHP;
        private System.Windows.Forms.Label lAtk;
        private System.Windows.Forms.Label lStr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
    }
}