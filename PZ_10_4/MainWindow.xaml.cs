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
using System.Collections.ObjectModel;
namespace PZ_10_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
           ObservableCollection<string> _task;
        ObservableCollection<string> _taskdone;
        public MainWindow()
        {
            InitializeComponent();
            _taskdone = new ObservableCollection<string>();
            Taskdone.ItemsSource = _taskdone;
            _task = new ObservableCollection<string> {"test"};
            task.ItemsSource = _task;
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            string exe = Text.Text;
            _task.Add(exe);
            Text.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Taskdone.SelectedIndex != -1)
            {
                _taskdone.RemoveAt(Taskdone.SelectedIndex);

            }
        }

        private void task_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string move = task.SelectedItem.ToString();
            _task.RemoveAt(task.SelectedIndex);
            _taskdone.Add(move);

        }
    }
}
