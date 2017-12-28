using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
using System.Windows.Threading;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for NewTaskDialog.xaml
    /// </summary>
    public partial class NewTaskDialog : UserControl
    {
        private TaskContext _taskDbContext = TaskContextSingleton.Instance;
        private bool _hideRequest = false;
        private bool _windowApproved = false;
        private UIElement _parent;

        public NewTaskDialog()
        {
            InitializeComponent();
            Visibility = Visibility.Hidden;
            InitializePriorityComboBox();
        }

        private void InitializePriorityComboBox()
        {
            priorityComboBox.Items.Add("Low");
            priorityComboBox.Items.Add("Normal");
            priorityComboBox.Items.Add("High");
        }

        public void SetParent(UIElement parent)
        {
            _parent = parent;
        }

        public bool ShowNewTaskDialog()
        {
            Visibility = Visibility.Visible;
            _parent.IsEnabled = false;
            _hideRequest = false;
            WaitForHidingRequest();

            return _windowApproved;
        }

        private void WaitForHidingRequest()
        {
            while (!_hideRequest)
            {
                if (IsMainWindowAboutToClose())
                {
                    break;
                }
                LetMainThreadSleep(20);
            }
        }

        private bool IsMainWindowAboutToClose()
        {
            if (this.Dispatcher.HasShutdownStarted || this.Dispatcher.HasShutdownFinished)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LetMainThreadSleep(int milliseconds)
        {
            this.Dispatcher.Invoke(
                    DispatcherPriority.Background,
                    new ThreadStart(delegate { }));
            Thread.Sleep(milliseconds);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            SaveNewTask();
            ClearNewTaskForm();
            _windowApproved = true;
            HideNewTaskDialog();
        }

        private void SaveNewTask()
        {
            Task newTask = FetchNewTask();
            AddTaskToDatabase(newTask);
        }

        private Task FetchNewTask()
        {
            string _content = contentTextBox.Text.Trim();
            string pattern = @"[^a-zA-Z0-9-'_]";
            _content = Regex.Replace(_content, pattern, @"\$&");
 
            DateTime? _date = dueDateCalendar.SelectedDate;
            int _priority = priorityComboBox.SelectedIndex;
            Task task = new Task()
            {
                content = _content,
                dueDate = _date,
                priority = (byte)_priority,
                status = 0
            };
            return task;
        }

        private void AddTaskToDatabase(Task task)
        {
            _taskDbContext.Tasks.Add(task);
            _taskDbContext.SaveChanges();
        }

        private void ClearNewTaskForm()
        {
            contentTextBox.Text = "";
            dueDateCalendar.SelectedDate = DateTime.Now;
            priorityComboBox.SelectedItem = 1;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ClearNewTaskForm();
            _windowApproved = false;
            HideNewTaskDialog();
        }

        private void HideNewTaskDialog()
        {
            _hideRequest = true;
            Visibility = Visibility.Hidden;
            _parent.IsEnabled = true;
        }
    }
}
