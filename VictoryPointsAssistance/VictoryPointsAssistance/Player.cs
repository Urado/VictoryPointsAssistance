using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryPointsAssistance
{
	public class Player
	{
		private int commandPoints;
		private int maelstormVictoryPoints;
		private int missionVictoryPoints;

		public int VictoryPoints
		{
			get
			{
				return MaelstormVictoryPoints + MissionVictoryPoints;
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

		public int MissionVictoryPoints
		{
			get => missionVictoryPoints;
			set => missionVictoryPoints = Math.Max(value, 0);
		}
	}
}
