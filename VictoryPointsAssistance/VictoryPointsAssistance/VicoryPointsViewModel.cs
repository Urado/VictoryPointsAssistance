using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VictoryPointsAssistance
{
	public class VicoryPointsViewModel : INotifyPropertyChanged
	{
		public VicoryPointsViewModel()
		{
			Players = new List<Player> { new Player(), new Player() };
		}

		public IReadOnlyList<Player> Players { get; set; }

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
			OnPropertyChanged("MaelstormFirstPlayer");
			OnPropertyChanged("MaelstormSecondPlayer");

			OnVictoryChanged();
		}

		private void OnMissionChanged()
		{
			OnPropertyChanged("MissionFirstPlayer");
			OnPropertyChanged("MissionSecondPlayer");

			OnVictoryChanged();
		}

		private void OnCommandChanged()
		{
			OnPropertyChanged("CommandFirstPlayer");
			OnPropertyChanged("CommandSecondPlayer");

			OnVictoryChanged();
		}


		private void OnVictoryChanged()
		{
			OnPropertyChanged("VictoryFirstPlayer");
			OnPropertyChanged("VictorySecondPlayer");
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
