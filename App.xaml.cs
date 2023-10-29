using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkitApp.ViewModels;

namespace CommunityToolkitApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            // ViewModel을 IoC에 등록
            //ViewModel 등록
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<HomePageViewModel>();
            services.AddTransient<CustomerPageViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
