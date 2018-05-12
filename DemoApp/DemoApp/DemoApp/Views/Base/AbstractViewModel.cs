using System;

namespace DemoApp.Views.Base
{
    public class AbstractViewModel<T>
    {
        private T model;

        public T Model
        {
            get
            {
                if (model == null)
                {
                    model = new Lazy<T>().Value;
                    return model;
                }
                else
                {
                    return model;
                }
            }
            set
            {
                model = value;
            }
        }

    }
}
