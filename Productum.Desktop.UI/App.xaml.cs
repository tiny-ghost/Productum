using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Productum.Desktop.UI;
using Productum.Persistence;
using Productum.Service;
using System.Windows;

namespace Productum
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _service;

        public App()
        {
            ServiceCollection services = new();

            services.AddDbContext<ProductumContext>(options =>
            {
                options.UseSqlite("Data Source = tovar.db");
            });

            services.AddSingleton<IUnitOfWork,UnitOfWork>();
            services.AddScoped<ProductService>();


            services.AddSingleton<MainWindow>();

            _service = services.BuildServiceProvider();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _service.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
