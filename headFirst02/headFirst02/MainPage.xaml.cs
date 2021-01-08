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

// 빈 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234238에 나와 있습니다.

namespace headFirst02
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - ( 42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            int count = 0;
            count++;
            count--;

            string result = "hello";
            result += " again " + result;
            output.Text = result;
            result = "the value is: " + count;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
        }
    }
}
