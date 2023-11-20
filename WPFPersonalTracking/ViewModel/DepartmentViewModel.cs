using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFPersonalTracking.Model;
using WPFPersonalTracking.Services;

namespace WPFPersonalTracking.ViewModel
{
    public class DepartmentViewModel : ModelViewBase
    {

        private readonly DepartmentService _service;

        private bool isListControlVisible = true;
        public bool IsListControlVisible
        {
            get { return isListControlVisible; }
            set
            {
                isListControlVisible = value;
                OnPropertyChanged();
            }
        }

        private bool isAddControlVisible;

        public bool IsAddControlVisible
        {
            get { return isAddControlVisible; }
            set
            {
                isAddControlVisible = value;
                OnPropertyChanged();
            }
        }

        private bool isListVisible = true;
        public bool IsListVisible
        {
            get {  return isListVisible; }
            set
            {
                isListVisible = value;
                OnPropertyChanged();
            }
        }

        private bool isAddVisible = true;
        public bool IsAddVisible
        {
            get { return isAddVisible; }
            set
            {
                isAddVisible = value;
                OnPropertyChanged();
            }
        }

        private bool isUpdateVisible = true;
        public bool IsUpdateVisible
        {
            get { return isUpdateVisible; }
            set
            {
                isUpdateVisible = value;
                OnPropertyChanged();
            }
        }

        private bool isDeleteVisible = true;
        public bool IsDeleteVisible
        {
            get { return isDeleteVisible; }
            set
            {
                isDeleteVisible = value;
                OnPropertyChanged();
            }
        }

        private List<Department> _departments;
        public List<Department> Departments
        {
            get { return _departments; }
            set
            {
                _departments = value;
                OnPropertyChanged();
            }
        }

        private Department _department;
        public Department Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        public ICommand UpdateCommand { get; }

        public DepartmentViewModel()
        {
            _service = new DepartmentService();
            SaveCommand = new RelayCommand(ExecuteSaveCommand);
            DeleteCommand = new RelayCommand(ExecuteDeleteCommand, f => IsCommandEnabled());
            UpdateCommand = new RelayCommand(ExecuteUpdateCommand, f => IsCommandEnabled());

            this.Departments = _service.GetAll();
            this.Department = new Department();
        }

        private void ExecuteUpdateCommand(object obj)
        {
            _service.Update(Department);

            this.Department = new Department();
            this.Departments = _service.GetAll();
            DisableActions();
        }

        private bool IsCommandEnabled()
        {
            return this.Department.Id == 0 ? false : true;
        }

        private void ExecuteDeleteCommand(object obj)
        {
            if (this.Department.Id != 0) 
            {

                _service.Delete(Department.Id);

                this.Department = new Department();
                this.Departments = _service.GetAll();
                DisableActions();

            }
        }

        private void ExecuteSaveCommand(object obj)
        {

            _service.Save(Department);
            this.Departments = _service.GetAll();
            
            this.Department = new Department();
            DisableActions();

        }

        private void DisableActions()
        {
            this.IsListControlVisible = true;
            this.IsAddVisible = true;
            this.IsUpdateVisible = true;
            this.IsDeleteVisible = true;
            this.IsAddControlVisible = false;
        }

    }
}
