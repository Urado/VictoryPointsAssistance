using System.ComponentModel;
using VictoryPointsAssistance.ViewModels;
using Xamarin.Forms;

namespace VictoryPointsAssistance.Views.Pages
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
	}
}
