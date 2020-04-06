using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using BillingManagement.Business;
using System.Windows;
using System.Collections.Generic;

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
            Customers.Add(temp);
            SelectedCustomer = temp;

        }

        private void Quitter(object sender, RoutedEventArgs e)
        {
           this.Close();
        }
    }
}
