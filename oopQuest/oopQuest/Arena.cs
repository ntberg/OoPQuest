using System;
using System.Collections.Generic;
using System.Text;

namespace OoPQuest
{
	public class Arena
	{
		private int _terrainID;
		private string _Name;

		public void envDoDamage(Player player, Enemy enemy)
		{
			throw new NotImplementedException();
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
