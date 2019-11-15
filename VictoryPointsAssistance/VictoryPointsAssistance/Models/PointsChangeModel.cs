using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryPointsAssistance.Models
{
	public class PointsChangeModel
	{
		public int Player { get; set; }

		public int ChangePoints { get; set; }

		public PointsType PointsType { get; set; }
	}

	public enum PointsType
	{
		Vctory,
		Maelstorm,
		Mission,
		Command
	}
}
