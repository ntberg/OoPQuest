namespace OoPQuest
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.magicButton = new System.Windows.Forms.Button();
            this.fleeButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.playerHPBox = new System.Windows.Forms.TextBox();
            this.playerMPLabel = new System.Windows.Forms.Label();
            this.playerMPBox = new System.Windows.Forms.TextBox();
            this.playerPotionLabel = new System.Windows.Forms.Label();
            this.playerPotionBox = new System.Windows.Forms.TextBox();
            this.playerElixirLabel = new System.Windows.Forms.Label();
            this.playerElixirBox = new System.Windows.Forms.TextBox();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.enemyNameBox = new System.Windows.Forms.TextBox();
            this.enemyHPLabel = new System.Windows.Forms.Label();
            this.enemyHPBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(220, 24);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(821, 476);
            this.outputBox.TabIndex = 0;
            this.outputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(428, 517);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(122, 57);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // itemButton
            // 
            this.itemButton.Location = new System.Drawing.Point(703, 517);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(122, 57);
            this.itemButton.TabIndex = 1;
            this.itemButton.Text = "Item";
            this.itemButton.UseVisualStyleBackColor = true;
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(428, 589);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(122, 57);
            this.magicButton.TabIndex = 1;
            this.magicButton.Text = "Magic";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // fleeButton
            // 
            this.fleeButton.Location = new System.Drawing.Point(703, 589);
            this.fleeButton.Name = "fleeButton";
            this.fleeButton.Size = new System.Drawing.Size(122, 57);
            this.fleeButton.TabIndex = 1;
            this.fleeButton.Text = "Flee";
            this.fleeButton.UseVisualStyleBackColor = true;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(12, 76);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(42, 15);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Player:";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(72, 73);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.ReadOnly = true;
            this.playerNameBox.Size = new System.Drawing.Size(100, 23);
            this.playerNameBox.TabIndex = 3;
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.AutoSize = true;
            this.playerHPLabel.Location = new System.Drawing.Point(12, 134);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(26, 15);
            this.playerHPLabel.TabIndex = 2;
            this.playerHPLabel.Text = "HP:";
            // 
            // playerHPBox
            // 
            this.playerHPBox.Location = new System.Drawing.Point(72, 131);
            this.playerHPBox.Name = "playerHPBox";
            this.playerHPBox.ReadOnly = true;
            this.playerHPBox.Size = new System.Drawing.Size(100, 23);
            this.playerHPBox.TabIndex = 3;
            // 
            // playerMPLabel
            // 
            this.playerMPLabel.AutoSize = true;
            this.playerMPLabel.Location = new System.Drawing.Point(12, 179);
            this.playerMPLabel.Name = "playerMPLabel";
            this.playerMPLabel.Size = new System.Drawing.Size(43, 15);
            this.playerMPLabel.TabIndex = 2;
            this.playerMPLabel.Text = "Magic:";
            // 
            // playerMPBox
            // 
            this.playerMPBox.Location = new System.Drawing.Point(72, 176);
            this.playerMPBox.Name = "playerMPBox";
            this.playerMPBox.ReadOnly = true;
            this.playerMPBox.Size = new System.Drawing.Size(100, 23);
            this.playerMPBox.TabIndex = 3;
            // 
            // playerPotionLabel
            // 
            this.playerPotionLabel.AutoSize = true;
            this.playerPotionLabel.Location = new System.Drawing.Point(12, 244);
            this.playerPotionLabel.Name = "playerPotionLabel";
            this.playerPotionLabel.Size = new System.Drawing.Size(50, 15);
            this.playerPotionLabel.TabIndex = 2;
            this.playerPotionLabel.Text = "Potions:";
            // 
            // playerPotionBox
            // 
            this.playerPotionBox.Location = new System.Drawing.Point(72, 241);
            this.playerPotionBox.Name = "playerPotionBox";
            this.playerPotionBox.ReadOnly = true;
            this.playerPotionBox.Size = new System.Drawing.Size(100, 23);
            this.playerPotionBox.TabIndex = 3;
            // 
            // playerElixirLabel
            // 
            this.playerElixirLabel.AutoSize = true;
            this.playerElixirLabel.Location = new System.Drawing.Point(12, 291);
            this.playerElixirLabel.Name = "playerElixirLabel";
            this.playerElixirLabel.Size = new System.Drawing.Size(40, 15);
            this.playerElixirLabel.TabIndex = 2;
            this.playerElixirLabel.Text = "Elixirs:";
            // 
            // playerElixirBox
            // 
            this.playerElixirBox.Location = new System.Drawing.Point(72, 288);
            this.playerElixirBox.Name = "playerElixirBox";
            this.playerElixirBox.ReadOnly = true;
            this.playerElixirBox.Size = new System.Drawing.Size(100, 23);
            this.playerElixirBox.TabIndex = 3;
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.AutoSize = true;
            this.enemyNameLabel.Location = new System.Drawing.Point(1046, 79);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(46, 15);
            this.enemyNameLabel.TabIndex = 2;
            this.enemyNameLabel.Text = "Enemy:";
            // 
            // enemyNameBox
            // 
            this.enemyNameBox.Location = new System.Drawing.Point(1106, 76);
            this.enemyNameBox.Name = "enemyNameBox";
            this.enemyNameBox.ReadOnly = true;
            this.enemyNameBox.Size = new System.Drawing.Size(100, 23);
            this.enemyNameBox.TabIndex = 3;
            // 
            // enemyHPLabel
            // 
            this.enemyHPLabel.AutoSize = true;
            this.enemyHPLabel.Location = new System.Drawing.Point(1046, 134);
            this.enemyHPLabel.Name = "enemyHPLabel";
            this.enemyHPLabel.Size = new System.Drawing.Size(26, 15);
            this.enemyHPLabel.TabIndex = 2;
            this.enemyHPLabel.Text = "HP:";
            this.enemyHPLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // enemyHPBox
            // 
            this.enemyHPBox.Location = new System.Drawing.Point(1106, 131);
            this.enemyHPBox.Name = "enemyHPBox";
            this.enemyHPBox.ReadOnly = true;
            this.enemyHPBox.Size = new System.Drawing.Size(100, 23);
            this.enemyHPBox.TabIndex = 3;
            this.enemyHPBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(50, 350);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(122, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 658);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.enemyHPBox);
            this.Controls.Add(this.enemyHPLabel);
            this.Controls.Add(this.enemyNameBox);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.playerElixirBox);
            this.Controls.Add(this.playerElixirLabel);
            this.Controls.Add(this.playerPotionBox);
            this.Controls.Add(this.playerPotionLabel);
            this.Controls.Add(this.playerMPBox);
            this.Controls.Add(this.playerMPLabel);
            this.Controls.Add(this.playerHPBox);
            this.Controls.Add(this.playerHPLabel);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.fleeButton);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Button fleeButton;
        private System.Windows.Forms.Label playerLabel;
        public System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Label playerHPLabel;
        public System.Windows.Forms.TextBox playerHPBox;
        private System.Windows.Forms.Label playerMPLabel;
        public System.Windows.Forms.TextBox playerMPBox;
        private System.Windows.Forms.Label playerPotionLabel;
        public System.Windows.Forms.TextBox playerPotionBox;
        private System.Windows.Forms.Label playerElixirLabel;
        public System.Windows.Forms.TextBox playerElixirBox;
        private System.Windows.Forms.Label enemyNameLabel;
        public System.Windows.Forms.TextBox enemyNameBox;
        private System.Windows.Forms.Label enemyHPLabel;
        public System.Windows.Forms.TextBox enemyHPBox;
        private System.Windows.Forms.Button startButton;
    }
}

