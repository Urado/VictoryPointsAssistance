using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryPointsAssistance
{
	public class Player
	{
		private int commandPoints;
		private int maelstormVictoryPoints;
		private int eternalVictoryPoints;

		public int VictoryPoints
		{
			get
			{
				return MaelstormVictoryPoints + EternalVictoryPoints;
			}
		}

		public int CommandPoints
		{
			get => commandPoints;
			set => commandPoints = Math.Max(value, 0);
		}

		public int MaelstormVictoryPoints
		{
			get => maelstormVictoryPoints;
			set => maelstormVictoryPoints = Math.Max(value, 0);
		}

		public int EternalVictoryPoints
		{
			get => eternalVictoryPoints;
			set => eternalVictoryPoints = Math.Max(value, 0);
		}
	}
}
