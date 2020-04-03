﻿using BillingManagement.UI.ViewModels;
using System.Windows;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        CustomerView _wnd;

        public App()
        {
            StudentsViewModel vm = new StudentsViewModel();
            _wnd = new CustomerView(vm);
            _wnd.Show();
        }
    }
}
