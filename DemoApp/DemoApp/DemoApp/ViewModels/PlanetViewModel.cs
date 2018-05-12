using DemoApp.Models;
using DemoApp.Views.Base;

namespace DemoApp.ViewModels
{
    class PlanetViewModel : AbstractViewModel<PlanetModel>
    {
        public PlanetViewModel()
        {
            Model.Name = "Endor";
            Model.Habitable = true;
            Model.Gravity = 0.1;
        }
    }
}
