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

namespace taskmange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaskMangerEntities3 db = new TaskMangerEntities3();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            string Username = txtusername.Text;
            string password=txtpssword.Password;
            var check1 = db.Users.FirstOrDefault(u => u.userNameAdmin == Username && u.userPasswordAdmin == password);
            var check2 = db.Users.FirstOrDefault(u => u.userNameEmp == Username && u.userPasswordEmp == password);
            if (check1 != null )
            {
                MessageBox.Show("Verify");
                winmange win = new winmange();
                win.Show();
                this.Close();
            }
           
            if (check2 != null)
                {
                        MessageBox.Show("Verify");
                        winEmp win = new winEmp();
                        win.Show();
                        this.Close();
                 }
            
        }

        
    }
}
