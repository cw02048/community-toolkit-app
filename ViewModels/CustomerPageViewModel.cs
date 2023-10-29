using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkitApp.Bases;
using CommunityToolkitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommunityToolkitApp.ViewModels
{
    public class CustomerPageViewModel : ViewModelBase
    {
        public ICommand BackCommand { get; set; }

        public CustomerPageViewModel()
        {
            Init();
        }

        private void Init()
        {
            Title = "Customer page";
            BackCommand = new RelayCommand(OnBack);
        }

        private void OnBack()
        {
            WeakReferenceMessenger.Default.Send(new NavigationMessage("GoBack"));
        }

        public override void OnNavigated(object sender, object navigatedEventArgs)
        {
            Message = "Navigated";
        }
    }
}
