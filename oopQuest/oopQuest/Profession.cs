using System;
using System.Collections.Generic;
using System.Text;

namespace OoPQuest
{
	public class Profession
	{
		private string _Name;
		private int _baseHP;
		private int _baseMP;
		private int _baseAttack;



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

		public int baseHP
		{
			get
			{
				return _baseHP;
			}
			set
			{
				_baseHP = value;
			}
		}

		public int baseMP
		{
			get
			{
				return _baseMP;
			}
			set
			{
				_baseMP = value;
			}
		}

		public int baseAttack
		{
			get
			{
				return _baseAttack;
			}
			set
			{
				_baseAttack = value;
			}
		}

		public Profession(string pName, int pbaseHP, int pbaseMP, int pbaseAttack)
		{
			Name = pName;
			baseHP = pbaseHP;
			baseMP = pbaseMP;
			baseAttack = pbaseAttack;
		}

	}
}
