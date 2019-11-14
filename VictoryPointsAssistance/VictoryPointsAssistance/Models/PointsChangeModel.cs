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

		public static PointsChangeModel CommandFirstPlayerAdd = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Command };
	}

	public enum PointsType
	{
		Vctory,
		Maelstorm,
		Mission,
		Command
 }
}
