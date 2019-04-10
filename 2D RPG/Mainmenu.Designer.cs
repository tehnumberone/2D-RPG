namespace _2D_RPG
{
    partial class Mainmenu
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
            this.Title = new System.Windows.Forms.Label();
            this.bgameLoad = new System.Windows.Forms.Button();
            this.bgameNew = new System.Windows.Forms.Button();
            this.bgameSettings = new System.Windows.Forms.Button();
            this.bgameCredits = new System.Windows.Forms.Button();
            this.bgameContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(439, 43);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(391, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "Big gay 2D RPG";
            // 
            // bgameLoad
            // 
            this.bgameLoad.BackColor = System.Drawing.Color.Maroon;
            this.bgameLoad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgameLoad.ForeColor = System.Drawing.Color.White;
            this.bgameLoad.Location = new System.Drawing.Point(396, 350);
            this.bgameLoad.Name = "bgameLoad";
            this.bgameLoad.Size = new System.Drawing.Size(218, 51);
            this.bgameLoad.TabIndex = 1;
            this.bgameLoad.Text = "Load game";
            this.bgameLoad.UseVisualStyleBackColor = false;
            this.bgameLoad.Click += new System.EventHandler(this.bgameLoad_Click);
            // 
            // bgameNew
            // 
            this.bgameNew.BackColor = System.Drawing.Color.Maroon;
            this.bgameNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgameNew.ForeColor = System.Drawing.Color.White;
            this.bgameNew.Location = new System.Drawing.Point(396, 280);
            this.bgameNew.Name = "bgameNew";
            this.bgameNew.Size = new System.Drawing.Size(218, 51);
            this.bgameNew.TabIndex = 2;
            this.bgameNew.Text = "New game";
            this.bgameNew.UseVisualStyleBackColor = false;
            this.bgameNew.Click += new System.EventHandler(this.bgameNew_Click);
            // 
            // bgameSettings
            // 
            this.bgameSettings.BackColor = System.Drawing.Color.Maroon;
            this.bgameSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgameSettings.ForeColor = System.Drawing.Color.White;
            this.bgameSettings.Location = new System.Drawing.Point(654, 209);
            this.bgameSettings.Name = "bgameSettings";
            this.bgameSettings.Size = new System.Drawing.Size(218, 51);
            this.bgameSettings.TabIndex = 3;
            this.bgameSettings.Text = "Settings";
            this.bgameSettings.UseVisualStyleBackColor = false;
            this.bgameSettings.Click += new System.EventHandler(this.bgameSettings_Click);
            // 
            // bgameCredits
            // 
            this.bgameCredits.BackColor = System.Drawing.Color.Maroon;
            this.bgameCredits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgameCredits.ForeColor = System.Drawing.Color.White;
            this.bgameCredits.Location = new System.Drawing.Point(654, 280);
            this.bgameCredits.Name = "bgameCredits";
            this.bgameCredits.Size = new System.Drawing.Size(218, 51);
            this.bgameCredits.TabIndex = 4;
            this.bgameCredits.Text = "Credits";
            this.bgameCredits.UseVisualStyleBackColor = false;
            this.bgameCredits.Click += new System.EventHandler(this.bgameCredits_Click);
            // 
            // bgameContinue
            // 
            this.bgameContinue.BackColor = System.Drawing.Color.Maroon;
            this.bgameContinue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgameContinue.ForeColor = System.Drawing.Color.White;
            this.bgameContinue.Location = new System.Drawing.Point(396, 210);
            this.bgameContinue.Name = "bgameContinue";
            this.bgameContinue.Size = new System.Drawing.Size(218, 51);
            this.bgameContinue.TabIndex = 5;
            this.bgameContinue.Text = "Continue";
            this.bgameContinue.UseVisualStyleBackColor = false;
            this.bgameContinue.Click += new System.EventHandler(this.bgameContinue_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.bgameContinue);
            this.Controls.Add(this.bgameCredits);
            this.Controls.Add(this.bgameSettings);
            this.Controls.Add(this.bgameNew);
            this.Controls.Add(this.bgameLoad);
            this.Controls.Add(this.Title);
            this.Name = "Mainmenu";
            this.Text = "2D RPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button bgameLoad;
        private System.Windows.Forms.Button bgameNew;
        private System.Windows.Forms.Button bgameSettings;
        private System.Windows.Forms.Button bgameCredits;
        private System.Windows.Forms.Button bgameContinue;
    }
}

