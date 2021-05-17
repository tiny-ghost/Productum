using Productum.Persistence;
using Productum.Service;
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
using Productum.Core.Model;

namespace Productum.Desktop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductService _service;
        public MainWindow(ProductService service)
        {
            
            _service = service;

            InitializeComponent();
        }


        private void AddTestRecord()
        {
            _service.AddProduct(new Product { Name = "Tomat", Price = 12.50f, Quanitity = 2, ProductCode = 10001 });
        }

        protected override void OnInitialized(EventArgs e)
        {
            AddTestRecord();
            base.OnInitialized(e);
        }
    }
}
