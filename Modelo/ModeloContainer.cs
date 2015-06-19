using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public partial class ModelContainer
    {
        private static ModelContainer model;

        public static ModelContainer GetInstance()
        {
            if (model == null)
            {
                model = new ModelContainer();
            }
            return model;
        }

    }
}
