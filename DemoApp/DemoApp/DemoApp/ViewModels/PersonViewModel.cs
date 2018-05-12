using DemoApp.Models;
using DemoApp.Views.Base;

namespace DemoApp.ViewModels
{
    class PersonViewModel : AbstractViewModel<PersonModel>
    {
        public PersonViewModel()
        {
            Model.Name = "Han Solo";
            Model.Age = 34;
        }
    }
}
