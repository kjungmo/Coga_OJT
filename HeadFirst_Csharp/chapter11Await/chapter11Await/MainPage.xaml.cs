using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// 빈 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234238에 나와 있습니다.

namespace chapter11Await
{
    /// <summary>
    /// 자체에서 사용하거나 프레임 내에서 탐색할 수 있는 빈 페이지입니다.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        DispatcherTimer timer = new DispatcherTimer();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Start();
            CheckHappiness();
        }
        int i = 0;
        private async void CheckHappiness()
        {
            MessageDialog dialog = new MessageDialog("Are you happy?");
            dialog.Commands.Add(new UICommand("Happy as a clam!"));
            dialog.Commands.Add(new UICommand("Sad as a donkey."));
            dialog.DefaultCommandIndex = 1;
            UICommand result = await dialog.ShowAsync() as UICommand;
            if (result != null && result.Label == "Happy as a clam!")
            {
                response.Text = "The user is happy";
            }
            else
                response.Text = "The user is sad";

            timer.Stop();
        }

        private void timer_Tick(object sender, object e)
        {
            ticker.Text = "Tick #" + i++;
        }
    }
}
