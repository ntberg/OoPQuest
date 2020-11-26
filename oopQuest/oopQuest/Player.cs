using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OoPQuest
{
	public class Player : Character
	{
		private int _statMP;
		int _curMP;
		Profession _Profession;
		
		public override void Attack(Character source, Character target, TextBox outputBox, TextBox hpBox)
        {
			if (this.curHP > 0)
			{
				target.curHP = target.curHP - source.statAttack;
				outputBox.AppendText(source.Name + " attacked " + target.Name + Environment.NewLine);
				hpBox.Text = target.curHP.ToString();
				return;
			}
			else
            {
				outputBox.AppendText("You are dead and cannot do that" + Environment.NewLine);
            }
		}

		public void useItem(TextBox outputBox, Enemy enemy)
		{
			if (this.Profession.Name == "Paladin")
            {
				outputBox.AppendText("You used a potion to increase your max HP by ten!" + Environment.NewLine);
				this.statHP += 10;
				

			}
			if (this.Profession.Name == "Priest")
			{
				outputBox.AppendText("You used an elixer to restore your max MP!" + Environment.NewLine);
				this.statMP += 25;
			

			}
			if (this.Profession.Name == "Wanderer")
			{
				outputBox.AppendText("You slathered oil on your sword to increase its damage!" + Environment.NewLine);
				this.statAttack += 5;
				

			}
			if (this.Profession.Name == "Bard")
			{
				outputBox.AppendText("You played a song that confused the enemy, dropping their Attack!" + Environment.NewLine);
				enemy.statAttack -= 5;
				if (enemy.statAttack < 1) //negative values heal the player, which we don't want
                {
					enemy.statAttack = 1;
                }
				


			}
		}

		public void useMagic(TextBox outputBox, TextBox playerHPBox, TextBox playerMPBox)
		{
			if (this.curHP > 0)
			{
				if (this.curMP >= 5)
				{
					this.curHP = this.curHP + 25;
					this.curMP = this.curMP - 5;
					if (this.curHP > this.statHP)
					{
						this.curHP = this.statHP;
					}
					outputBox.AppendText(this.Name + " used magic to heal " + Environment.NewLine);
					playerHPBox.Text = this.curHP.ToString();
					playerMPBox.Text = this.curMP.ToString();

				}
				else
				{
					outputBox.AppendText(this.Name + " cringed due to lack of MP " + Environment.NewLine);
					this.curHP = this.curHP - 5;
					playerHPBox.Text = this.curHP.ToString();
				}
			}
			else
            {
				outputBox.AppendText("You are dead and cannot do that" + Environment.NewLine);
			}
		}

		public void Defend(TextBox outputBox)
        {
			outputBox.AppendText("You defend against the enemy's attack and take no damage!" + Environment.NewLine);
		}

		public void updateStats(Profession profession, TextBox playerNameBox, TextBox playerHPBox, TextBox playerMPBox)
        {
			this.Profession = profession;
			this.Name = profession.Name;
			this.statHP = profession.baseHP;
			this.statMP = profession.baseMP;
			this.statAttack = profession.baseAttack;

			this.curHP = this.statHP;
			this.curMP = this.statMP;

			playerNameBox.Text = this.Name;
			playerHPBox.Text = this.curHP.ToString();
			playerMPBox.Text = this.curMP.ToString();

        }

		public int statMP
		{
			get
			{
				return _statMP;
			}
			set
			{
				_statMP = value;
			}
		}


		public Profession Profession
		{
			get
			{
				return _Profession;
			}
			set
			{
				_Profession = value;
			}
		}
		public int curMP
        {
			get
            {
				return _curMP;
            }
			set
            {
				_curMP = value;
            }
        }
	}
}
