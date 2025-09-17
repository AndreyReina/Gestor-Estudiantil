using System;
using System.Globalization;

namespace GestorEstudiantes.Clases
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public bool Deportes { get; set; }
        public bool Musica { get; set; }
        public bool Arte { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        // Propiedades calculadas
        public double Promedio => Math.Round((Nota1 + Nota2 + Nota3) / 3, 2);
        public string Estado => Promedio >= 3.0 ? "Aprobado" : "Reprobado";

        // Guardar estudiante en un array de strings para CSV
        public string[] ToArray()
        {
            return new string[]
            {
                Nombre,
                Edad.ToString(),
                Genero,
                Deportes.ToString(),
                Musica.ToString(),
                Arte.ToString(),
                Nota1.ToString(CultureInfo.InvariantCulture),
                Nota2.ToString(CultureInfo.InvariantCulture),
                Nota3.ToString(CultureInfo.InvariantCulture)
            };
        }

        // Cargar estudiante desde un array de strings del CSV
        public static Estudiante FromArray(string[] valores)
        {
            try
            {
                return new Estudiante
                {
                    Nombre = valores[0],
                    Edad = int.Parse(valores[1]),
                    Genero = valores[2],
                    Deportes = bool.Parse(valores[3]),
                    Musica = bool.Parse(valores[4]),
                    Arte = bool.Parse(valores[5]),
                    Nota1 = double.Parse(valores[6], CultureInfo.InvariantCulture),
                    Nota2 = double.Parse(valores[7], CultureInfo.InvariantCulture),
                    Nota3 = double.Parse(valores[8], CultureInfo.InvariantCulture)
                };
            }
            catch
            {
                return null; // En caso de error al convertir
            }
        }
    }
}
