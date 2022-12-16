using ExamWPF.ViewModel;
using System.Windows;

namespace ExamWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ExamViewModel _viewModel;
        public App()
        {
            _viewModel = new ExamViewModel();
            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }
    }
}
