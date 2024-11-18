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
using System.Windows.Shapes;

namespace taskmange
{
    /// <summary>
    /// Interaction logic for winEmp.xaml
    /// </summary>
    public partial class winEmp : Window
    {
        TaskMangerEntities3 context = new TaskMangerEntities3();
        public winEmp()
        {
            InitializeComponent();
            loudtask();
        }
        private void loudtask()
        {
            datagridtask.ItemsSource = context.Tasks.ToList();
            datagridtask2.ItemsSource= context.Tasks.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagridtask.SelectedItem is Task selectedtask)
            {
                tasktxtId.Text = selectedtask.TaskID.ToString();
                compo.Text=selectedtask.Task_Status.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datagridtask2.SelectedItem is Task selected)
            {
               
                selected.Task_Status=compo.Text;
                 context.SaveChanges();
                loudtask();
            }
           
            
        }

        private void datagridtask2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagridtask2.SelectedItem is Task selected)
            {
               compo.Text = selected.Task_Status;
                tasktxtId.Text=selected.TaskID.ToString();
                loudtask();
            }
           
        }
    }
}
