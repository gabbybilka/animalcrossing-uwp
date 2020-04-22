using System;

using TurnipCalculator.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TurnipCalculator.Views
{
    // TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
        }
    }
}
