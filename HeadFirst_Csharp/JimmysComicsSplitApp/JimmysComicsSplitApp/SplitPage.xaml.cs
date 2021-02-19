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

// 분할 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234234에 나와 있습니다.

namespace JimmysComicsSplitApp
{
    /// <summary>
    /// 그룹 제목, 그룹 내의 항목 목록 및
    /// 현재 선택한 항목에 대한 정보를 표시하는 페이지입니다.
    /// </summary>
    public sealed partial class SplitPage : Page
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

        public SplitPage()
        {
            this.InitializeComponent();

            // 탐색 도우미를 설정합니다.
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            // 다음을 허용하는 논리적 페이지 탐색 구성 요소를 설정합니다.
            // 페이지에서 한 번에 하나의 창만 표시합니다.
            this.navigationHelper.GoBackCommand = new RelayCommand(() => this.GoBack(), () => this.CanGoBack());
            this.itemListView.SelectionChanged += ItemListView_SelectionChanged;

            // Window 크기 변경에 대한 수신을 시작합니다. 
            // 두 창 표시에서 단일 창 표시로 변경합니다.
            Window.Current.SizeChanged += Window_SizeChanged;
            this.InvalidateVisualState();

            this.Unloaded += SplitPage_Unloaded;
        }

        /// <summary>
        /// SplitPage가 언로드되면 SizedChanged 이벤트에서 언후크합니다.
        /// </summary>
        private void SplitPage_Unloaded(object sender, RoutedEventArgs e)
        {
            Window.Current.SizeChanged -= Window_SizeChanged;
        }

        /// <summary>
        /// 탐색 중 전달된 콘텐츠로 페이지를 채웁니다. 이전 세션의 페이지를
        /// 다시 만들 때 저장된 상태도 제공됩니다.
        /// </summary>
        /// <param name="sender">
        /// 대개 <see cref="NavigationHelper"/>인 이벤트 소스
        /// </param>
        /// <param name="e">이 페이지가 초기에 요청될 때
        /// <see cref="Frame.Navigate(Type, Object)"/>에 전달되는 탐색 매개 변수와
        /// 이전 세션 동안 이 페이지에 유지된 상태 사전을 제공하는
        /// 이벤트 데이터입니다. 페이지를 처음 방문할 때는 이 상태가 null입니다.< /param>
        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            //var group = await SampleDataSource.GetGroupAsync((String)e.NavigationParameter);
            //this.DefaultViewModel["Group"] = group;
            //this.DefaultViewModel["Items"] = group.Items;

            DataModel.ComicQueryManager comicQueryManager = new DataModel.ComicQueryManager();
            DataModel.ComicQuery query = e.NavigationParameter as DataModel.ComicQuery;
            comicQueryManager.UpdateQueryResults(query);
            this.DefaultViewModel["Group"] = query;
            this.DefaultViewModel["Items"] = comicQueryManager.CurrentQueryResults;

            if (e.PageState == null)
            {
                this.itemListView.SelectedItem = null;
                // 새 페이지인 경우에는 논리 페이지 탐색이 사용 중인 경우를 제외하고 첫 번째 항목이
                // 자동으로 선택됩니다(논리 페이지 탐색 #region은 아래를 참조하십시오.)
                if (!this.UsingLogicalPageNavigation() && this.itemsViewSource.View != null)
                {
                    this.itemsViewSource.View.MoveCurrentToFirst();
                }
            }
            else
            {
                // 이 페이지와 관련하여 이전에 저장된 상태를 복원합니다.
                if (e.PageState.ContainsKey("SelectedItem") && this.itemsViewSource.View != null)
                {
                    var selectedItem = await SampleDataSource.GetItemAsync((String)e.PageState["SelectedItem"]);
                    this.itemsViewSource.View.MoveCurrentTo(selectedItem);
                }
            }
        }

        /// <summary>
        /// 응용 프로그램이 일시 중지되거나 탐색 캐시에서 페이지가 삭제된 경우
        /// 이 페이지와 관련된 상태를 유지합니다. 값은
        /// <see cref="SuspensionManager.SessionState"/>의 serialization 요구 사항을 만족해야 합니다.
        /// </summary>
        /// <param name="navigationParameter">이 페이지가 처음 요청될 때
        /// <see cref="Frame.Navigate(Type, Object)"/>에 전달된 매개 변수 값입니다.
        /// </param>
        /// <param name="sender"> 대개 <see cref="NavigationHelper"/>인 이벤트 소스</param>
        /// <param name="e">serializable 상태로 채워질
        /// 빈 사전입니다.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            //if (this.itemsViewSource.View != null)
            //{
            //    var selectedItem = (Data.SampleDataItem)this.itemsViewSource.View.CurrentItem;
            //    if (selectedItem != null) e.PageState["SelectedItem"] = selectedItem.UniqueId;
            //}
        }

        #region 논리 페이지 탐색

        // 창에 공간이 부족하여
        // 목록과 세부 정보를 모두 표시할 수 없으면 창이 한 번에 한 개만 표시되도록 분할 페이지가 설계되었습니다.
        //
        // 이것은 두 개의 논리 페이지를 나타낼 수 있는 하나의 실제 페이지에서 모두
        // 구현됩니다. 아래 코드에서는 사용자가 구분하지 못하게 이 목표를
        // 달성합니다.

        private const int MinimumWidthForSupportingTwoPanes = 768;

        /// <summary>
        /// 페이지를 하나의 논리 페이지로 사용할지 두 개의 논리 페이지로 사용할지를 결정하기 위해 호출됩니다.
        /// </summary>
        /// <returns>창에서 동작을 하나의 논리 페이지로 표시해야 하는 경우 true, 그렇지 않으면 false
        /// false입니다.</returns>
        private bool UsingLogicalPageNavigation()
        {
            return Window.Current.Bounds.Width < MinimumWidthForSupportingTwoPanes;
        }

        /// <summary>
        /// Window 변경 크기로 호출되었습니다.
        /// </summary>
        /// <param name="sender">현재 Window</param>
        /// <param name="e">Window의 새 크기를 설명하는 이벤트 데이터입니다.</param>
        private void Window_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            this.InvalidateVisualState();
        }

        /// <summary>
        /// 목록 내의 항목을 선택할 때 호출됩니다.
        /// </summary>
        /// <param name="sender">선택한 항목을 표시하는 GridView입니다.</param>
        /// <param name="e">선택 항목이 변경된 방법을 설명하는 이벤트 데이터입니다.</param>
        private void ItemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 논리 페이지 탐색이 적용 중일 때 뷰 상태를 무효화하므로 선택 항목을 변경하면
            // 현재의 논리 페이지에서 해당하는 변경이 일어날 수 있습니다. 항목을
            // 선택하면 항목 목록 표시에서 선택한 항목의 정보 표시로
            // 변경됩니다. 선택을 취소하면 반대의 결과가
            // 발생합니다.
            if (this.UsingLogicalPageNavigation()) this.InvalidateVisualState();
        }

        private bool CanGoBack()
        {
            if (this.UsingLogicalPageNavigation() && this.itemListView.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return this.navigationHelper.CanGoBack();
            }
        }
        private void GoBack()
        {
            if (this.UsingLogicalPageNavigation() && this.itemListView.SelectedItem != null)
            {
                // 논리 페이지 탐색이 적용 중이고 선택한 항목이 있으면
                // 해당 항목의 정보가 현재 표시되어 있습니다. 선택을 취소하면 항목 목록으로
                // 돌아갑니다. 사용자 관점에서 이는 논리적 역방향
                // 탐색입니다.
                this.itemListView.SelectedItem = null;
            }
            else
            {
                this.navigationHelper.GoBack();
            }
        }

        private void InvalidateVisualState()
        {
            var visualState = DetermineVisualState();
            VisualStateManager.GoToState(this, visualState, false);
            this.navigationHelper.GoBackCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// 응용 프로그램 뷰 상태에 해당하는 시각적 상태의 이름을 결정하기 위해
        /// 호출됩니다.
        /// </summary>
        /// <returns>필요한 시각적 상태의 이름입니다. 뷰 상태의 이름과 같습니다.
        /// 단, 선택한 항목이 세로 및 기본 뷰에 있는 경우에는
        /// 접미사 _Detail을 추가하여 이 추가 논리 페이지를 나타냅니다.</returns>
        private string DetermineVisualState()
        {
            if (!UsingLogicalPageNavigation())
                return "PrimaryView";

            // 뷰 상태가 변경될 때 [뒤로] 단추의 사용 가능 상태를 업데이트합니다.
            var logicalPageBack = this.UsingLogicalPageNavigation() && this.itemListView.SelectedItem != null;

            return logicalPageBack ? "SinglePane_Detail" : "SinglePane";
        }

        #endregion

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