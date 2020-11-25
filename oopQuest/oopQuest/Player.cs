using System;
using System.Collections.Generic;
using System.Text;

namespace OoPQuest
{
	public class Player : Character
	{
		private int _statMP;
		int _Level;
		int _XP;
		Profession _Profession;
		public static Player instance;

		public void useItem(Item item)
		{
			throw new NotImplementedException();
		}

		public void useMagic()
		{
			throw new NotImplementedException();
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

		public int Level
		{
			get
			{
				return Level;
			}
			set
			{
				_Level = value;
			}
		}

		public int XP
		{
			get
			{
				return XP;
			}
			set
			{
				XP = value;
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
	}
}
