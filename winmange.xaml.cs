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
    /// Interaction logic for winmange.xaml
    /// </summary>
    public partial class winmange : Window
    {
        TaskMangerEntities3 context = new TaskMangerEntities3();
        public winmange()
        {
            InitializeComponent();
            loudtasks();
        }
        private void loudtasks()
        {
            datagridTASKSMANGER.ItemsSource = context.Tasks.ToList();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            var task = new Task
            {
                Task_Title = txttitle.Text,
                Task_Description = txtdescription.Text,
                Task_Status = compoooo.Text,
                Task_DueDate = DateTime.Now,
                Employee_name = txtempname.Text,

            };
           
            context.Tasks. Add(task);
            context.SaveChanges();
            loudtasks();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (datagridTASKSMANGER.SelectedItem is Task selectedtasl)
            {
                selectedtasl.Task_Title = txttitle.Text;
                selectedtasl.Task_Description = txtdescription.Text;
                selectedtasl.Task_Status = compoooo.Text;
                selectedtasl.Task_DueDate = DateTime.Parse(txtdate.Text);
                selectedtasl.Employee_name = txtempname.Text;
                context.SaveChanges();
                loudtasks();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (datagridTASKSMANGER.SelectedItem is Task selectedtasl )
            {
                context.Tasks.Remove(selectedtasl);
                context.SaveChanges();
                loudtasks();
            }
        }

        private void datagridTASKSMANGER_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagridTASKSMANGER.SelectedItem is Task selectedtasl)
            {
                txttitle.Text = selectedtasl.Task_Title;
                txtdescription.Text = selectedtasl.Task_Description;
                compoooo.Text = selectedtasl.Task_Status;
                txtdate.Text = selectedtasl.Task_DueDate.ToString();
                txtempname.Text=selectedtasl.Employee_name;
                loudtasks();
            }
            
        }
    }
}
