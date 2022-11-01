using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using visual_programming_lab5.ViewModels;
using Avalonia.Interactivity;

namespace visual_programming_lab5.Views
{
    public partial class RegexWindow : Window
    {
        public RegexWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("OKButton").Click += async delegate
            {
                var contex = this.DataContext as MainWindowViewModel;
                contex.PatternNew = contex.PatternOld;
                Close();
            };

            this.FindControl<Button>("CancelButton").Click += async delegate
            {
                var contex = this.DataContext as MainWindowViewModel;
                contex.PatternOld = contex.PatternNew;
                Close();
            };
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
