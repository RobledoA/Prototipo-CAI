namespace Prototipo_CAI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        //HotelesAlmacen.Grabar();
        //VuelosAlmacen.Grabar();
        //AsientosAlmacen.Grabar();
        //HabitacionesAlmacen.Grabar();
        //ItinerariosAlmacen.Grabar();
        //ReservasAlmacen.Grabar();
        //TarifasVuelosAlmacen.Grabar();
        //TiposHabitacionesAlmacen.Grabar();
    }
}