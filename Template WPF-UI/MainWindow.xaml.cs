using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui;
using Wpf.Ui.Appearance;

namespace Template_WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initilize WPF-UI
            Accent.ApplySystemAccent();
            Wpf.Ui.Appearance.Background.Apply(this, Wpf.Ui.Appearance.BackgroundType.Mica);
        }

        private void Welcome_Click_Me_Click(object sender, RoutedEventArgs e)
        {
            snakeBarNot.Show("Button Clicked!", "This is what that button does! You can call this for errors , like a wrong login too!", Wpf.Ui.Common.SymbolRegular.CheckboxChecked24, Wpf.Ui.Common.ControlAppearance.Success);
        }

        private void Submit_Welcome_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTxt.Text == "example@example.com")
            {
                if (PasswordTxt.Password == "examplePass")
                {
                    snakeBarNot.Show("Correct!", "You ented the login info correctly!", Wpf.Ui.Common.SymbolRegular.CheckboxChecked24, Wpf.Ui.Common.ControlAppearance.Success);
                }
                else
                {
                    snakeBarNot.Show("Incorrect!", "You ented the Login Info Incorrectly!", Wpf.Ui.Common.SymbolRegular.ShieldError24, Wpf.Ui.Common.ControlAppearance.Danger);
                }
            }
            else
            {
                snakeBarNot.Show("Incorrect!", "You ented the Login Info Incorrectly!", Wpf.Ui.Common.SymbolRegular.ShieldError24, Wpf.Ui.Common.ControlAppearance.Danger);
            }
        }
    }
}