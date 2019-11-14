using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
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
			PlusMinusButtonCommand = new Command<PointsChangeModel>((PointsChangeModel p) => ChangeComand(p.Player, p.ChangePoints));
		}

		public IReadOnlyList<Player> Players { get; set; }

		public ICommand PlusMinusButtonCommand { get; set; }

		public PointsChangeModel CommandFirstPlayerAdd { get; set; } = PointsChangeModel.CommandFirstPlayerAdd;

		//public ICommand<(int, int)> TestPulsMinusCommand { get; set; }

		public string MaelstormFirstPlayer { get { return Players[0].MaelstormVictoryPoints.ToString(); } }

		public string MaelstormSecondPlayer { get { return Players[1].MaelstormVictoryPoints.ToString(); } }

		public string MissionFirstPlayer { get { return Players[0].MissionVictoryPoints.ToString(); } }

		public string MissionSecondPlayer { get { return Players[1].MissionVictoryPoints.ToString(); } }

		public string VictoryFirstPlayer { get { return Players[0].VictoryPoints.ToString(); } }

		public string VictorySecondPlayer { get { return Players[1].VictoryPoints.ToString(); } }

		public string CommandFirstPlayer { get { return Players[0].CommandPoints.ToString(); } }

		public string CommandSecondPlayer { get { return Players[1].CommandPoints.ToString(); } }

		public void ChangeMaelstorm(int player, int add)
		{
			Players[player].MaelstormVictoryPoints += add;
			OnMalestormChanged();
		}

		public void ChangeMission(int player, int add)
		{
			Players[player].MissionVictoryPoints += add;
			OnMissionChanged();
		}

		public void ChangeComand(int player, int add)
		{
			Players[player].CommandPoints += add;
			OnCommandChanged();
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
