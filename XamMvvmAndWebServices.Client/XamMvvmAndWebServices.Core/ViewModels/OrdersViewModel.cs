﻿using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamMvvmAndWebServices.Helpers;
using XamMvvmAndWebServices.ViewModels;
using XamMvvmAndWebServices.Models;
using System.Collections.ObjectModel;

namespace XamMvvmAndWebServices.ViewModels
{
    public class OrdersViewModel : MvxViewModel
    {

        public OrdersViewModel(IXamarinMVVMSampleWebAPI apiService)
        {
            _apiService = apiService;
            Orders = new ObservableCollection<Order>();
        }

        //used to pass in navigation parameters
        public void Init(NavigationParameters param)
        {
            Customer = _apiService.Customers.GetCustomer(param.CustomerId);
            Reload(null);
            
            
        }

        #region Properties
        
        public ObservableCollection<Order> Orders { get; private set; }

        private string _pageTitle = "Orders";
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetProperty(ref _pageTitle, value); }
        }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set { SetProperty(ref _customer, value); }
        }

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set { SetProperty(ref _selectedOrder, value); }
        }

        private IXamarinMVVMSampleWebAPI _apiService;

        #endregion

        #region Commands

        private MvxCommand<object> _reloadCommand;
        public ICommand ReloadCommand
        {
            get
            {
                _reloadCommand = _reloadCommand ?? new MvxCommand<object>(Reload);
                return _reloadCommand;
            }
        }

        private MvxCommand<object> _addCommand;
        public ICommand AddCommand
        {
            get
            {
                _addCommand = _addCommand ?? new MvxCommand<object>(Add);
                return _addCommand;
            }
        }

        private MvxCommand<object> _editCommand;
        public ICommand EditCommand
        {
            get
            {
                _editCommand = _editCommand ?? new MvxCommand<object>(Edit);
                return _editCommand;
            }
        }

        private MvxCommand<object> _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                _goBackCommand = _goBackCommand ?? new MvxCommand<object>(GoBack);
                return _goBackCommand;
            }
        }
        #endregion

        #region Methods 

        private void Reload(object param)
        {
            Orders.Clear();
            var orders = _apiService.Orders.GetOrders().Where(q => q.CustomerId == Customer.Id);
            foreach (var order in orders)
            {
                if (SelectedOrder == null)
                    SelectedOrder = order;
                Orders.Add(order);
            }

        }

        private void Add(object param)
        {
                ShowViewModel<OrderFormViewModel>(new NavigationParameters() { IsNew = true, CustomerId = (int)_customer.Id });           
        }
        
        private void Edit(object param)
        {            
                ShowViewModel<OrderFormViewModel>(new NavigationParameters() { OrderId = (int)(param as Order).Id });           
        }

        private void GoBack(object param)
        {
            Close(this);
        }

        #endregion
    }
}
