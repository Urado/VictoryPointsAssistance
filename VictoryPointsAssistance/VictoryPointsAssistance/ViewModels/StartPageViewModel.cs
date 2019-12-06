using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VictoryPointsAssistance.Views.Pages;
using Xamarin.Forms;

namespace VictoryPointsAssistance.ViewModels
{
	class StartPageViewModel : BaseViewModel
	{
		public StartPageViewModel()
		{
			StartButtonCommand = new Command(() =>
			{
				Navigation.PushModalAsync(new MainPage());
			});
		}
		public ICommand StartButtonCommand { get; set; }
	}
}
