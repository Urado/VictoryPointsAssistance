using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoryPointsAssistance.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VictoryPointsAssistance.Views.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
			var startPageViewModel = new StartPageViewModel() { Navigation = this.Navigation }; ;
			InitializeComponent();
			BindingContext = startPageViewModel;
		}
	}
}