using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Diseno_Interfaz_Tarea_1._2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaDatos : ContentPage
    {
        public PaginaDatos(Empleado empleado)
        {
            BindingContext = empleado;

        }
    }
}