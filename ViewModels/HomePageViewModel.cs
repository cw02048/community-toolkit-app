using CommunityToolkitApp.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolkitApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public static int Count { get; set; }

        public HomePageViewModel()
        {
            Title = "Home page";
        }

        public override void OnNavigated(object sender, object navigatedEventArgs)
        {
            Count++;
            Message = $"{Count} Navigated";
        }
    }
}
