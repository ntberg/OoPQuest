using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OoPQuest
{
	public class Encounter
	{
		Player _Player;
		Enemy _Enemy;
		Arena _Arena;

		public void checkHP(TextBox outputBox)
		{
			if (this.Player.curHP<=0)
            {
				outputBox.AppendText("You died..." + Environment.NewLine);
				outputBox.AppendText("Press Start to try a different encounter" + Environment.NewLine);
			}
			else if (this.Enemy.curHP<=0)
            {
				outputBox.AppendText("The enemy died!" + Environment.NewLine);
				this.Enemy.speakDeath(outputBox);
				outputBox.AppendText("Press Start to begin your next encounter!" + Environment.NewLine);

			}
			

		}




		public void startEncounter (Player player, Enemy enemy, Arena arena, TextBox outputBox, TextBox enemyNameBox, TextBox enemyHPBox)
        {
			this.Player = player;
			this.Enemy = enemy;
			this.Arena = arena;

			//reset player hp/mp
			this.Player.curHP = this.Player.statHP;
			this.Player.curMP = this.Player.statMP;

			enemyNameBox.Text = this.Enemy.Name;
			enemyHPBox.Text = this.Enemy.curHP.ToString();

			outputBox.AppendText("Encounter started against " + this.Enemy.Name + " in arena " + this.Arena.Name + Environment.NewLine);
			outputBox.AppendText("The first turn is yours." + Environment.NewLine);
		}

		
		

		public Player Player
		{
			get
			{
				return _Player;
			}
			set
			{
				_Player = value;
			}
		}

		public Enemy Enemy
		{
			get
			{
				return _Enemy;
			}
			set
			{
				_Enemy = value;
			}
		}

		public Arena Arena
		{
			get
			{
				return _Arena;
			}
			set
			{
				_Arena = value;
			}
		}
	}
}
