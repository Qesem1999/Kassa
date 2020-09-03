using BeinPos.Infrastructure;
using BeinPos.Models;
using BeinPos.Services;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeinPos
{
     static class Program
    {
        public static Settings ActualSettings = new Settings();
        public static Cash ActualCash = new Cash();
        public static List<Customer> ActualCustomers = new List<Customer>();
        public static List<Product> ActualProduct = new List<Product>();

        static CashService _cashService = null;
        public static CashService GetCashService()
        {
            if (_cashService == null)
            {
                _cashService = new CashService(new CashTransactions());
            }
            return _cashService;
        }

        static ProductService _productService = null;
        public static ProductService GetProductService()
        {
            if (_productService == null)
            {
                _productService = new ProductService(new ProductTransactions());
            }
            return _productService;
        }

        static CustomerService _customerService = null;
        public static CustomerService GetCustomerService()
        {
            if (_customerService == null)
            {
                _customerService = new CustomerService(new CustomerTransactions());
            }

            return _customerService;
        }

        static SettingService _settingService = null;
        public static SettingService GetSettingService()
        {
            if (_settingService == null)
            {
                _settingService = new SettingService(new SettingTransactions());
            }
            return _settingService;
        }




        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ActualSettings = GetSettingService().Get();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}
