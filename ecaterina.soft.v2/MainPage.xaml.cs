using Coding4Fun.Toolkit.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ecaterina.soft.v2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private ToastPrompt toast = new ToastPrompt();

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Toast("Language", "Add to choose language");
        }

        private void Button_Tapped2(object sender, TappedRoutedEventArgs e)
        {
            Toast("Button", "Add to ok button");
        }

        private void Button_Tapped3(object sender, TappedRoutedEventArgs e)
        {
            Toast("Button", "Add to delete");
            //DisplayPackageImageToastWithStringManipulation(ToastTemplateType.ToastImageAndText01, "Add to delete", "Button");
        }

        private void Toast(string title, string message)
        {
            var gray = new SolidColorBrush(Colors.Black);
            var orange = new SolidColorBrush(Colors.DarkSalmon);
            toast = new ToastPrompt
            {
                Background = gray,
                Foreground = orange,
                Title = title,
                Message = message,
                FontSize = 30,
                TextWrapping = TextWrapping.Wrap,
                TextOrientation = Orientation.Vertical
            };
            toast.Show();
        }


    }
}
