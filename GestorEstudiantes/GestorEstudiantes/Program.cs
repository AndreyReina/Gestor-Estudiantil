using System;
using System.Windows.Forms;

namespace GestorEstudiantes
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia la aplicaci�n con el formulario principal
            Application.Run(new FrmPrincipal());
        }
    }
}
