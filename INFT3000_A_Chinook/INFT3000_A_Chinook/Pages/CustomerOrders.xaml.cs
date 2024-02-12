using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.EntityFrameworkCore;
using INFT3000_A_Chinook.Data;
using INFT3000_A_Chinook.Models;

namespace INFT3000_A_Chinook.Pages //Now A3
{
    public partial class CustomerOrders : Page, INotifyPropertyChanged
    {
        private CollectionViewSource _customerViewSource;
        private ChinookContext _dbContext;
        private bool isSearching = false;

        public ObservableCollection<CustomerDetail> CustomerDetails { get; set; }

        public CustomerOrders()
        {
            InitializeComponent();
            _dbContext = new ChinookContext();
            _customerViewSource = (CollectionViewSource)Resources["customerViewSource"];
            CustomerDetails = new ObservableCollection<CustomerDetail>();   
            LoadData();
        }

        private void LoadData()
        {
            // This method loads customer data with LINQ, fulfilling the requirement for the Customer Orders page
            // It includes handling for customers without a state, displaying customer's full name, location, email, and invoices

            var customers = _dbContext.Customers
                .Include(c => c.Invoices)
                .ThenInclude(i => i.InvoiceLines)
                .ToList();

            foreach (var c in customers)
            {
                var customerDetail = new CustomerDetail
                {
                    Customer = c,
                    CustomerName = $"{c.LastName}, {c.FirstName}",
                    Location = $"{c.City}, {(string.IsNullOrEmpty(c.State) ? "N/A" : c.State)}, {c.Country}",
                    Email = c.Email,
                    InvoiceDetails = c.Invoices.Select(i => new InvoiceDetail
                    {
                        InvoiceDate = i.InvoiceDate,
                        Total = i.Total,
                        TrackCount = i.InvoiceLines.Count
                    }).ToList()
                };
                CustomerDetails.Add(customerDetail);
            }

            // Initially, show all customers
            _customerViewSource.Source = CustomerDetails;
        }

        private void CustomerSearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Check if CustomerDetails is not null
            if (CustomerDetails != null)
            {
                string filter = CustomerSearchTextBox.Text.ToLower();
                if (string.IsNullOrWhiteSpace(filter))
                {
                    // If the search box is empty, show all customers
                    _customerViewSource.Source = CustomerDetails;
                    isSearching = false;
                }
                else
                {
                    var filteredData = CustomerDetails.Where(c => c.Customer.LastName.ToLower().Contains(filter)).ToList();
                    _customerViewSource.Source = filteredData;
                    isSearching = true;
                }
            }
        }

        // GotFocus event handler for the search box
        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CustomerSearchTextBox.Text == "Search customers by last name...")
            {
                CustomerSearchTextBox.Text = string.Empty;
            }
        }

        // LostFocus event handler for the search box
        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerSearchTextBox.Text))
            {
                CustomerSearchTextBox.Text = "Search customers by last name...";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class CustomerDetail
    {
        public Customer Customer { get; set; }
        public string CustomerName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }

    public class InvoiceDetail
    {
        public DateTime InvoiceDate { get; set; }
        public decimal Total { get; set; }
        public int TrackCount { get; set; }
    }
}
