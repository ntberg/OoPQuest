using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OoPQuest
{
	public class Character
	{
		string _Name;
		int _statHP;
		int _statAttack;
		int _curHP;

		public virtual void Attack(Character source, Character target, TextBox outputBox, TextBox hpBox)
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
				outputBox.AppendText(source.Name + " tried to attack but " + target.Name + " was already dead." + Environment.NewLine);
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

		public int statHP
		{
			get
			{
				return _statHP;
			}
			set
			{
				_statHP = value;
			}
		}

		public int statAttack
		{
			get
			{
				return _statAttack;
			}
			set
			{
				_statAttack = value;
			}
		}
		public int curHP
		{
			get
			{
				return _curHP;
			}
			set
			{
				_curHP = value;
			}
		}
	}
}
