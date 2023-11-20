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
using WPFPersonalTracking.Model;

namespace WPFPersonalTracking.View
{
    /// <summary>
    /// Interaction logic for DepartmentList.xaml
    /// </summary>
    public partial class Department : UserControl
    {
        public Department()
        {
            DataContext = new DepartmentViewModel();

            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DepartmentViewModel model = (DepartmentViewModel)DataContext;

            model.IsListControlVisible = false;
            model.IsAddVisible = false;
            model.IsUpdateVisible = false;
            model.IsDeleteVisible = false;
            model.IsAddControlVisible = true;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            DepartmentViewModel model = (DepartmentViewModel)DataContext;

            model.IsListControlVisible = false;
            model.IsAddVisible = false;
            model.IsUpdateVisible = false;
            model.IsDeleteVisible = false;
            model.IsAddControlVisible = true;

            model.Department = (WPFPersonalTracking.Model.Department) ListDepartment.grdDepartment.SelectedValue;
        }

    }
}
