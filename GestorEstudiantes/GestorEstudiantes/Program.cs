using System;
using System.Windows.Forms;

namespace GestorEstudiantes
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia la aplicación con el formulario principal
            Application.Run(new FrmPrincipal());
        }
    }
}
