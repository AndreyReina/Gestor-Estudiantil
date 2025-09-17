using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibreriaSerializadores
{
    public static class SerializadorCsv
    {
        // Lee un CSV y devuelve lista de filas (cada fila es string[])
        public static List<string[]> LeerCsv(string ruta)
        {
            var resultado = new List<string[]>();
            if (!File.Exists(ruta)) return resultado;

            foreach (var linea in File.ReadAllLines(ruta))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                // split básico por coma. Si necesitas soportar comas dentro de campos, habría que mejorar.
                resultado.Add(linea.Split(',').Select(s => s.Trim()).ToArray());
            }
            return resultado;
        }

        // Guarda una lista de filas (cada fila = string[]) en CSV
        public static void GuardarCsv(string ruta, List<string[]> filas)
        {
            if (filas == null) throw new ArgumentNullException(nameof(filas));
            using (var sw = new StreamWriter(ruta, false))
            {
                foreach (var fila in filas)
                {
                    sw.WriteLine(string.Join(",", fila));
                }
            }
        }
    }
}
