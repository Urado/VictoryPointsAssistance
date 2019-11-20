using System;
using System.Collections.Generic;
using System.Windows.Input;
using VictoryPointsAssistance.Models;
using Xamarin.Forms;

namespace VictoryPointsAssistance.ViewModels
{
	public class VicoryPointsViewModel : BaseViewModel
	{
		public VicoryPointsViewModel()
		{
			Players = new List<Player> { new Player(), new Player() };
			PlusMinusButtonCommand = new Command<PointsChangeModel>(ChangePoints);
		}

		public IReadOnlyList<Player> Players { get; set; }

		public ICommand PlusMinusButtonCommand { get; set; }

		public int FirstPlayerPoints
		{
			get
			{
				return 10 + PointDifferent();
			}
		}
		public int SecondPlayerPoints
		{
			get
			{
				return 10 - PointDifferent();
			}
		}
		private int PointDifferent()
		{
			return Math.Max(0, Math.Min(10, (Math.Abs(Players[0].VictoryPoints - Players[1].VictoryPoints) + 1) / 2)) 
				* Math.Sign(Players[0].VictoryPoints - Players[1].VictoryPoints);
		}

		public PointsChangeModel CommandFirstPlayerAdd { get; } = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Command };
		public PointsChangeModel CommandFirstPlayerRemove { get; } = new PointsChangeModel { Player = 0, ChangePoints = -1, PointsType = PointsType.Command };

		public PointsChangeModel MaelstormFirstPlayerAdd { get; } = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Maelstorm };
		public PointsChangeModel MaelstormFirstPlayerRemove { get; } = new PointsChangeModel { Player = 0, ChangePoints = -1, PointsType = PointsType.Maelstorm };

		public PointsChangeModel EternalFirstPlayerAdd { get; } = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Eternal };
		public PointsChangeModel EternalFirstPlayerRemove { get; } = new PointsChangeModel { Player = 0, ChangePoints = -1, PointsType = PointsType.Eternal };

		public PointsChangeModel CommandSecondPlayerAdd { get; } = new PointsChangeModel { Player = 1, ChangePoints = 1, PointsType = PointsType.Command };
		public PointsChangeModel CommandSecondPlayerRemove { get; } = new PointsChangeModel { Player = 1, ChangePoints = -1, PointsType = PointsType.Command };

		public PointsChangeModel MaelstormSecondPlayerAdd { get; } = new PointsChangeModel { Player = 1, ChangePoints = 1, PointsType = PointsType.Maelstorm };
		public PointsChangeModel MaelstormSecondPlayerRemove { get; } = new PointsChangeModel { Player = 1, ChangePoints = -1, PointsType = PointsType.Maelstorm };

		public PointsChangeModel EternalSecondPlayerAdd { get; } = new PointsChangeModel { Player = 1, ChangePoints = 1, PointsType = PointsType.Eternal };
		public PointsChangeModel EternalSecondPlayerRemove { get; } = new PointsChangeModel { Player = 1, ChangePoints = -1, PointsType = PointsType.Eternal };

		public string MaelstormFirstPlayer { get { return Players[0].MaelstormVictoryPoints.ToString(); } }

		public string MaelstormSecondPlayer { get { return Players[1].MaelstormVictoryPoints.ToString(); } }

		public string EternalFirstPlayer { get { return Players[0].EternalVictoryPoints.ToString(); } }

		public string EternalSecondPlayer { get { return Players[1].EternalVictoryPoints.ToString(); } }

		public string VictoryFirstPlayer { get { return Players[0].VictoryPoints.ToString(); } }

		public string VictorySecondPlayer { get { return Players[1].VictoryPoints.ToString(); } }

		public string CommandFirstPlayer { get { return Players[0].CommandPoints.ToString(); } }

		public string CommandSecondPlayer { get { return Players[1].CommandPoints.ToString(); } }

		public void ChangePoints(PointsChangeModel pointsChangeModel)
		{
			switch (pointsChangeModel.PointsType)
			{
				case PointsType.Command:
					Players[pointsChangeModel.Player].CommandPoints += pointsChangeModel.ChangePoints;
					OnCommandChanged();
					break;
				case PointsType.Maelstorm:
					Players[pointsChangeModel.Player].MaelstormVictoryPoints += pointsChangeModel.ChangePoints;
					OnMalestormChanged();
					break;
				case PointsType.Eternal:
					Players[pointsChangeModel.Player].EternalVictoryPoints += pointsChangeModel.ChangePoints;
					OnEternalChanged();
					break;
				default:
					break;
			}

		}

		private void OnMalestormChanged()
		{
			OnPropertyChanged(nameof(MaelstormFirstPlayer));
			OnPropertyChanged(nameof(MaelstormSecondPlayer));

			OnVictoryChanged();
		}

		private void OnEternalChanged()
		{
			OnPropertyChanged(nameof(EternalFirstPlayer));
			OnPropertyChanged(nameof(EternalSecondPlayer));

			OnVictoryChanged();
		}

		private void OnCommandChanged()
		{
			OnPropertyChanged(nameof(CommandFirstPlayer));
			OnPropertyChanged(nameof(CommandSecondPlayer));

			OnVictoryChanged();
		}


		private void OnVictoryChanged()
		{
			OnPropertyChanged(nameof(VictoryFirstPlayer));
			OnPropertyChanged(nameof(VictorySecondPlayer));
			OnPropertyChanged(nameof(FirstPlayerPoints));
			OnPropertyChanged(nameof(SecondPlayerPoints));
		}
	}
}
