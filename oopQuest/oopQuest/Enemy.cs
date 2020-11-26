using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OoPQuest
{
	public class Enemy : Character
	{
		string _deathText;

		public void speakDeath(TextBox outputBox)
		{
			outputBox.AppendText(this.Name + ": " + this.deathText + Environment.NewLine);
		}

		public Enemy(string Name, int statHP, int statAttack, string deathText)
		{
			this.Name = Name;
			this.statHP = statHP;
			this.curHP = statHP; //init current health
			this.statAttack = statAttack;
			this.deathText = deathText;
		}

		public string deathText
		{
			get
			{
				return _deathText;
			}
			set
			{
				_deathText = value;
			}
		}
	}
}
