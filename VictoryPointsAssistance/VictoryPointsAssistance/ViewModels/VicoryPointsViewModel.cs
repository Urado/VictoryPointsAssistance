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

		public PointsChangeModel CommandFirstPlayerAdd { get; } = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Command };
		public PointsChangeModel CommandFirstPlayerRemove { get; } = new PointsChangeModel { Player = 0, ChangePoints = -1, PointsType = PointsType.Command };

		public PointsChangeModel MaelstormFirstPlayerAdd { get; } = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Maelstorm };
		public PointsChangeModel MaelstormFirstPlayerRemove { get; } = new PointsChangeModel { Player = 0, ChangePoints = -1, PointsType = PointsType.Maelstorm };

		public PointsChangeModel MissionFirstPlayerAdd { get; } = new PointsChangeModel { Player = 0, ChangePoints = 1, PointsType = PointsType.Mission };
		public PointsChangeModel MissionFirstPlayerRemove { get; } = new PointsChangeModel { Player = 0, ChangePoints = -1, PointsType = PointsType.Mission };

		public PointsChangeModel CommandSecondPlayerAdd { get; } = new PointsChangeModel { Player = 1, ChangePoints = 1, PointsType = PointsType.Command };
		public PointsChangeModel CommandSecondPlayerRemove { get; } = new PointsChangeModel { Player = 1, ChangePoints = -1, PointsType = PointsType.Command };

		public PointsChangeModel MaelstormSecondPlayerAdd { get; } = new PointsChangeModel { Player = 1, ChangePoints = 1, PointsType = PointsType.Maelstorm };
		public PointsChangeModel MaelstormSecondPlayerRemove { get; } = new PointsChangeModel { Player = 1, ChangePoints = -1, PointsType = PointsType.Maelstorm };

		public PointsChangeModel MissionSecondPlayerAdd { get; } = new PointsChangeModel { Player = 1, ChangePoints = 1, PointsType = PointsType.Mission };
		public PointsChangeModel MissionSecondPlayerRemove { get; } = new PointsChangeModel { Player = 1, ChangePoints = -1, PointsType = PointsType.Mission };

		public string MaelstormFirstPlayer { get { return Players[0].MaelstormVictoryPoints.ToString(); } }

		public string MaelstormSecondPlayer { get { return Players[1].MaelstormVictoryPoints.ToString(); } }

		public string MissionFirstPlayer { get { return Players[0].MissionVictoryPoints.ToString(); } }

		public string MissionSecondPlayer { get { return Players[1].MissionVictoryPoints.ToString(); } }

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
				case PointsType.Mission:
					Players[pointsChangeModel.Player].MissionVictoryPoints += pointsChangeModel.ChangePoints;
					OnMissionChanged();
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

		private void OnMissionChanged()
		{
			OnPropertyChanged(nameof(MissionFirstPlayer));
			OnPropertyChanged(nameof(MissionSecondPlayer));

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
		}
	}
}
