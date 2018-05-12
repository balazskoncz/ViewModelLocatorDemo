using DemoApp.ViewModels;

namespace DemoApp.Locator
{
    class ViewModelLocator
    {
        public MainViewModel Main
        {
            get
            {
                return new MainViewModel();
            }
        }

        public PersonViewModel Person
        {
            get
            {
                return new PersonViewModel();
            }
        }

        public PlanetViewModel Planet
        {
            get
            {
                return new PlanetViewModel();
            }
        }

        public StarShipViewModel StarShip
        {
            get
            {
                return new StarShipViewModel();
            }
        }
    }

}
