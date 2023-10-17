namespace Diseno_Interfaz_Tarea_1._2
{
    public partial class MainPage : ContentPage
    {
        
        public Empleado Empleado { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Empleado = new Empleado();
            BindingContext = Empleado;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaDatos(Empleado));
        }
    }
}