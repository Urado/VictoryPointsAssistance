using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VictoryPointsAssistance
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{

		public VicoryPointsViewModel vicoryPointsViewModel = new VicoryPointsViewModel();

		public MainPage()
		{
			vicoryPointsViewModel = new VicoryPointsViewModel();
			InitializeComponent();
			BindingContext = vicoryPointsViewModel;
		}

		private void MaelstormPlusFirstPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMaelstorm(0, 1);
		}

		private void MaelstormPlusSecondPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMaelstorm(1, 1);
		}

		private void MissionPlusFirstPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMission(0, 1);
		}

		private void MissionPlusSecondPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMission(1, 1);
		}
		private void CommandPlusFirstPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeComand(0, 1);
		}

		private void CommandPlusSecondPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeComand(1, 1);
		}


		private void MaelstormMinusFirstPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMaelstorm(0, -1);
		}

		private void MaelstormMinusSecondPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMaelstorm(1, -1);
		}

		private void MissionMinusFirstPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMission(0, -1);
		}

		private void MissionMinusSecondPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeMission(1, -1);
		}
		private void CommandMinusFirstPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeComand(0, -1);
		}

		private void CommandMinusSecondPlayerClicker(object sender, EventArgs e)
		{
			vicoryPointsViewModel.ChangeComand(1, -1);
		}
	}
}
