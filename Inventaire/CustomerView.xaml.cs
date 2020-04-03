using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
   
        public CustomerView(StudentsViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void NouveauClient(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
         
        }
    }
}
