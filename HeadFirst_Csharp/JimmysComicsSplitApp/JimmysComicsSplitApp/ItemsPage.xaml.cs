using JimmysComicsSplitApp.Common;
using JimmysComicsSplitApp.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 항목 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234233에 나와 있습니다.

namespace JimmysComicsSplitApp
{
    /// <summary>
    /// 항목 미리 보기 컬렉션을 표시하는 페이지입니다.  분할 응용 프로그램에서 이 페이지는
    /// 사용 가능한 그룹 중 하나를 표시 및 선택하는 데 사용됩니다.
    /// </summary>
    public sealed partial class ItemsPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// NavigationHelper는 각 페이지에서 사용되어 탐색을 지원합니다. 
        /// 프로세스 수명 관리
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// 이는 강력한 형식의 뷰 모델로 변경될 수 있습니다.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public ItemsPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
        }

        /// <summary>
        /// 탐색 중 전달된 콘텐츠로 페이지를 채웁니다.  이전 세션의 페이지를
        /// 다시 만들 때 저장된 상태도 제공됩니다.
        /// </summary>
        /// <param name="sender">
        /// 대개 <see cref="NavigationHelper"/>인 이벤트 소스
        /// </param>
        /// <param name="e">다음에 전달된 탐색 매개 변수를 제공하는 이벤트 데이터입니다.
        /// <see cref="Frame.Navigate(Type, Object)"/>에 전달된 매개 변수와
        /// 이전 세션 동안 이 페이지에 유지된
        /// 사전 상태입니다.  페이지를 처음 방문할 때는 이 상태가 null입니다.</param>
        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: 문제 도메인에 적합한 데이터 모델을 만들어 샘플 데이터를 바꿉니다.
            //var sampleDataGroups = await SampleDataSource.GetGroupsAsync();
            //this.DefaultViewModel["Items"] = sampleDataGroups;
            this.DefaultViewModel["Items"] = new DataModel.ComicQueryManager().AvailableQueries;
        }

        /// <summary>
        /// 항목을 클릭할 때 호출됩니다.
        /// </summary>
        /// <param name="sender">클릭된 항목을 표시하는
        /// GridView(또는 응용 프로그램이 기본 뷰 상태인 경우 ListView)입니다.</param>
        /// <param name="e">클릭된 항목을 설명하는 이벤트 데이터입니다.</param>
        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 해당하는 대상 페이지로 이동합니다. 필요한 정보를 탐색 매개 변수로
            // 전달하여 새 페이지를 구성합니다.
            DataModel.ComicQuery query = e.ClickedItem as DataModel.ComicQuery;
            if (query != null)
            {
                this.Frame.Navigate(typeof(SplitPage), query);
            }
        }

        #region NavigationHelper 등록

        /// 이 섹션에서 제공되는 메서드는 다음을 허용하는 데에만 사용됩니다.
        /// 페이지의 탐색 메서드에 응답하기 위해 NavigationHelper
        /// 
        /// 페이지별 논리는 다음에 대한 이벤트 처리기에 있어야 합니다.  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// 및 <see cref="GridCS.Common.NavigationHelper.SaveState"/>입니다.
        /// 탐색 매개 변수는 LoadState 메서드에서 사용할 수 있습니다. 
        /// 및 이전 세션 동안 유지된 페이지 상태

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
