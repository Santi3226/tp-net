namespace WinForms
{
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
            Application.Run(new InicioSesionPaciente());
            Application.Run(new RegistroPaciente());
            Application.Run(new ModificarPaciente());
            Application.Run(new AgregarCA());
            Application.Run(new ModificarCA());
            Application.Run(new BorrarCA());
        }
    }
}