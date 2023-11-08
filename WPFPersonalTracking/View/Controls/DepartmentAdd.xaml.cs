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
using WPFPersonalTracking.ViewModel;

namespace WPFPersonalTracking.View.Controls
{
    /// <summary>
    /// Interaction logic for DepartmentAdd.xaml
    /// </summary>
    public partial class DepartmentAdd : UserControl
    {
        public DepartmentAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DepartmentViewModel model = (DepartmentViewModel)DataContext;

            model.IsListControlVisible = true;
            model.IsAddVisible = true;
            model.IsUpdateVisible = true;
            model.IsDeleteVisible = true;
            model.IsAddControlVisible = false;
        }
    }
}
