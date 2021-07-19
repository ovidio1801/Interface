using System.IO;
using System;
using System.Collections.Generic;



namespace RRHH.Services
{
    class TextFile
    {
        public static void WriteFile(DateTime fecha, string nombre, decimal monto, string comentario)
        {

            List<string> lines = new List<string>();
            SaltoLineas(ref lines, 5);

            //Procesando fecha
            string Fecha = fecha.ToString("dd/MM/yyyy");
            string lineaFecha = Fecha.PadLeft(71);
            lines.Add(lineaFecha);

            //Nombre y Monto
            SaltoLineas(ref lines, 2);
            string Monto = monto.ToString("###,###,###.00");
            Monto = "***" + Monto + "***";
            
            string Nombre = "*** " + nombre.ToUpper() + " ***";
            string lineaNombre = Nombre.Insert(0, "                 ");
            string lineaMonto = Monto.PadLeft(67 - lineaNombre.Length);
            string lineaNombreMonto = lineaNombre + lineaMonto;
            lines.Add(lineaNombreMonto);

            //Monto en Palabras
            SaltoLineas(ref lines, 2);
            NumLetra nl = new NumLetra();
            string nLetra = nl.Convertir(monto.ToString(),true);
            string Letras = nLetra.Insert(0, "               ");
            string lineaLetras = Letras.PadRight(80);
            lines.Add(lineaLetras);

            //Comentario
            SaltoLineas(ref lines, 16);
            string lineaComentario = comentario.Trim().ToUpper().Insert(0,"     ");
            lines.Add(lineaComentario);
            SaltoLineas(ref lines, 12);


            File.WriteAllLines(@"c:\temp\cheque.txt",lines);

        }

        public static void SaltoLineas(ref List<string> _lines, int num)
        {
            for (int i = 0; i < num; i++)
            {
                _lines.Add("");
            }
            
        }
    }
}
