using DemoApp.Models;
using DemoApp.Views.Base;

namespace DemoApp.ViewModels
{
    class StarShipViewModel : AbstractViewModel<StarShipModel>
    {
        public StarShipViewModel()
        {
            Model.Name = "Millenium Falcon";
            Model.Owner = "Han Solo";
            Model.Type = "IT 2000";
        }
    }
}
