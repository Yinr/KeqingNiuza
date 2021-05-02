using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeqingNiuza.Wish;
using KeqingNiuza.Common;
using KeqingNiuza.Model;
using KeqingNiuza.ViewModel;
using System.Windows.Interop;
using System.Runtime.InteropServices;

namespace KeqingNiuza.View
{
    /// <summary>
    /// WishOriginalDataView.xaml 的交互逻辑
    /// </summary>
    public partial class WishOriginalDataView : UserControl
    {

        public WishOriginalDataViewModel ViewModel { get; set; }

        public WishOriginalDataView()
        {
            InitializeComponent();
        }

        public WishOriginalDataView(UserData userData)
        {
            InitializeComponent();
            ViewModel = new WishOriginalDataViewModel(userData);
            DataContext = ViewModel;
        }


        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void Buton_Reset_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ResetFilter();
        }

    }
}