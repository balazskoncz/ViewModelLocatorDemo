using DemoApp.Models;
using DemoApp.Views.Base;

namespace DemoApp.ViewModels
{
    class MainViewModel : AbstractViewModel<MainModel>
    {
        public MainViewModel()
        {
            this.Model.Title = "DemoApp";
        }
    }
}
