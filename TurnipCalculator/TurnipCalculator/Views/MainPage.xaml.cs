using System;

using TurnipCalculator.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TurnipCalculator.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
