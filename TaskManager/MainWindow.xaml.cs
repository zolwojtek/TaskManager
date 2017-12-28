using Net.Code.ADONet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private TaskContext _taskDbContext = TaskContextSingleton.Instance;
        private TaskFilter _taskFilter;
        private Task _currentTask;
        private bool _areElementsBeingRendered;

        public MainWindow()
        {
            InitializeComponent();
            CollectionViewSource taskViewSource = ((CollectionViewSource)(this.FindResource("taskViewSource")));
            _taskDbContext.Tasks.Load();
            taskViewSource.Source = _taskDbContext.Tasks.Local;
            NewTaskDialog.SetParent(MainWindowContainer);
            _taskFilter = new TaskFilter(((CollectionViewSource)(this.FindResource("taskViewSource"))));
           
            BlockEditingTaskDataGridUntillRendered();
        }

        private void BlockEditingTaskDataGridUntillRendered()
        {
            _areElementsBeingRendered = true;
            Dispatcher.BeginInvoke(new Action(() => { _areElementsBeingRendered = false; }), DispatcherPriority.ContextIdle, null);
        }

        private void ShowNewTaskDialog_Click(object sender, RoutedEventArgs e)
        {
            var res = NewTaskDialog.ShowNewTaskDialog();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            this._taskDbContext.Dispose();
        }

        private void PriorityComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            List<string> priorityTypes = new List<string> { "Low", "Normal", "High" };
            BuildComboBoxOptionsForCellEditing(currentComboBox, priorityTypes);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void BuildComboBoxOptionsForCellEditing(ComboBox comboBox, List<string> values)
        {
            try
            {
                int orginalNb = Int32.Parse((comboBox.SelectedItem as ComboBoxItem).Content.ToString());
                comboBox.Items.Clear();
                foreach (string value in values)
                {
                    comboBox.Items.Add(value);
                }
                comboBox.SelectedIndex = orginalNb;
            }
            catch
            {
            }
        }

        private void StatusComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            List<string> statusTypes = new List<string> { "New", "In progess", "Done" };
            BuildComboBoxOptionsForCellEditing(currentComboBox, statusTypes);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void TaskDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
              _currentTask = TaskDataGrid.SelectedItem as Task;
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.ShowAll();
            BlockEditingTaskDataGridUntillRendered();
        }

        private void ShowNewButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.FiltrStatus(TaskStatus.NEW);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void ShowInProgressButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.FiltrStatus(TaskStatus.IN_PROGRESS);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void ShowDoneButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.FiltrStatus(TaskStatus.DONE);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void ShowLowPrioButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.FiltrPriority(TaskPriority.LOW);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void ShowNormalPrioButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.FiltrPriority(TaskPriority.NORMAL);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void ShowHighPrioButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDataGrid.ItemsSource = _taskFilter.FiltrPriority(TaskPriority.HIGH);
            BlockEditingTaskDataGridUntillRendered();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            _taskDbContext.Tasks.Remove(_currentTask);
            _taskDbContext.SaveChanges();
        }

        private void TaskDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                FrameworkElement cellControl = TaskDataGrid.Columns[e.Column.DisplayIndex].GetCellContent(e.Row);
                string newContent = ((TextBox)cellControl).Text;

                _currentTask.content = newContent;
                SaveModificationsInDatabase();
            }
            catch
            {
            }
        }

        private void SaveModificationsInDatabase()
        {
            _taskDbContext.Entry(_currentTask).State = EntityState.Modified;
            _taskDbContext.SaveChanges();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int newStatus = ((ComboBox)sender).SelectedIndex;
            if (!_areElementsBeingRendered)
            {
                if (newStatus != _currentTask.status)
                {
                    _currentTask.status = (byte)newStatus;
                    SaveModificationsInDatabase();
                }
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (!_areElementsBeingRendered)
            {
                int newPriority = ((ComboBox)sender).SelectedIndex;
                if (newPriority != _currentTask.priority)
                {
                    _currentTask.priority = (byte)newPriority;
                    SaveModificationsInDatabase();
                }
            }
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            if (!_areElementsBeingRendered)
            {
                DatePicker currentDatePicker = (DatePicker)sender;
                DateTime? newDate = currentDatePicker.SelectedDate;
                if (newDate != _currentTask.dueDate)
                {
                    _currentTask.dueDate = newDate;
                    SaveModificationsInDatabase();
                }
            }
        }

        
    }

   
}
