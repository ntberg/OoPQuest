using System;
using System.Collections.Generic;
using System.Text;

namespace OoPQuest
{
	public class Character
	{
		string _Name;
		int _statHP;
		int _statAttack;
		int _curHP;

		public void Attack(Character source, Character target)
		{
			target.curHP = target.curHP - source.statAttack;
			return;
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
