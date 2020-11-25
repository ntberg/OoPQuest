using System;
using System.Collections.Generic;
using System.Text;

namespace OoPQuest
{
	public class Encounter
	{
		Player _Player;
		Enemy _Enemy;
		Arena _Arena;

		public void runEnemyTurn(Player player, Enemy enemy)
		{
			enemy.Attack(enemy, player);
		
		}
		public int checkHP(Player player, Enemy enemy)
		{
			if (player.curHP<=0)
            {
				return 1;
            }
			else if (enemy.curHP<=0)
            {
				return 2;
            }
			else
            {
				return 0;
            }

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
