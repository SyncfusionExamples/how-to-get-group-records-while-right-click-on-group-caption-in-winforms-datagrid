﻿using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Linq;

namespace SfDataGridDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            sfDataGrid.AutoGenerateColumns = false;
            sfDataGrid.DataSource = new ViewModel().Orders;
            sfDataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
            sfDataGrid.AllowEditing = false;
            sfDataGrid.ShowGroupDropArea = true;

            GridNumericColumn gridTextColumn1 = new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID" };
            GridTextColumn gridTextColumn2 = new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" ,AllowEditing=true};
            GridTextColumn gridTextColumn3 = new GridTextColumn() { MappingName = "CustomerName", HeaderText = "Customer Name" };
            GridTextColumn gridTextColumn4 = new GridTextColumn() { MappingName = "Country", HeaderText = "Country" };
            GridTextColumn gridTextColumn5 = new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" };
            GridCheckBoxColumn checkBoxColumn = new GridCheckBoxColumn() { MappingName = "IsShipped", HeaderText = "Is Shipped" };

            sfDataGrid.Columns.Add(gridTextColumn1);
            sfDataGrid.Columns.Add(gridTextColumn2);
            sfDataGrid.Columns.Add(gridTextColumn3);
            sfDataGrid.Columns.Add(gridTextColumn4);
            sfDataGrid.Columns.Add(gridTextColumn5);
            sfDataGrid.Columns.Add(checkBoxColumn);

            sfDataGrid.CellClick += SfDataGrid_CellClick;
           
        }

        private void SfDataGrid_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            //check Right Click on Group Caption in SfDataGrid
            if (e.MouseEventArgs.Button == MouseButtons.Right && (e.DataRow.RowType == RowType.CaptionCoveredRow || e.DataRow.RowType == RowType.CaptionRow))
            {
                //get the Grouped items
                var groupRecords = (e.DataRow.RowData as Group).Records.ToList();
                txtDisplayRecords.Text = "OrderID\tCustomerID\tCustomerName\tCountry\tShipCity\tIsShipped\t\n";
                //itterate items in that group 
                foreach (var record in groupRecords)
                {
                    //here customize based on your scenario
                    if (!record.IsRecords)
                        return;

                    //get the RowData of Grouped item one by one and type cast with underline business object
                    var dataRow = (record as RecordEntry).Data as OrderInfo;

                    txtDisplayRecords.Text += dataRow.OrderID + "\t" + dataRow.CustomerID + "\t\t" + dataRow.CustomerName + "\t" + dataRow.Country + "\t" + dataRow.ShipCity + "\t" + dataRow.IsShipped + "\t\n";
                }
            }
        }        
    }

    public class OrderInfo : INotifyPropertyChanged
    {
        decimal? orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        bool isShipped;

        public OrderInfo()
        {

        }

        public decimal? OrderID
        {
            get { return orderID; }
            set { orderID = value; this.OnPropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; this.OnPropertyChanged("CustomerID"); }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; this.OnPropertyChanged("CustomerName"); }
        }

        public string Country
        {
            get { return country; }
            set { country = value; this.OnPropertyChanged("Country"); }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; this.OnPropertyChanged("ShipCity"); }
        }

        public bool IsShipped
        {
            get { return isShipped; }
            set { isShipped = value; this.OnPropertyChanged("IsShipped"); }
        }


        public OrderInfo(decimal? orderId, string customerName, string country, string customerId, string shipCity, bool isShipped)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.IsShipped = isShipped;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ViewModel
    {
        private ObservableCollection<OrderInfo> orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        public ViewModel()
        {
            orders = new ObservableCollection<OrderInfo>();
            orders.Add(new OrderInfo(1001, "Thomas Hardy", "Germany", "ALFKI", "Berlin", true));
            orders.Add(new OrderInfo(1002, "Laurence Lebihan", "Mexico", "ANATR", "Mexico", false));
            orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico", true));
            orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", true));
            orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula", false));
        }
    }

}
