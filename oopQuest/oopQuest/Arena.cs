using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OoPQuest
{
	public class Arena
	{
		private int _terrainID;
		private string _Name;

		public void envDoDamage(Player player, Enemy enemy, TextBox outputBox, TextBox playerHPBox, TextBox enemyHPBox)
		{
			Random rand = new Random();

			if(this.terrainID == 1)
            {
				outputBox.AppendText("The sandstorm tears into the combatants!" + Environment.NewLine);
				player.curHP -= 2;
				enemy.curHP -= 2;
				playerHPBox.Text = player.curHP.ToString();
				enemyHPBox.Text = enemy.curHP.ToString();
            }
			else if (this.terrainID == 2)
            {
				if (rand.Next(0,2) == 0 )
                {
					outputBox.AppendText("The cold saps your Attack! " + Environment.NewLine);
					player.statAttack--;
				}
				else
                {
					outputBox.AppendText("The cold saps the enemy's Attack! " + Environment.NewLine);
					enemy.statAttack--;
				}

				
			}
			else if (this.terrainID == 3)
			{
				if (rand.Next(0, 2) == 0)
				{
					outputBox.AppendText("The wind is in your favor, granting you a second attack!" + Environment.NewLine);
					player.Attack(player, enemy, outputBox, enemyHPBox);
				}
				else
				{
					outputBox.AppendText("The enemy uses the wind to attack again! " + Environment.NewLine);
					enemy.Attack(enemy, player, outputBox, playerHPBox);
				}


			}

		}

		public Arena(string Name, int terrainID)
        {
			this.Name = Name;
			this.terrainID = terrainID;
        }


		public int terrainID
		{
			get
			{
				return _terrainID;
			}
			set
			{
				_terrainID = value;
			}
		}

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}
	}
}
